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
import { TripRequest, TripResponse, TripErrors } from "@/types/Trip";
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
import { convertTripResponseToTripRequest } from "@/converters/tripConverters";
import { Place } from "@/types/Place";
import { getDisplayPlace } from "@/utils/TextUtils";

const { height, width } = Dimensions.get("window");

interface Profile {
  id: string;
  name: string;
}

type ProfileType = "Category" | "Condition";

registerTranslation("pl", pl);

const EditTripView = () => {
  const theme = useTheme();
  const styles = useMemo(() => createStyles(theme), [theme]);
  const router = useRouter();
  const { showSnackbar } = useSnackbar();
  const params = useLocalSearchParams();
  const { trip_id } = params;

  const [error, setError] = useState<string | null>(null);
  const [loading, setLoading] = useState<boolean>(false);
  const [tripRequest, setTripRequest] = useState<TripRequest>(
    {} as TripRequest,
  );

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
  } = useEditTripDetails(tripRequest, { immediate: false });

  // const {
  //   profiles: categoryProfiles,
  //   loading: categoryProfilesLoading,
  //   error: categoryProfilesError,
  // } = useGetCategoryProfiles();

  // const {
  //   profiles: conditionProfiles,
  //   loading: conditionProfilesLoading,
  //   error: conditionProfilesError,
  // } = useGetConditionProfiles();

  useEffect(() => {
    setError(tripError || destinationError || "");
  }, [tripError, destinationError, editError]);

  useEffect(() => {
    setLoading(tripLoading || destinationLoading || editTripLoading || false);
  }, [tripLoading, destinationLoading, editTripLoading]);

  const [errors, setErrors] = useState<TripErrors>({});
  const [numberOfPeople, setNumberOfPeople] = useState<string>("");

  useEffect(() => {
    console.log(JSON.stringify(tripDetails));
    console.log(JSON.stringify(destinationDetails));
    if (tripDetails && destinationDetails) {
      setTripRequest(
        convertTripResponseToTripRequest(
          tripDetails,
          destinationDetails as Place,
        ),
      );
      setNumberOfPeople(tripDetails.numberOfTravelers.toString());
      setDateRange({
        startDate: new Date(tripDetails.startDate),
        endDate: new Date(tripDetails.endDate),
      });
      // setCategoryProfileId(tripDetails.categoryProfileId);
      // setConditionProfileId(tripDetails.conditionProfileId);
      setCategoryProfileId("null");
      setConditionProfileId("null");
    }
  }, [tripDetails, destinationDetails]);

  // const setSelectedProfileById = (id: string, profiles: Profile[], setter) => {
  //   const profile = profiles.find((p) => p.id === id);
  //   if (profile) {
  //     setter(profile);
  //   } else {
  //     console.error("Profile with the given ID not found");
  //     selectedProfile = null; // Wyczyść profil, jeśli ID nie pasuje
  //   }
  // }

  const [dateRange, setDateRange] = useState<{
    startDate: Date;
    endDate: Date;
  }>({
    startDate: new Date(),
    endDate: new Date(),
  });

  useEffect(() => {
    console.log(JSON.stringify(tripRequest));
  }, [tripRequest]);

  const [dateRangeText, setDateRangeText] = useState<string>(
    formatDateRange(dateRange.startDate, dateRange.endDate),
  );

  useEffect(() => {
    setDateRangeText(formatDateRange(dateRange.startDate, dateRange.endDate));
  }, [dateRange]);

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
    { id: "null", name: "Zwiedzanie i jedzenie" },
  ]);

  const [conditionProfiles, setConditionProfiles] = useState<Profile[]>([
    { id: "11", name: "Profile11" },
    { id: "null", name: "Potrzebuję internetu dla psa" },
  ]);

  // const renderProfileContent = useCallback(
  //   (item: { id: string; name: string }) => item.name,
  //   [],
  // );

  const handleProfileSelection = useCallback(
    (profile: Profile) => {
      if (profileType === "Category") setCategoryProfileId(profile.id);
      else setConditionProfileId(profile.id);
    },
    [profileType],
  );

  useEffect(() => {
    if (editSuccess !== null) {
      if (editSuccess) showSnackbar("Wycieczka została zapisana!", "success");
      else showSnackbar("Błąd przy zapisie wycieczki", "error");
    }
  }, [editSuccess]);

  useEffect(() => {
    console.log(editError);
  }, [editError]);

  // const renderCategoryProfile = ({ item }: { item: Profile }) => (
  //   <RenderItem
  //     item={item}
  //     isSelected={selectedCategoryProfile.id === item.id}
  //     onSelect={() => {
  //       setSelectedCategoryProfile(item);
  //       setTrip((prevTrip: TripDetails) => ({
  //         ...prevTrip,
  //         categoryProfileId: item.id,
  //       }));
  //     }}
  //     renderContent={renderProfileContent}
  //   />
  // );

  // const renderConditionProfile = ({ item }: { item: Profile }) => (
  //   <RenderItem
  //     item={item}
  //     isSelected={selectedConditionProfile.id === item.id}
  //     onSelect={() => {
  //       setSelectedCategoryProfile(item);
  //       setTrip((prevTrip: TripDetails) => ({
  //         ...prevTrip,
  //         conditionProfileId: item.id,
  //       }));
  //     }}
  //     renderContent={renderProfileContent}
  //   />
  // );

  // const showModal = (type: ProfileType) => {
  //   setProfileType(type);
  //   setVisible(true);
  // };

  // const hideModal = () => setVisible(false);

  // const onDismiss = React.useCallback(() => {
  //   setOpen(false);
  // }, []);

  // const onConfirm = useCallback(
  //   ({
  //     startDate,
  //     endDate,
  //   }: {
  //     startDate: Date | undefined;
  //     endDate: Date | undefined;
  //   }) => {
  //     setOpen(false);
  //     if (startDate && endDate) {
  //       setDateRange({ startDate, endDate });
  //       setDateRangeText(formatDateRange(startDate, endDate));
  //       setTrip((prevTrip: TripDetails) => ({
  //         ...prevTrip,
  //         startDate: formatToISODate(startDate),
  //         endDate: formatToISODate(endDate),
  //       }));
  //     }
  //   },
  //   [],
  // );

  const saveTrip = async () => {
    try {
      setTripRequest((prev) => ({
        ...prev,
        startDate: formatDateToISO(dateRange.startDate),
        endDate: formatDateToISO(dateRange.endDate),
        categoryProfileId: categoryProfileId,
        conditionProfileId: conditionProfileId,
      }));
      if (
        !tripRequest.id ||
        !tripRequest.name ||
        !tripRequest.destinationPlace.providerId ||
        !tripRequest.startDate ||
        !tripRequest.endDate ||
        !tripRequest.numberOfTravelers ||
        !tripRequest.budget ||
        !tripRequest.categoryProfileId ||
        !tripRequest.conditionProfileId ||
        !tripRequest.currencyCode
      ) {
        console.log("Trip request: " + JSON.stringify(tripRequest));
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
      setTripRequest((prev) => ({ ...prev, [field]: value }));
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
              value={tripRequest.name}
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
              value={getDisplayPlace(tripRequest?.destinationPlace)}
              onPress={() => router.push("/trips/add/destination")}
              icon={MARKER_ICON}
              error={!!errors.destination && !tripRequest?.destinationPlace?.id}
            />
            {errors.destination && (
              <Text style={styles.textError}>{errors.destination}</Text>
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
              budget={tripRequest.budget}
              currency={tripRequest.currencyCode}
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
