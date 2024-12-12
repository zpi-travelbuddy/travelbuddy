/* eslint-disable @typescript-eslint/no-explicit-any */
import {
  StyleSheet,
  View,
  Image,
  Dimensions,
  ScrollView,
  FlatList,
  TouchableOpacity,
} from "react-native";
import { useCallback, useEffect, useMemo, useState } from "react";
import { useTheme, MD3Theme, TextInput, Text } from "react-native-paper";
import { DatePickerModal } from "react-native-paper-dates";
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
import {
  useTripDetails,
  useEditTripDetails,
} from "@/composables/useTripDetails";
import { useSnackbar } from "@/context/SnackbarContext";
import LoadingView from "./LoadingView";
import { CALENDAR_ICON, MARKER_ICON } from "@/constants/Icons";
import usePlaceDetails from "@/composables/usePlace";
import { convertTripResponseToTripRequest } from "@/converters/tripConverters";
import { Place } from "@/types/Place";
import { getDisplayPlace } from "@/utils/TextUtils";
import { Profile, ProfileType } from "@/types/Profile";
import { useDynamicProfiles } from "@/composables/useProfiles";

import { onEndEditingStringOnObject } from "@/utils/validations";
import { DEFAULT_TRIP_IMAGE, TRIP_IMAGES } from "@/constants/Images";
import useTripImageStorage from "@/hooks/useTripImageStore";
import ImagePickerPopup from "@/components/ImagePickerPopup";
import { useShouldRefresh } from "@/context/ShouldRefreshContext";

const { height, width } = Dimensions.get("window");

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

  const { saveImage } = useTripImageStorage();

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
  const [profilesErrors, setProfilesErrors] = useState<string>("");
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

  const { addRefreshScreen } = useShouldRefresh();

  const [isOpen, setOpen] = useState<boolean>(false);
  const [visible, setVisible] = useState<boolean>(false);
  const [imagePickerVisible, setImagePickerVisible] = useState(false);
  const [selectedImage, setSelectedImage] = useState<string | null>(null);

  const imageSource = selectedImage
    ? TRIP_IMAGES[selectedImage]
    : DEFAULT_TRIP_IMAGE;

  const [categoryProfileId, setCategoryProfileId] = useState<string | null>(
    null,
  );
  const [conditionProfileId, setConditionProfileId] = useState<string | null>(
    null,
  );
  const { getImageName } = useTripImageStorage();

  const [profileType, setProfileType] = useState<ProfileType>("Category");

  useEffect(() => {
    const fetchImageName = async () => {
      const storedImageName = await getImageName(trip_id as string);
      if (storedImageName) {
        setSelectedImage(storedImageName);
      }
    };

    fetchImageName();
  }, [trip_id, getImageName]);

  const {
    profiles: categoryProfiles,
    loading: categoryProfilesLoading,
    error: categoryProfilesError,
  } = useDynamicProfiles("Category");

  const {
    profiles: conditionProfiles,
    loading: conditionProfilesLoading,
    error: conditionProfilesError,
  } = useDynamicProfiles("Condition");

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
    }
  }, [destinationDetails, new_destination_id]);

  useEffect(() => {
    setError(tripError || destinationError || editError || "");
  }, [tripError, destinationError, editError]);

  useEffect(() => {
    setProfilesErrors(categoryProfilesError || conditionProfilesError || "");
  }, [categoryProfilesError, conditionProfilesError]);

  useEffect(() => {
    setLoading(
      tripLoading ||
        destinationLoading ||
        editTripLoading ||
        categoryProfilesLoading ||
        conditionProfilesLoading ||
        false,
    );
  }, [
    tripLoading,
    destinationLoading,
    editTripLoading,
    categoryProfilesLoading,
    conditionProfilesLoading,
  ]);

  useEffect(() => {
    if (tripDetails && destinationDetails) {
      setEditTripRequest(
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
      setCategoryProfileId(tripDetails?.categoryProfileId || null);
      setConditionProfileId(tripDetails?.conditionProfileId || null);
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
    if (editSuccess !== null) {
      if (editSuccess) {
        showSnackbar("Wycieczka została zapisana!", "success");
        addRefreshScreen("trips");
        addRefreshScreen("trip-details");
        router.back();
      } else showSnackbar("Błąd przy zapisie wycieczki", "error");
    }
  }, [editSuccess]);

  useEffect(() => {
    if (profilesErrors) showSnackbar(profilesErrors, "error");
  }, [profilesErrors]);

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

    if (hasErrors) {
      showSnackbar("Proszę uzupełnić wszystkie wymagane pola!", "error");
      return;
    }

    try {
      await editTrip();
      if (trip_id && selectedImage) {
        await saveImage(trip_id as string, selectedImage);
      }
    } catch (error) {
      showSnackbar("Błąd przy zapisie wycieczki", "error");
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
      let profiles = [] as Profile[];
      if (profileType === "Category") profiles = categoryProfiles;
      else if (profileType === "Condition") profiles = conditionProfiles;
      else throw new Error("Unknow profile type: " + profileType);
      const profile = profiles.find((p) => p.id === id);
      return profile ? profile.name : "Brak";
    } else return "Brak";
  };

  const handleProfileSelection = useCallback(
    (profile: Profile) => {
      if (profileType === "Category") {
        setCategoryProfileId((prevId) => {
          const newId = prevId === profile.id ? null : profile.id;
          handleChange("categoryProfileId")(newId);
          return newId;
        });
      } else {
        setConditionProfileId((prevId) => {
          const newId = prevId === profile.id ? null : profile.id;
          handleChange("conditionProfileId")(newId);
          return newId;
        });
      }
    },
    [profileType],
  );

  // =====================
  // SECTION: Return JSX (UI rendering)
  // =====================

  if (loading) {
    return <LoadingView transparent={false} />;
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
          <TouchableOpacity
            style={styles.touchable}
            onPress={() => setImagePickerVisible(true)}
          >
            <Image
              source={imageSource}
              style={styles.image}
              resizeMode="cover"
            />
          </TouchableOpacity>
          <View style={styles.form}>
            <TextInput
              mode="outlined"
              style={styles.textInput}
              label="Nazwa"
              value={editTripRequest.name}
              onChangeText={handleChange("name")}
              onEndEditing={() =>
                onEndEditingStringOnObject(setEditTripRequest, "name")
              }
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
              error={!!errors.budget}
              currencyDisable={true}
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
                    ? categoryProfiles.sort((a, b) =>
                        a.name.localeCompare(b.name),
                      )
                    : conditionProfiles.sort((a, b) =>
                        a.name.localeCompare(b.name),
                      )
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
      <ImagePickerPopup
        images={TRIP_IMAGES}
        visible={imagePickerVisible}
        onClose={() => {
          setImagePickerVisible(false);
        }}
        onSave={(image: string) => {
          setSelectedImage(image);
        }}
      />
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
    touchable: {
      width: "100%",
    },
    form: {
      flex: 1,
      gap: 10,
      alignItems: "center",
      width: width,
    },
    image: { marginVertical: 25, width: "100%", height: height * 0.25 },
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
