/* eslint-disable @typescript-eslint/no-explicit-any */
import { StyleSheet, View, Dimensions, ScrollView, Image } from "react-native";
import React, { useEffect, useMemo, useState } from "react";
import {
  useTheme,
  MD3Theme,
  TextInput,
  Text,
  SegmentedButtons,
} from "react-native-paper";
import {
  addHoursToTheSameDay,
  convertTimestampToDateTime,
  formatTime,
  roundToNearestQuarterHour,
} from "@/utils/TimeUtils";
import CurrencyValueInput from "@/components/CurrencyValueInput";
import ActionButtons from "@/components/ActionButtons";
import TimePicker from "@/components/TimePicker";
import { GestureHandlerRootView } from "react-native-gesture-handler";
import SettingsBottomSheet from "@/components/SettingsBottomSheet";
import { TripErrors } from "@/types/Trip";
import { CALENDAR_ICON } from "@/constants/Icons";
import { useAnimatedKeyboard } from "react-native-reanimated";
import TripPointTypePicker from "@/components/TripPointTypePicker";
import { Category, TripPointRequest } from "@/types/TripDayData";
import { Place } from "@/types/Place";
import { useLocalSearchParams, useRouter } from "expo-router";
import LoadingView from "./LoadingView";
import { useSnackbar } from "@/context/SnackbarContext";
import { useAuth } from "@/app/ctx";
import { API_TRIP_POINT, PLACE_DETAILS_ENDPOINT } from "@/constants/Endpoints";
import { useGetTripPoint } from "@/composables/useTripPoint";
import { useTripDetails } from "@/composables/useTripDetails";
import {
  CATEGORY_NAME_LIST,
  CategoryLabelsForProfiles,
  DEFAULT_CATEGORY_NAME,
} from "@/types/Profile";
import { useGetCategories } from "@/composables/useCategoryCondition";
import {
  NEW_OVERLAPPING_ERROR_MESSAGE,
  OVERLAPPING_TRIP_POINTS_MESSAGE,
} from "@/constants/Messages";
import {
  onEndEditingString,
  requiredFieldsForTripPoint,
} from "@/utils/validations";
import usePlaceDetails from "@/composables/usePlace";
import { findAttractionCategory } from "@/utils/CategoryUtils";
import { useShouldRefresh } from "@/context/ShouldRefreshContext";

const { height, width } = Dimensions.get("window");

