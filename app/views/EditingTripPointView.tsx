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
import { API_TRIP_POINT } from "@/constants/Endpoints";
import { useGetTripPoint } from "@/composables/useTripPoint";
import useTripDetails from "@/composables/useTripDetails";
import {
  CATEGORY_NAME_LIST,
  CategoryLabels,
  DEFAULT_CATEGORY_NAME,
} from "@/types/Profile";
import { useGetCategories } from "@/composables/useCategoryCondition";
import {
  NEW_OVERLAPPING_ERROR_MESSAGE,
  OVERLAPPING_TRIP_POINTS_MESSAGE,
} from "@/constants/Messages";
import { requiredFieldsForTripPoint } from "@/utils/validations";

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

  const {
    categories,
    loading: categoriesLoading,
    error: categoriesError,
  } = useGetCategories();

  const [tripPointName, setTripPointName] = useState("");

  const [errors, setErrors] = useState<TripErrors>({});
  const [loading, setLoading] = useState<boolean>(false);

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
  const [country, setCountry] = useState<string>("");
  const [state, setState] = useState<string>("");
  const [street, setStreet] = useState<string>("");
  const [city, setCity] = useState<string>("");
  const [houseNumber, setHouseNumber] = useState<string>("");

  const [longitude, setLongitude] = useState<number | null>(null);
  const [latitude, setLatitude] = useState<number | null>(null);
  const [longitudeText, setLongitudeText] = useState<string>("");
  const [latitudeText, setLatitudeText] = useState<string>("");

  const [isStartDatePickerVisible, setIsStartDatePickerVisible] =
    useState<boolean>(false);
  const [isEndDatePickerVisible, setIsEndDatePickerVisible] =
    useState<boolean>(false);
  const [isSheetVisible, setIsSheetVisible] = useState<boolean>(false);

  const [filteredCategories, setFilteredCategories] = useState<Category[]>([]);

  const handleChange = (
    setter: React.Dispatch<React.SetStateAction<any>>,
    field: keyof TripErrors = "",
    clearError = true,
  ) => {
    return (value: any) => {
      if (typeof value === "string") setter(value.trim());
      else setter(value);
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
      console.log(JSON.stringify(tripPointDetails));
      setTripPointName(tripPointDetails.name || "");
      setCountry(tripPointDetails.place?.country || "");
      setState(tripPointDetails.place?.state || "");
      setCity(tripPointDetails.place?.city || "");
      setStreet(tripPointDetails.place?.street || "");
      setHouseNumber(tripPointDetails.place?.houseNumber || "");
      setComment(tripPointDetails.comment || "");
      setTripPointCategory(
        tripPointDetails?.place?.superCategory ||
          getCategoryByName(DEFAULT_CATEGORY_NAME),
      );
      setStartTime(convertTimestampToDateTime(tripPointDetails.startTime));
      setEndTime(convertTimestampToDateTime(tripPointDetails.endTime));
      setExpectedCost(tripPointDetails.predictedCost || 0);
    }
  }, [tripPointDetails]);

  useEffect(() => {
    setErrors((prev) => ({
      ...prev,
      ["api"]: tripError || tripPointError || categoriesError || "",
    }));
  }, [tripError, tripPointError, categoriesError]);

  useEffect(() => {
    setLoading(tripLoading || tripPointLoading || categoriesLoading || false);
  }, [tripLoading, tripPointLoading, categoriesLoading]);

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
        country,
        city,
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
      router.back();
      router.setParams({
        refresh: "true",
      });
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
    console.log(filteredCategories);
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
        name: tripPointName,
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
    coordinateText: string,
    setCoordinate: React.Dispatch<React.SetStateAction<number | null>>,
    setErrorField: keyof TripErrors,
    maxValue: number,
  ) => {
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
    return <LoadingView transparent={true} />;
  }

  return (
    <>
      <GestureHandlerRootView>
        <ScrollView style={styles.scrollView}>
          <View style={styles.container}>
            <Image
              source={{
                uri: "https://upload.wikimedia.org/wikipedia/commons/1/1a/Big_Ben..JPG",
              }}
              style={styles.image}
              resizeMode="cover"
            />

            <TextInput
              mode="outlined"
              style={styles.textInput}
              label="Nazwa"
              value={tripPointName}
              placeholder={tripPointName}
              onChangeText={handleChange(setTripPointName, "tripPointName")}
              error={!!errors.tripPointName}
            ></TextInput>
            {errors.tripPointName && (
              <Text style={styles.textError}>{errors.tripPointName}</Text>
            )}

            <TextInput
              mode="outlined"
              style={styles.textInput}
              label="Państwo"
              value={country}
              placeholder={country}
              onChangeText={handleChange(setCountry, "country")}
              error={!!errors.country}
            ></TextInput>
            {errors.country && (
              <Text style={styles.textError}>{errors.country}</Text>
            )}

            <TextInput
              mode="outlined"
              style={styles.textInput}
              label="Prowincja"
              value={state}
              placeholder={state}
              onChangeText={handleChange(setState, "state")}
              error={!!errors.state}
            ></TextInput>
            {errors.state && (
              <Text style={styles.textError}>{errors.state}</Text>
            )}

            <TextInput
              mode="outlined"
              style={styles.textInput}
              label="Miasto"
              value={city}
              placeholder={city}
              onChangeText={handleChange(setCity, "city")}
              error={!!errors.city}
            ></TextInput>
            {errors.city && <Text style={styles.textError}>{errors.city}</Text>}

            <TextInput
              mode="outlined"
              style={styles.textInput}
              label="Ulica"
              value={street}
              placeholder={street}
              onChangeText={handleChange(setStreet, "street")}
              error={!!errors.street}
            ></TextInput>
            {errors.street && (
              <Text style={styles.textError}>{errors.street}</Text>
            )}

            <TextInput
              mode="outlined"
              style={styles.textInput}
              label="Numer adresu"
              value={houseNumber}
              placeholder={houseNumber}
              onChangeText={handleChange(setHouseNumber, "houseName")}
              error={!!errors.houseNumber}
            ></TextInput>
            {errors.houseNumber && (
              <Text style={styles.textError}>{errors.houseNumber}</Text>
            )}

            <TextInput
              mode="outlined"
              style={styles.textInput}
              label="Szerokość geograficzna"
              value={latitudeText}
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
              style={styles.textInput}
              label="Długość geograficzna"
              value={longitudeText}
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
              disable={true}
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
              error={!!errors.comment}
            ></TextInput>
            {errors.comment && (
              <Text style={styles.textError}>{errors.comment}</Text>
            )}

            <TripPointTypePicker
              onPress={() => setIsSheetVisible(true)}
              selectedCategory={tripPointCategory}
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
          items={CategoryLabels}
          selectedItem={tripPointCategory?.name || DEFAULT_CATEGORY_NAME}
          isVisible={isSheetVisible}
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
