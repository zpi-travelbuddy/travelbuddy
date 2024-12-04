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
import { TripErrors, TripRequest } from "@/types/Trip";
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
  const {
    trip_id,
    destinationId: new_destination_id,
    destinationName: new_destination_name,
  } = params;

  const [editTripRequest, setEditTripRequest] = useState<TripRequest>(
    {} as TripRequest,
  );

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
    editTrip,
    loading: editTripLoading,
    error: editError,
    success: editSuccess,
  } = useEditTripDetails(trip_id as string, editTripRequest, {
    immediate: false,
  });

  // =====================
  // SECTION: useState variables
  // =====================

  const [error, setError] = useState<string | null>(null);
  const [loading, setLoading] = useState<boolean>(false);

  const [errors, setErrors] = useState<TripErrors>({});
  const [numberOfPeople, setNumberOfPeople] = useState<string>("");
  const [destinationName, setDestinationName] = useState<string>("");

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
    if (destinationDetails && !new_destination_id) {
      setDestinationName(getDisplayPlace(destinationDetails));
    } else if (new_destination_id && new_destination_name) {
      setDestinationName(new_destination_name as string);
      setEditTripRequest((prev) => ({
        ...prev,
        destinationProviderId: new_destination_id as string,
      }));
    } else console.log("ERRRRROR");
  }, [destinationDetails, new_destination_id]);

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
    setEditTripRequest((prev) => ({
      ...prev,
      startDate: formatDateToISO(dateRange.startDate),
      endDate: formatDateToISO(dateRange.endDate),
    }));
    setDateRangeText(formatDateRange(dateRange.startDate, dateRange.endDate));
  }, [dateRange]);

  useEffect(() => {
    if (editSuccess) {
      showSnackbar("Wycieczka została zapisana!", "success");
      router.back();
      router.setParams({
        refresh: "true",
      });
    } else showSnackbar("Błąd przy zapisie wycieczki", "error");
  }, [router, editSuccess]);

  // =====================
  // SECTION: Functions
  // =====================

  const saveTrip = async () => {
    if (!editTripRequest.destinationProviderId) {
      showSnackbar("Błąd z celem wycieczki!", "error");
      console.error(editTripRequest.destinationProviderId);
    }

    let hasErrors = false;
    if (!editTripRequest.name) {
      hasErrors = true;
      setErrors((prev) => ({
        ...prev,
        name: "Nazwa wycieczki jest wymagana.",
      }));
    }
    if (!dateRange.startDate) {
      hasErrors = true;
      setErrors((prev) => ({
        ...prev,
        startDate: "Termin wycieczki jest wymagany.",
      }));
    }
    if (!editTripRequest.destinationProviderId) {
      hasErrors = true;
      setErrors((prev) => ({
        ...prev,
        providerId: "Cel wycieczki jest wymagany.",
      }));
    }
    if (!numberOfPeople) {
      hasErrors = true;
      setErrors((prev) => ({
        ...prev,
        numberOfTravelers: "Liczba osób jest wymagana.",
      }));
    } else if (editTripRequest.numberOfTravelers < 1) {
      hasErrors = true;
      setErrors((prev) => ({
        ...prev,
        numberOfTravelers: "Liczba osób musi dodatnia.",
      }));
    }
    if (
      !editTripRequest.budget &&
      !(editTripRequest && editTripRequest.budget >= 0)
    ) {
      hasErrors = true;
      setErrors((prev) => ({
        ...prev,
        budget: "Kwota budżetu jest wymagana.",
      }));
    }
    // if (!editTripRequest.categoryProfileId){
    //   hasErrors = true;
    //   setErrors((prev) => ({...prev, categoryProfile: "Profil preferencji jest wymagany."}))
    // }

    // if (!editTripRequest.conditionProfileId){
    //   hasErrors = true;
    //   setErrors((prev) => ({...prev, conditionProfile: "Profil udogodnień jest wymagany."}))
    // }
    if (hasErrors) {
      showSnackbar("Proszę uzupełnić wszystkie wymagane pola!", "error");
      return;
    }

    try {
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
    if (!isNaN(parsedValue) && parsedValue > 0) {
      setNumberOfPeople(parsedValue.toString());
      handleChange("numberOfTravelers")(parsedValue);
    } else {
      setNumberOfPeople("");
      handleChange("numberOfTravelers")(0);
    }
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
              value={destinationName}
              onPress={() => router.push("/trips/add/destination")}
              icon={MARKER_ICON}
              error={!!errors.destinationPlace}
            />
            {errors.destinationPlace && (
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
              error={!!errors.numberOfTravelers}
            />
            {errors.numberOfTravelers && (
              <Text style={styles.textError}>{errors.numberOfTravelers}</Text>
            )}

            <CurrencyValueInput
              budget={editTripRequest.budget}
              currency={editTripRequest.currencyCode}
              handleBudgetChange={handleChange("budget")}
              disable={true}
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
              error={!!errors.categoryProfile}
            />
            {errors.categoryProfile && (
              <Text style={styles.textError}>{errors.categoryProfile}</Text>
            )}

            <ClickableInput
              icon="account"
              label="Profil udogodnień"
              value={getProfileName("Condition", conditionProfileId)}
              onPress={() => {
                setProfileType("Condition");
                setVisible(true);
              }}
              error={!!errors.conditionProfile}
            />
            {errors.conditionProfile && (
              <Text style={styles.textError}>{errors.conditionProfile}</Text>
            )}

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

              if (startDate) {
                if (endDate) {
                  setDateRange({
                    startDate: new Date(startDate),
                    endDate: new Date(endDate),
                  });
                } else {
                  setDateRange({
                    startDate: new Date(startDate),
                    endDate: new Date(startDate),
                  });
                }
              } else {
                console.log("Podany zakres dat jest nieprawidłowy!");
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