const EditingTripPointView = () => {
  const theme = useTheme();
  const styles = useMemo(() => createStyles(theme), [theme]);
  const router = useRouter();
  const { showSnackbar } = useSnackbar();

  const params = useLocalSearchParams();
  const { trip_id, day_id, trip_point_id } = params;

  const { date } = useLocalSearchParams();

  useAnimatedKeyboard();

  const { api } = useAuth();

  const {
    tripPointDetails,
    loading: tripPointLoading,
    error: tripPointError,
  } = useGetTripPoint(trip_point_id as string);

  const {
    tripDetails,
    loading: tripLoading,
    error: tripError,
  } = useTripDetails(trip_id as string);

  const [placeId, setPlaceId] = useState<string | undefined>(undefined);

  const {
    placeDetails,
    loading: placeLoading,
    error: placeError,
    success,
    refetch: fetchPlaceDetails,
  } = usePlaceDetails(placeId, PLACE_DETAILS_ENDPOINT, { immediate: false });

  const {
    items: categories,
    loading: categoriesLoading,
    error: categoriesError,
  } = useGetCategories();

  const [tripPointName, setTripPointName] = useState("");

  const [errors, setErrors] = useState<TripErrors>({});
  const [loading, setLoading] = useState<boolean>(false);
  const [isAttraction, setIsAttraction] = useState<boolean>(false);

  const [expectedCost, setExpectedCost] = useState<number>(0);
  const [costType, setCostType] = useState<string>("perPerson");
  const selectedCurrency = tripPointDetails
    ? tripPointDetails.currencyCode
    : "EUR";
  const [comment, setComment] = useState<string>("");
  const [tripPointCategory, setTripPointCategory] = useState<
    Category | undefined
  >();
  const [startTime, setStartTime] = useState<Date>(roundToNearestQuarterHour());
  const [endTime, setEndTime] = useState<Date>(
    addHoursToTheSameDay(startTime, 1),
  );
  const [country, setCountry] = useState<string | null>(null);
  const [state, setState] = useState<string | null>(null);
  const [street, setStreet] = useState<string | null>(null);
  const [city, setCity] = useState<string | null>(null);
  const [houseNumber, setHouseNumber] = useState<string | null>(null);

  const [longitude, setLongitude] = useState<number | null>(null);
  const [latitude, setLatitude] = useState<number | null>(null);
  const [longitudeText, setLongitudeText] = useState<string | null>(null);
  const [latitudeText, setLatitudeText] = useState<string | null>(null);

  const [isStartDatePickerVisible, setIsStartDatePickerVisible] =
    useState<boolean>(false);
  const [isEndDatePickerVisible, setIsEndDatePickerVisible] =
    useState<boolean>(false);
  const [isSheetVisible, setIsSheetVisible] = useState<boolean>(false);

  const [filteredCategories, setFilteredCategories] = useState<Category[]>([]);

  const { addRefreshScreen } = useShouldRefresh();

  useEffect(() => {
    if (tripPointDetails?.place?.id) {
      setPlaceId(tripPointDetails?.place?.id);
    }
  }, [tripPointDetails]);

  useEffect(() => {
    const fetchData = async () => {
      if (placeId) {
        await fetchPlaceDetails();
      }
    };
    fetchData();
  }, [placeId]);

  const handleChange = (
    setter: React.Dispatch<React.SetStateAction<any>>,
    field: keyof TripErrors = "",
    clearError = true,
  ) => {
    return (value: any) => {
      setter(value);
      if (clearError && field) setErrors((prev) => ({ ...prev, [field]: "" }));
    };
  };

  useEffect(() => {
    setFilteredCategories(
      categories.filter((category) =>
        CATEGORY_NAME_LIST.includes(category.name),
      ),
    );
    setTripPointCategory(getCategoryByName(DEFAULT_CATEGORY_NAME));
  }, [categories]);

  useEffect(() => {
    if (tripPointDetails) {
      setTripPointName(tripPointDetails.name);
      setCountry(tripPointDetails.place?.country || null);
      setState(tripPointDetails.place?.state || null);
      setCity(tripPointDetails.place?.city || null);
      setStreet(tripPointDetails.place?.street || null);
      setHouseNumber(tripPointDetails.place?.houseNumber || null);
      setComment(tripPointDetails.comment || "");
      setTripPointCategory(
        tripPointDetails?.place?.superCategory ||
          getCategoryByName(
            placeDetails
              ? findAttractionCategory(placeDetails)
              : DEFAULT_CATEGORY_NAME,
          ),
      );
      setStartTime(convertTimestampToDateTime(tripPointDetails.startTime));
      setEndTime(convertTimestampToDateTime(tripPointDetails.endTime));
      setExpectedCost(tripPointDetails.predictedCost || 0);
    }
    if (placeDetails && success) {
      setLatitude(placeDetails.latitude || null);
      setLongitude(placeDetails.longitude || null);
      setLatitudeText(
        placeDetails.latitude ? placeDetails.latitude.toString() : null,
      );
      setLongitudeText(
        placeDetails.longitude ? placeDetails.longitude.toString() : null,
      );
    }
    setIsAttraction(isAttraction || !!tripPointDetails?.place?.providerId);
  }, [tripPointDetails, placeDetails, success]);

  useEffect(() => {
    setErrors((prev) => ({
      ...prev,
      ["api"]:
        tripError || tripPointError || categoriesError || placeError || "",
    }));
  }, [tripError, tripPointError, categoriesError, placeError]);

  useEffect(() => {
    setLoading(
      tripLoading ||
        tripPointLoading ||
        categoriesLoading ||
        placeLoading ||
        false,
    );
  }, [tripLoading, tripPointLoading, categoriesLoading, placeLoading]);

  useEffect(() => {
    if (errors.api) {
      showSnackbar(errors.api, "error");
    }
  }, [errors.api]);

  const validateForm = () => {
    let hasErrors = false;

    if (expectedCost === undefined || expectedCost < 0) {
      hasErrors = true;
      setErrors((prev) => ({
        ...prev,
        ["expectedCost"]: "Przewidywany koszt jest wymagany",
      }));
    }

    setErrors((prev) => ({
      ...prev,
      ["api"]: "",
    }));

    requiredFieldsForTripPoint.forEach(({ field, errorMessage }) => {
      const fieldValue = {
        tripPointName,
        expectedCost,
        startTime,
        endTime,
      }[field];

      if (!fieldValue) {
        setErrors((prev) => ({
          ...prev,
          [field]: errorMessage,
        }));
        hasErrors = true;
      }
    });

    console.log("hasErrors: " + hasErrors);
    return hasErrors;
  };

  const handleErrorMessage = (errorData: any) => {
    if (errorData === OVERLAPPING_TRIP_POINTS_MESSAGE) {
      return NEW_OVERLAPPING_ERROR_MESSAGE;
    }
    return errorData;
  };

  const handleEditRequest = async (editTripPointRequest: TripPointRequest) => {
    try {
      setLoading(true);

      const response = await api!.put(
        `${API_TRIP_POINT}/${tripPointDetails?.id}`,
        editTripPointRequest,
      );

      if (!response) {
        showSnackbar("Nie udało się edytować punktu wycieczki.");
        return;
      }

      showSnackbar("Punkt wycieczki zapisany!");
      addRefreshScreen("trip-day");
      router.back();
    } catch (err: any) {
      console.error(
        "Błąd podczas zapisywania punktu: ",
        JSON.stringify(err.response.data),
      );
      setErrors((prev) => ({
        ...prev,
        ["api"]: err.response.data,
      }));
      showSnackbar(
        "Nie edytowano punktu wycieczki. " +
          handleErrorMessage(err.response.data),
      );
    } finally {
      setLoading(false);
    }
  };

  const getCategoryByName = (categoryName: string): Category | undefined => {
    return filteredCategories.find(
      (category) => category.name === categoryName,
    );
  };

  const handleChangeTripPointCategory = (item: string) => {
    const category = getCategoryByName(item ?? DEFAULT_CATEGORY_NAME);
    if (category) setTripPointCategory({ ...category });
    else setTripPointCategory(undefined);
  };

  const onCancel = () => {
    console.log("Anulowanie");
    router.back();
  };

  const onSave = async () => {
    setErrors((prev) => ({ ...prev, ["api"]: "" }));
    const hasErrors = validateForm();
    if (!hasErrors) {
      const placeToRequest: Place = {
        name: placeDetails?.name ?? tripPointName,
        superCategoryId: tripPointCategory?.id,
        country: country,
        state: state,
        street: street,
        city: city,
        houseNumber: houseNumber,
        latitude: latitude,
        longitude: longitude,
      } as Place;

      let totalExpectedCost = expectedCost;
      if (costType === "perPerson") {
        const numberOfTravelers = tripDetails
          ? tripDetails?.numberOfTravelers
          : 1;
        totalExpectedCost = numberOfTravelers * expectedCost;
      }

      const tripPointRequest: TripPointRequest = {
        name: tripPointName,
        comment: comment,
        tripDayId: tripPointDetails?.tripDayId || (day_id as string),
        place: placeToRequest,
        startTime: `${formatTime(startTime, true)}`,
        endTime: `${formatTime(endTime, true)}`,
        predictedCost: totalExpectedCost,
      };

      handleEditRequest(tripPointRequest);
    } else {
      showSnackbar("Uzupełnij brakujące pola i popraw błędy!");
    }
  };

  const handleCoordinateChange = (
    coordinateText: string | null,
    setCoordinate: React.Dispatch<React.SetStateAction<number | null>>,
    setErrorField: keyof TripErrors,
    maxValue: number,
  ) => {
    if (!coordinateText) return;
    const numericValue = Number(coordinateText);
    if (!isNaN(numericValue) && Math.abs(numericValue) <= maxValue) {
      setErrors((prev) => ({ ...prev, [setErrorField]: "" }));
      setCoordinate(numericValue);
    } else {
      setErrors((prev) => ({
        ...prev,
        [setErrorField]: `Nieprawidłowa wartość ${setErrorField === "latitude" ? "szerokości" : "długości"} geograficznej`,
      }));
    }
  };

  const handleLatitudeChange = () => {
    handleCoordinateChange(latitudeText, setLatitude, "latitude", 90);
  };

  const handleLongitudeChange = () => {
    handleCoordinateChange(longitudeText, setLongitude, "longitude", 180);
  };

  useEffect(() => {
    if (startTime.getTime() > endTime.getTime()) {
      setErrors((prev) => ({
        ...prev,
        endTime: "Godzina zakończenia jest przed godziną rozpoczęcia",
      }));
    } else {
      setErrors((prev) => ({ ...prev, endTime: "" }));
    }
  }, [startTime, endTime]);

  if (loading) {
    return <LoadingView transparent={false} />;
  }

  return (
    <>
      <GestureHandlerRootView>
        <ScrollView style={styles.scrollView}>
          <View style={styles.container}>
            <TextInput
              mode="outlined"
              style={styles.textInput}
              label="Nazwa"
              value={tripPointName}
              placeholder={tripPointName}
              onChangeText={handleChange(setTripPointName, "tripPointName")}
              onEndEditing={() =>
                onEndEditingString(setTripPointName, tripPointName)
              }
              error={!!errors.tripPointName}
            ></TextInput>
            {errors.tripPointName && (
              <Text style={styles.textError}>{errors.tripPointName}</Text>
            )}

            <TextInput
              mode="outlined"
              style={isAttraction ? styles.textInputDisabled : styles.textInput}
              label="Państwo"
              disabled={isAttraction}
              value={
                isAttraction
                  ? country !== null
                    ? country
                    : "Brak"
                  : country || ""
              }
              onChangeText={handleChange(setCountry, "country")}
              onEndEditing={() => onEndEditingString(setCountry, country)}
              error={!!errors.country}
            ></TextInput>
            {errors.country && (
              <Text style={styles.textError}>{errors.country}</Text>
            )}

            <TextInput
              mode="outlined"
              style={isAttraction ? styles.textInputDisabled : styles.textInput}
              label="Prowincja"
              disabled={isAttraction}
              value={
                isAttraction ? (state !== null ? state : "Brak") : state || ""
              }
              onChangeText={handleChange(setState, "state")}
              onEndEditing={() => onEndEditingString(setState, state)}
              error={!!errors.state}
            ></TextInput>
            {errors.state && (
              <Text style={styles.textError}>{errors.state}</Text>
            )}

            <TextInput
              mode="outlined"
              style={isAttraction ? styles.textInputDisabled : styles.textInput}
              label="Miasto"
              disabled={isAttraction}
              value={
                isAttraction ? (city !== null ? city : "Brak") : city || ""
              }
              onChangeText={handleChange(setCity, "city")}
              onEndEditing={() => onEndEditingString(setCity, city)}
              error={!!errors.city}
            ></TextInput>
            {errors.city && <Text style={styles.textError}>{errors.city}</Text>}

            <TextInput
              mode="outlined"
              style={isAttraction ? styles.textInputDisabled : styles.textInput}
              label="Ulica"
              disabled={isAttraction}
              value={
                isAttraction
                  ? street !== null
                    ? street
                    : "Brak"
                  : street || ""
              }
              onChangeText={handleChange(setStreet, "street")}
              onEndEditing={() => onEndEditingString(setStreet, street)}
              error={!!errors.street}
            ></TextInput>
            {errors.street && (
              <Text style={styles.textError}>{errors.street}</Text>
            )}

            <TextInput
              mode="outlined"
              style={isAttraction ? styles.textInputDisabled : styles.textInput}
              label="Numer adresu"
              disabled={isAttraction}
              value={
                isAttraction
                  ? houseNumber !== null
                    ? houseNumber
                    : "Brak"
                  : houseNumber || ""
              }
              onChangeText={handleChange(setHouseNumber, "houseName")}
              onEndEditing={() =>
                onEndEditingString(setHouseNumber, houseNumber)
              }
              error={!!errors.houseNumber}
            ></TextInput>
            {errors.houseNumber && (
              <Text style={styles.textError}>{errors.houseNumber}</Text>
            )}

            <TextInput
              mode="outlined"
              style={isAttraction ? styles.textInputDisabled : styles.textInput}
              label="Szerokość geograficzna"
              disabled={isAttraction}
              value={
                isAttraction
                  ? latitudeText !== null
                    ? latitudeText
                    : "Brak"
                  : latitudeText || ""
              }
              onChangeText={setLatitudeText}
              onEndEditing={handleLatitudeChange}
              keyboardType="numeric"
              error={!!errors.latitude}
            />
            {errors.latitude && (
              <Text style={styles.textError}>{errors.latitude}</Text>
            )}

            <TextInput
              mode="outlined"
              style={isAttraction ? styles.textInputDisabled : styles.textInput}
              label="Długość geograficzna"
              disabled={isAttraction}
              value={
                isAttraction
                  ? longitudeText !== null
                    ? longitudeText
                    : "Brak"
                  : longitudeText || ""
              }
              onChangeText={setLongitudeText}
              onEndEditing={handleLongitudeChange}
              keyboardType="numeric"
              error={!!errors.longitude}
            />
            {errors.longitude && (
              <Text style={styles.textError}>{errors.longitude}</Text>
            )}

            <CurrencyValueInput
              label={"Przewidywany koszt"}
              budget={expectedCost}
              currency={selectedCurrency}
              currencyDisable={true}
              error={!!errors.expectedCost}
              handleBudgetChange={handleChange(setExpectedCost, "expectedCost")}
            />
            {errors.expectedCost && (
              <Text style={styles.textError}>{errors.expectedCost}</Text>
            )}

            <SegmentedButtons
              value={costType}
              onValueChange={handleChange(setCostType, "costType")}
              style={styles.segmentedButtons}
              buttons={[
                {
                  value: "perPerson",
                  label: "Na osobę",
                },
                {
                  value: "total",
                  label: "Łącznie",
                },
              ]}
            />

            <TextInput
              mode="outlined"
              style={styles.textInput}
              label="Komentarz"
              value={comment}
              placeholder={comment}
              onChangeText={handleChange(setComment, "comment")}
              onEndEditing={() => onEndEditingString(setComment, comment)}
              error={!!errors.comment}
            ></TextInput>
            {errors.comment && (
              <Text style={styles.textError}>{errors.comment}</Text>
            )}

            <TripPointTypePicker
              onPress={() => setIsSheetVisible(true)}
              selectedCategory={tripPointCategory}
              disabled={isAttraction}
            />

            <TextInput
              mode="outlined"
              style={styles.textInput}
              label="Data"
              left={<TextInput.Icon icon={CALENDAR_ICON} />}
              value={date as string}
              placeholder={comment}
              editable={false}
              disabled={true}
            ></TextInput>

            <TimePicker
              date={startTime}
              showPicker={isStartDatePickerVisible}
              setShowPicker={setIsStartDatePickerVisible}
              onDateChange={handleChange(setStartTime, "startTime")}
              label="Godzina rozpoczęcia"
              error={!!errors.startTime || !!errors.endTime}
            ></TimePicker>
            {errors.startTime && (
              <Text style={styles.textError}>{errors.startTime}</Text>
            )}

            <TimePicker
              date={endTime}
              showPicker={isEndDatePickerVisible}
              setShowPicker={setIsEndDatePickerVisible}
              onDateChange={handleChange(setEndTime, "endTime")}
              label="Godzina zakończenia"
              error={!!errors.startTime || !!errors.endTime}
            ></TimePicker>
            {errors.endTime && (
              <Text style={styles.textError}>{errors.endTime}</Text>
            )}
          </View>

          <ActionButtons
            onAction1={onCancel}
            action1ButtonLabel="Anuluj"
            action1Icon={undefined}
            onAction2={onSave}
            action2ButtonLabel="Zapisz"
            action2Icon={undefined}
          />
        </ScrollView>

        <SettingsBottomSheet
          title={"Wybierz rodzaj punktu wycieczki"}
          items={CategoryLabelsForProfiles}
          selectedItem={tripPointCategory?.name || DEFAULT_CATEGORY_NAME}
          isVisible={isSheetVisible && !isAttraction}
          onSelect={(item: string) => {
            handleChangeTripPointCategory(item);
          }}
          onClose={() => setIsSheetVisible(false)}
        />
      </GestureHandlerRootView>
    </>
  );
};

