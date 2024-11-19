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
  addHoursToTheSameDate,
  formatDateToISO,
  formatDateToPolish,
  formatTime,
  formatToISODate,
  roundToNearestQuarterHour,
} from "@/utils/TimeUtils";
import CurrencyValueInput from "@/components/CurrencyValueInput";
import ActionButtons from "@/components/ActionButtons";
import TimePicker from "@/components/TimePicker";
import { GestureHandlerRootView } from "react-native-gesture-handler";
import SettingsBottomSheet from "@/components/SettingsBottomSheet";
import { AttractionTypeLabels, TripErrors, TripPointType } from "@/types/Trip";
import { CALENDAR_ICON } from "@/constants/Icons";
import { useAnimatedKeyboard } from "react-native-reanimated";
import TripPointTypePicker from "@/components/TripPointTypePicker";
import { CreateTripPointRequest } from "@/types/data";
import { Place } from "@/types/Place";
import { useCreateTripPoint } from "@/composables/useTripPoint";
import { useLocalSearchParams, useRouter } from "expo-router";
import LoadingView from "./LoadingView";
import { useSnackbar } from "@/context/SnackbarContext";
import useTripDetails from "@/composables/useTripDetails";
import usePlaceDetails from "@/composables/usePlace";
import { create } from "react-test-renderer";

const { height, width } = Dimensions.get("window");

