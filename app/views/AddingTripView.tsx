/* eslint-disable @typescript-eslint/no-explicit-any */
import React, {
  useCallback,
  useEffect,
  useLayoutEffect,
  useMemo,
  useState,
} from "react";
import {
  StyleSheet,
  View,
  Image,
  Dimensions,
  ScrollView,
  FlatList,
  BackHandler,
  TouchableOpacity,
} from "react-native";
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
import { useSnackbar } from "@/context/SnackbarContext";
import { useLocalSearchParams, useNavigation, useRouter } from "expo-router";
import { useAuth } from "@/app/ctx";
import LoadingView from "./LoadingView";
import { Profile, ProfileType } from "@/types/Profile";
import { CreateTripRequest, DateRange, TripErrors } from "@/types/Trip";
import { MARKER_ICON, CALENDAR_ICON } from "@/constants/Icons";
import { API_TRIPS } from "@/constants/Endpoints";
import { onEndEditingString, validateTripForm } from "@/utils/validations";
import { useAnimatedKeyboard } from "react-native-reanimated";
import {
  useGetCategoryProfiles,
  useGetConditionProfiles,
  useGetFavouriteProfiles,
} from "@/composables/useProfiles";
import ActionTextButtons from "@/components/ActionTextButtons";
import ImagePickerPopup from "@/components/ImagePickerPopup";
import { DEFAULT_TRIP_IMAGE, TRIP_IMAGES } from "@/constants/Images";
import useTripImageStorage from "@/hooks/useTripImageStore";
import { useShouldRefresh } from "@/context/ShouldRefreshContext";

const { height, width } = Dimensions.get("window");

const DEFAULT_CURRENCY = "PLN";