export default EditingTripPointView;

const createStyles = (theme: MD3Theme) =>
  StyleSheet.create({
    scrollView: {
      flex: 1,
      backgroundColor: theme.colors.surface,
      width: width,
    },
    container: {
      flex: 1,
      alignItems: "center",
      paddingBottom: 20,
      backgroundColor: theme.colors.surface,
    },
    image: {
      marginVertical: 25,
      width: "100%",
      height: height * 0.2,
    },
    textInput: {
      width: "90%",
      height: 50,
      marginVertical: 10,
      backgroundColor: theme.colors.surface,
    },
    textInputDisabled: {
      width: "90%",
      height: 50,
      marginVertical: 10,
      backgroundColor: theme.colors.inverseOnSurface,
    },
    modal: {
      backgroundColor: theme.colors.surface,
      marginHorizontal: "10%",
      padding: 20,
      borderRadius: 10,
      alignSelf: "center",
    },
    modalContent: {
      fontSize: 16,
      textAlign: "center",
    },
    modalText: {
      fontSize: 16,
      textAlign: "center",
      marginBottom: 20,
    },
    segmentedButtons: {
      width: 0.9 * width,
      marginVertical: 10,
    },
    textError: {
      color: theme.colors.error,
      width: 0.85 * width,
      textAlign: "left",
      ...theme.fonts.bodySmall,
    },
  });
