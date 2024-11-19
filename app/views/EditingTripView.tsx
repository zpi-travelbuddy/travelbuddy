/* eslint-disable @typescript-eslint/no-explicit-any */
import {
  StyleSheet,
  View,
  Image,
  Dimensions,
  ScrollView,
  FlatList,
} from "react-native";
import React, { useCallback, useEffect, useMemo, useState } from "react";
import { useTheme, MD3Theme, TextInput, Text } from "react-native-paper";
import {
  DatePickerModal,
  pl,
  registerTranslation,
} from "react-native-paper-dates";
import {
  formatDateRange,
  formatDateToISO,
  getISOToday,
} from "@/utils/TimeUtils";
import CurrencyValueInput from "@/components/CurrencyValueInput";
import CustomModal from "@/components/CustomModal";
import { RenderItem } from "@/components/RenderItem";
import ActionButtons from "@/components/ActionButtons";
import ClickableInput from "@/components/ClickableInput";
import { TripRequest, TripResponse, TripErrors, EditTripRequest } from "@/types/Trip";
import { useLocalSearchParams, useRouter } from "expo-router";
import useTripDetails, {
  useEditTripDetails,
} from "@/composables/useTripDetails";
import { useSnackbar } from "@/context/SnackbarContext";
import LoadingView from "./LoadingView";
import { CALENDAR_ICON, MARKER_ICON } from "@/constants/Icons";
import {
  useGetCategoryProfiles,
  useGetConditionProfiles,
} from "@/composables/useProfiles";
import usePlaceDetails from "@/composables/usePlace";
import { convertTripResponseToEditTripRequest } from "@/converters/tripConverters";
import { Place } from "@/types/Place";
import { getDisplayPlace } from "@/utils/TextUtils";
import { Profile, ProfileType } from "@/types/Profile";

const { height, width } = Dimensions.get("window");

registerTranslation("pl", pl);