const AddingTripView = () => {
  const { api } = useAuth();

  useAnimatedKeyboard();

  const navigation = useNavigation();
  const theme = useTheme();
  const router = useRouter();
  const styles = useMemo(() => createStyles(theme), [theme]);

  const [loading, setLoading] = useState<boolean>(false);
  const currency =
    useLocalSearchParams<{ currency: string }>().currency || DEFAULT_CURRENCY;
  const { destinationId, destinationName } = useLocalSearchParams<{
    destinationId: string;
    destinationName: string;
  }>();

  const { showSnackbar } = useSnackbar();
  const { saveImage } = useTripImageStorage();

  const [tripName, setTripName] = useState("");
  const [budget, setBudget] = useState<number>(0);
  const [isOpen, setOpen] = useState(false);
  const [dateRangeText, setDateRangeText] = useState("");
  const [numberOfPeople, setNumberOfPeople] = useState("");
  const [visible, setVisible] = useState(false);
  const [imagePickerVisible, setImagePickerVisible] = useState(false);
  const [selectedImage, setSelectedImage] = useState<string | null>(null);

  const imageSource = selectedImage
    ? TRIP_IMAGES[selectedImage]
    : DEFAULT_TRIP_IMAGE;

  const [range, setRange] = useState<DateRange>({});
  const [errors, setErrors] = useState<TripErrors>({});

  const { addRefreshScreen } = useShouldRefresh();

  const [categoryProfileId, setCategoryProfileId] = useState<string | null>(
    null,
  );
  const [conditionProfileId, setConditionProfileId] = useState<string | null>(
    null,
  );

  const [profileType, setProfileType] = useState<ProfileType>("Category");

  const [isWarningModalVisible, setIsWarningModalVisible] =
    useState<boolean>(false);

  const {
    profiles: categoryProfiles,
    loading: categoryProfilesLoading,
    error: categoryProfilesError,
    refetch: categoryProfileRefetch,
  } = useGetCategoryProfiles();

  const {
    profiles: conditionProfiles,
    loading: conditionProfilesLoading,
    error: conditionProfilesError,
    refetch: conditionProfileRefetch,
  } = useGetConditionProfiles();

  const {
    favouriteProfiles,
    loading: favouriteProfilesLoading,
    error: favouriteProfilesError,
  } = useGetFavouriteProfiles();

  useLayoutEffect(() => {
    navigation.setOptions({
      onBackPress: () => {
        setIsWarningModalVisible(true);
      },
    });
  }, [navigation]);

  useEffect(() => {
    setCategoryProfileId(favouriteProfiles.Category);
    setConditionProfileId(favouriteProfiles.Condition);
  }, [favouriteProfiles]);

  useEffect(() => {
    setLoading(
      categoryProfilesLoading ||
        conditionProfilesLoading ||
        favouriteProfilesLoading ||
        false,
    );
  }, [
    categoryProfilesLoading,
    conditionProfilesLoading,
    favouriteProfilesLoading,
  ]);

  useEffect(() => {
    setErrors((prev) => ({
      ...prev,
      ["api"]:
        categoryProfilesError ||
        conditionProfilesError ||
        favouriteProfilesError ||
        "",
    }));
  }, [categoryProfilesError, conditionProfilesError, favouriteProfilesError]);

  useEffect(() => {
    const backHandler = BackHandler.addEventListener(
      "hardwareBackPress",
      () => {
        setIsWarningModalVisible(true);
        return true;
      },
    );

    return () => backHandler.remove();
  }, []);

  const handleDismissWarningModal = () => {
    setIsWarningModalVisible(false);
  };

  const goBack = () => {
    setIsWarningModalVisible(false);
    router.back();
  };

  const handleProfileSelection = useCallback(
    (profile: Profile) => {
      if (profileType === "Category") {
        setCategoryProfileId((prevId) =>
          prevId === profile.id ? null : profile.id,
        );
      } else {
        setConditionProfileId((prevId) =>
          prevId === profile.id ? null : profile.id,
        );
      }
    },
    [profileType],
  );

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

  const validateForm = useCallback(() => {
    const validationErrors = validateTripForm(
      tripName,
      range,
      destinationId,
      numberOfPeople,
      budget,
    );

    setErrors(validationErrors);
    return Object.keys(validationErrors).length === 0;
  }, [tripName, range, destinationId, numberOfPeople, budget]);

  const handleCancel = async () => {
    setIsWarningModalVisible(true);
  };

  const handleSubmit = async () => {
    if (!validateForm()) return;

    const tripRequest: Omit<CreateTripRequest, "id"> = {
      name: tripName,
      numberOfTravelers: parseInt(numberOfPeople),
      startDate: formatDateToISO(range.startDate),
      endDate: range.endDate
        ? formatDateToISO(range.endDate)
        : formatDateToISO(range.startDate),
      destinationProviderId: destinationId,
      budget,
      currencyCode: currency,
      categoryProfileId: categoryProfileId ?? null,
      conditionProfileId: conditionProfileId ?? null,
    };
    setLoading(true);
    try {
      const { id } = (await api!.post(API_TRIPS, tripRequest)).data as {
        id: string;
      };
      if (id && selectedImage) {
        await saveImage(id, selectedImage);
      }
      addRefreshScreen("trips");
      router.navigate("/trips");
      showSnackbar("Zapisano wycieczkę!", "success");
    } catch (error: any) {
      console.error(error.response.data);
      showSnackbar("Wystąpił błąd podczas zapisywania wycieczki", "error");
    } finally {
      setLoading(false);
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

  if (loading) {
    <LoadingView transparent={false} />;
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
              value={tripName}
              onChangeText={handleChange(setTripName, "tripName")}
              onEndEditing={() => onEndEditingString(setTripName, tripName)}
              error={!!errors.tripName}
            />
            {errors.tripName && (
              <Text style={styles.textError}>{errors.tripName}</Text>
            )}

            <ClickableInput
              label="Termin wycieczki"
              value={dateRangeText}
              onPress={() => setOpen(true)}
              icon={CALENDAR_ICON}
              error={!!errors.range && !range.startDate}
            />
            {errors.range && !range.startDate && (
              <Text style={styles.textError}>{errors.range}</Text>
            )}

            <ClickableInput
              label="Cel wycieczki"
              value={destinationName}
              onPress={() => router.push("/trips/add/destination")}
              icon={MARKER_ICON}
              error={!!errors.destination && !destinationId}
            />
            {errors.destination && !destinationId && (
              <Text style={styles.textError}>{errors.destination}</Text>
            )}

            <TextInput
              mode="outlined"
              style={styles.textInput}
              label="Liczba osób"
              value={numberOfPeople}
              onChangeText={handleChange(setNumberOfPeople, "numberOfPeople")}
              keyboardType="numeric"
              error={!!errors.numberOfPeople}
            />
            {errors.numberOfPeople && (
              <Text style={styles.textError}>{errors.numberOfPeople}</Text>
            )}

            <CurrencyValueInput
              budget={budget}
              currency={currency}
              handleBudgetChange={handleChange(setBudget, "budget")}
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
            startLabel="Początek"
            endLabel="Koniec"
            mode="range"
            visible={isOpen}
            onDismiss={() => setOpen(false)}
            startDate={range.startDate}
            endDate={range.endDate}
            onConfirm={({ startDate, endDate }) => {
              setOpen(false);
              setRange({ startDate, endDate });
              setDateRangeText(formatDateRange(startDate, endDate));
            }}
            locale="pl"
            validRange={{ startDate: getISOToday() }}
            startWeekOnMonday
          />
        </View>

        <ActionButtons
          onAction1={handleCancel}
          onAction2={handleSubmit}
          action1ButtonLabel="Anuluj"
          action2ButtonLabel="Zapisz"
          action1Icon={undefined}
          action2Icon={undefined}
        />
      </ScrollView>

      <CustomModal
        visible={isWarningModalVisible}
        onDismiss={handleDismissWarningModal}
      >
        <Text style={styles.modalTitleText}>
          Czy na pewno chcesz opuścić tworzenie wycieczki?
        </Text>
        <ActionTextButtons
          onAction1={handleDismissWarningModal}
          onAction2={goBack}
          action1ButtonLabel="Nie"
          action2ButtonLabel="Tak"
          action1Icon={undefined}
          action2Icon={undefined}
        />
      </CustomModal>
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

export default AddingTripView;

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
    modalTitleText: {
      ...theme.fonts.titleLarge,
      color: theme.colors.onSurface,
    },
  });