const AddingTripPointView = () => {
  const theme = useTheme();
  const styles = useMemo(() => createStyles(theme), [theme]);
  const router = useRouter();
  const { showSnackbar } = useSnackbar();

  const params = useLocalSearchParams();
  const { day_id } = params;
  const trip_id: string = "77b6b9bd-99d8-4b56-b74d-ed69c3a1238a";

  useAnimatedKeyboard();

  const {
    tripDetails,
    loading: tripLoading,
    error: tripError,
  } = useTripDetails(trip_id as string);

  const {
    placeDetails: destinationDetails,
    loading: destinationLoading,
    error: destinationError,
  } = usePlaceDetails(tripDetails?.destinationId);

  const {
    createTripPoint,
    loading: creatingLoading,
    error: createError,
    data: createResponse,
  } = useCreateTripPoint();

  const [tripPointName, setTripPointName] = useState("");
  const [place, setPlace] = useState<Place>({
    country: "",
    state: "",
    city: "",
    street: "",
    houseNumber: "",
    latitude: 0,
    longitude: 0,
    name: "",
  } as Place);

  useEffect(() => {
    console.log(tripDetails);
  }, [tripDetails]);

  useEffect(() => {
    console.log(destinationDetails);
  }, [destinationDetails]);

  const [errors, setErrors] = useState<TripErrors>({});
  const [loading, setLoading] = useState<boolean>(false);

  const [expectedCost, setExpectedCost] = useState<number>(0);
  const [costType, setCostType] = useState<string>("perPerson");
  const selectedCurrency = tripDetails ? tripDetails.currencyCode : "EUR";
  const [comment, setComment] = useState<string>("");
  const [tripPointType, setTripPointType] =
    useState<TripPointType>("attraction");
  const [startTime, setStartTime] = useState<Date>(roundToNearestQuarterHour());
  const [endTime, setEndTime] = useState<Date>(
    addHoursToTheSameDate(startTime, 1),
  );
  const [country, setCountry] = useState<string>("");
  const [state, setState] = useState<string>("");
  const [street, setStreet] = useState<string>("");
  const [city, setCity] = useState<string>("");
  const [houseNumber, setHouseNumber] = useState<string>("");

  const [longitude, setLongitude] = useState<number>(0);
  const [latitude, setLatitude] = useState<number>(0);

  const [longitudeText, setLongitudeText] = useState<string>("0.00");
  const [latitudeText, setLatitudeText] = useState<string>("0.00");

  const [isStartDatePickerVisible, setIsStartDatePickerVisible] =
    useState<boolean>(false);
  const [isEndDatePickerVisible, setIsEndDatePickerVisible] =
    useState<boolean>(false);
  const [isSheetVisible, setIsSheetVisible] = useState<boolean>(false);

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
    if (destinationDetails) {
      setCountry(destinationDetails.country || "");
      setState(destinationDetails.state || "");
      setCity(destinationDetails.city || "");
      setStreet(destinationDetails.street || "");
      setHouseNumber(destinationDetails.houseNumber || "");
    }
  }, [destinationDetails]);

  useEffect(() => {
    setErrors((prev) => ({
      ...prev,
      ["api"]: tripError || createError || destinationError || "",
    }));
  }, [tripError, createError, destinationError]);

  useEffect(() => {
    setLoading(tripLoading || creatingLoading || destinationLoading || false);
  }, [tripLoading, creatingLoading, destinationLoading]);

  const requiredFields = [
    {
      field: "tripPointName",
      errorMessage: "Nazwa punktu wycieczki jest wymagana.",
    },
    {
      field: "country",
      errorMessage: "Nazwa państwa jest wymagana.",
    },
    { field: "city", errorMessage: "Nazwa miasta jest wymagana." },
    {
      field: "startTime",
      errorMessage: "Godzina rozpoczęcia jest wymagana.",
    },
    {
      field: "endTime",
      errorMessage: "Godzina zakończenia jest wymagana.",
    },
  ];

  const onSave = async () => {
    let hasErrors = false;

    if (expectedCost === undefined || expectedCost < 0) {
      hasErrors = true;
      setErrors((prev) => ({
        ...prev,
        ["expectedCost"]: "Przewidywany koszt jest wymagany",
      }));
    }

    requiredFields.forEach(({ field, errorMessage }) => {
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

    if (!hasErrors) {
      setPlace({
        name: tripPointName,
        country: country,
        state: state,
        street: street,
        city: city,
        houseNumber: houseNumber,
        latitude: latitude ? latitude : 0,
        longitude: longitude ? longitude : 0,
      } as Place);

      let totalExpectedCost = expectedCost;
      if (costType === "perPerson") {
        const numberOfTravelers = tripDetails
          ? tripDetails?.numberOfTravelers
          : 1;
        totalExpectedCost = numberOfTravelers * expectedCost;
      }

      const tripPointRequest: CreateTripPointRequest = {
        name: tripPointName,
        comment: comment,
        tripDayId: day_id as string,
        place: place,
        startTime: `${formatTime(startTime)}:00`,
        endTime: `${formatTime(endTime)}:00`,
        predictedCost: totalExpectedCost,
      };

      console.log("Place: " + JSON.stringify(place));

      await createTripPoint(tripPointRequest);

      if (!createResponse) {
        showSnackbar("Wystąpił błąd przy dodawaniu punktu wycieczki");
        return;
      }

      showSnackbar("Punkt wycieczki zapisany!");
      console.log(JSON.stringify(createResponse));
      console.log("Punkt wycieczki zapisany!");
      router.back();
    } else {
      showSnackbar("Uzupełnij brakujące pola i popraw błędy!");
      console.log(JSON.stringify(errors));
    }
  };

  const handleCoordinateChange = (
    coordinateText: string,
    setCoordinate: React.Dispatch<React.SetStateAction<number>>,
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
    console.log("ExpectedCost: " + expectedCost);
  }, [expectedCost]);

  useEffect(() => {
    console.log("Errors: " + JSON.stringify(errors));
  }, [errors]);

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
    return <LoadingView />;
  }

  if (errors.api) {
    showSnackbar(errors.api, "error");
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
              selectedTripPointType={tripPointType}
            />

            <TextInput
              mode="outlined"
              style={styles.textInput}
              label="Data"
              left={<TextInput.Icon icon={CALENDAR_ICON} />}
              value={startTime.toLocaleDateString()}
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
            onAction1={() => console.log("Anulowanie")}
            action1ButtonLabel="Anuluj"
            action1Icon={undefined}
            onAction2={onSave}
            action2ButtonLabel="Zapisz"
            action2Icon={undefined}
          />
        </ScrollView>

        <SettingsBottomSheet
          title={"Wybierz rodzaj punktu wycieczki"}
          items={AttractionTypeLabels}
          selectedItem={tripPointType}
          isVisible={isSheetVisible}
          onSelect={(item: string) => {
            setTripPointType(item as TripPointType);
          }}
          onClose={() => setIsSheetVisible(false)}
        />
      </GestureHandlerRootView>
    </>
  );
};

export default AddingTripPointView;

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