const EditTripView = () => {
  // =====================
  // SECTION: Hook calls (API or logic hooks)
  // =====================

  const theme = useTheme();
  const styles = useMemo(() => createStyles(theme), [theme]);
  const router = useRouter();
  const { showSnackbar } = useSnackbar();
  const params = useLocalSearchParams();
  const { trip_id } = params;

  const [editTripRequest, setEditTripRequest] = useState<EditTripRequest>({} as EditTripRequest)

  const {
    tripDetails,
    loading: tripLoading,
    error: tripError,
    refetch: tripRefetch,
  } = useTripDetails(trip_id as string);

  const {
    placeDetails: destinationDetails,
    loading: destinationLoading,
    error: destinationError,
    refetch: destinationRefetch,
  } = usePlaceDetails(tripDetails?.destinationId);

  const {
    editTrip,
    loading: editTripLoading,
    error: editError,
    success: editSuccess,
  } = useEditTripDetails(trip_id as string, editTripRequest, { immediate: false });

  // =====================
  // SECTION: useState variables
  // =====================

  const [error, setError] = useState<string | null>(null);
  const [loading, setLoading] = useState<boolean>(false);

  const [errors, setErrors] = useState<TripErrors>({});
  const [numberOfPeople, setNumberOfPeople] = useState<string>("");

  const [dateRange, setDateRange] = useState<{
    startDate: Date;
    endDate: Date;
  }>({
    startDate: new Date(),
    endDate: new Date(),
  });

  const [dateRangeText, setDateRangeText] = useState<string>(
    formatDateRange(dateRange.startDate, dateRange.endDate),
  );

  const [isOpen, setOpen] = useState<boolean>(false);
  const [visible, setVisible] = useState<boolean>(false);

  const [categoryProfileId, setCategoryProfileId] = useState<string | null>(
    null,
  );
  const [conditionProfileId, setConditionProfileId] = useState<string | null>(
    null,
  );

  const [profileType, setProfileType] = useState<ProfileType>("Category");

  const [categoryProfiles, setCategoryProfiles] = useState<Profile[]>([
    { id: "1", name: "Profile1" },
    { id: "2", name: "Zwiedzanie i jedzenie" },
  ]);

  const [conditionProfiles, setConditionProfiles] = useState<Profile[]>([
    { id: "11", name: "Profile11" },
    { id: "22", name: "Potrzebuję internetu dla psa" },
  ]);

  // =====================
  // SECTION: useEffect hooks
  // =====================

  useEffect(() => {
    setError(tripError || destinationError || "");
  }, [tripError, destinationError, editError]);

  useEffect(() => {
    setLoading(tripLoading || destinationLoading || editTripLoading || false);
  }, [tripLoading, destinationLoading, editTripLoading]);

  useEffect(() => {
    if (tripDetails && destinationDetails) {
      setEditTripRequest(
        convertTripResponseToEditTripRequest(
          tripDetails,
          destinationDetails as Place,
        ),
      );
      setNumberOfPeople(tripDetails.numberOfTravelers.toString());
      setDateRange({
        startDate: new Date(tripDetails.startDate),
        endDate: new Date(tripDetails.endDate),
      });
      setCategoryProfileId("null");
      setConditionProfileId("null");
    }
  }, [tripDetails, destinationDetails]);

  useEffect(() => {
    console.log("TripDetails: " + JSON.stringify(tripDetails));
  }, [tripDetails]);

  useEffect(() => {
    console.log("DestinationDetails: " + JSON.stringify(destinationDetails));
  }, [destinationDetails]);

  useEffect(() => {
    setDateRangeText(formatDateRange(dateRange.startDate, dateRange.endDate));
  }, [dateRange]);

  useEffect(() => {
    if (editSuccess !== null) {
      if (editSuccess) showSnackbar("Wycieczka została zapisana!", "success");
      else showSnackbar("Błąd przy zapisie wycieczki", "error");
    }
  }, [editSuccess]);

  useEffect(() => {
    console.log(editError);
  }, [editError]);

  // =====================
  // SECTION: Functions
  // =====================

  const saveTrip = async () => {
    if (!editTripRequest.destinationPlace.providerId) {
      showSnackbar("Błąd z celem wycieczki!", "error");
      console.error(editTripRequest.destinationPlace.providerId);
    }
    try {
      setEditTripRequest((prev) => ({
        ...prev,
        startDate: formatDateToISO(dateRange.startDate),
        endDate: formatDateToISO(dateRange.endDate),
      }));
      if (
        !editTripRequest.name ||
        !editTripRequest.startDate ||
        !editTripRequest.endDate ||
        !editTripRequest.numberOfTravelers ||
        !editTripRequest.budget
        // || !editTripRequest.categoryProfileId   // TODO available in future
        // || !editTripRequest.conditionProfileId
      ) {
        console.log("EditTripRequest: " + JSON.stringify(editTripRequest));
        showSnackbar("Proszę uzupełnić wszystkie wymagane pola!", "error");
        return;
      }
      await editTrip();
    } catch (error) {
      showSnackbar("Błąd podczas zapisywania wycieczki!", "error");
      console.error(error);
    }
  };

  const handleChange = (field: keyof TripErrors = "", clearError = true) => {
    return (value: any) => {
      setEditTripRequest((prev) => ({ ...prev, [field]: value }));
      if (clearError && field) setErrors((prev) => ({ ...prev, [field]: "" }));
    };
  };

  const validateNumberOfPeople = () => {
    const numericValue = numberOfPeople.replace(/[^0-9]/g, "");
    const parsedValue = parseInt(numericValue, 10);
    if (!isNaN(parsedValue) && parsedValue > 0)
      setNumberOfPeople(parsedValue.toString());
    else setNumberOfPeople("");
  };

  const getProfileName = (profileType: ProfileType, id: string | null) => {
    if (id) {
      let profiles;
      if (profileType === "Category") profiles = categoryProfiles;
      else if (profileType === "Condition") profiles = conditionProfiles;
      else throw new Error();
      const profile = profiles.find((p) => p.id === id);
      return profile ? profile.name : "Brak";
    } else return "Brak";
  };

  const handleProfileSelection = useCallback(
    (profile: Profile) => {
      if (profileType === "Category") setCategoryProfileId(profile.id);
      else setConditionProfileId(profile.id);
    },
    [profileType],
  );

  // =====================
  // SECTION: Return JSX (UI rendering)
  // =====================

  if (loading) {
    return <LoadingView />;
  }

  if (error) {
    router.back();
    showSnackbar(error?.toString(), "error");
    return null;
  }

  return (
    <>
      <ScrollView style={styles.scrollView}>
        <View style={styles.container}>
          <Image
            source={{
              uri: "https://upload.wikimedia.org/wikipedia/commons/1/1a/Big_Ben..JPG",
            }}
            style={styles.image}
            resizeMode="cover"
          />
          <View style={styles.form}>
            <TextInput
              mode="outlined"
              style={styles.textInput}
              label="Nazwa"
              value={editTripRequest.name}
              onChangeText={handleChange("name")}
              error={!!errors.name}
            />
            {errors.name && <Text style={styles.textError}>{errors.name}</Text>}

            <ClickableInput
              label="Termin wycieczki"
              value={dateRangeText}
              onPress={() => setOpen(true)}
              icon={CALENDAR_ICON}
              error={!!errors.range && !dateRange.startDate}
            />
            {errors.range && !dateRange.startDate && (
              <Text style={styles.textError}>{errors.range}</Text>
            )}

            <ClickableInput
              label="Cel wycieczki"
              value={getDisplayPlace(editTripRequest.destinationPlace)}
              onPress={() => router.push("/trips/add/destination")}
              icon={MARKER_ICON}
              error={!!errors.destinationPlace}
            />
            {errors.destination && (
              <Text style={styles.textError}>{errors.destinationPlace}</Text>
            )}

            <TextInput
              mode="outlined"
              style={styles.textInput}
              label="Liczba osób"
              value={numberOfPeople}
              onChangeText={setNumberOfPeople}
              onEndEditing={validateNumberOfPeople}
              keyboardType="numeric"
              error={!!errors.numberOfPeople}
            />
            {errors.numberOfPeople && (
              <Text style={styles.textError}>{errors.numberOfPeople}</Text>
            )}

            <CurrencyValueInput
              budget={editTripRequest.budget}
              currency={editTripRequest.currencyCode}
              handleBudgetChange={handleChange("budget")}
              error={!!errors.budget}
            />
            {errors.budget && (
              <Text style={styles.textError}>{errors.budget}</Text>
            )}

            <ClickableInput
              icon="account"
              label="Profil preferencji"
              value={getProfileName("Category", categoryProfileId)}
              onPress={() => {
                setProfileType("Category");
                setVisible(true);
              }}
            />
            <ClickableInput
              icon="account"
              label="Profil udogodnień"
              value={getProfileName("Condition", conditionProfileId)}
              onPress={() => {
                setProfileType("Condition");
                setVisible(true);
              }}
            />

            <CustomModal visible={visible} onDismiss={() => setVisible(false)}>
              <FlatList
                data={
                  profileType === "Category"
                    ? categoryProfiles
                    : conditionProfiles
                }
                renderItem={({ item }) => (
                  <RenderItem
                    item={item}
                    isSelected={
                      (profileType === "Category"
                        ? categoryProfileId
                        : conditionProfileId) === item.id
                    }
                    onSelect={handleProfileSelection}
                    renderContent={(item) => item.name}
                  />
                )}
                keyExtractor={(item) => item.id}
                ItemSeparatorComponent={() => <View />}
                ListEmptyComponent={<Text>Brak dostępnych profili</Text>}
              />
            </CustomModal>
          </View>
          <DatePickerModal
            mode="range"
            visible={isOpen}
            onDismiss={() => setOpen(false)}
            startDate={dateRange.startDate}
            endDate={dateRange.endDate}
            onConfirm={({ startDate, endDate }) => {
              setOpen(false);

              if (startDate && endDate) {
                setDateRange({
                  startDate: new Date(startDate),
                  endDate: new Date(endDate),
                });
              } else {
                console.log("startDate i/lub endDate jest undefined");
              }
            }}
            locale="pl"
            validRange={{ startDate: getISOToday() }}
            startWeekOnMonday
          />
        </View>

        <ActionButtons
          onAction1={router.back}
          onAction2={saveTrip}
          action1ButtonLabel="Anuluj"
          action2ButtonLabel="Zapisz"
          action1Icon={undefined}
          action2Icon={undefined}
        />
      </ScrollView>
    </>
  );
};

export default EditTripView;

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
    form: {
      flex: 1,
      gap: 10,
      alignItems: "center",
      width: width,
    },
    image: { marginVertical: 25, width: "100%", height: height * 0.2 },
    textInput: {
      width: "90%",
      height: 50,
      backgroundColor: theme.colors.surface,
    },
    textError: {
      marginHorizontal: "5%",
      color: theme.colors.error,
      alignSelf: "flex-start",
    },
  });
