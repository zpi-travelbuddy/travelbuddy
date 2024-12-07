/* eslint-disable @typescript-eslint/no-explicit-any */
import React, { useCallback, useEffect, useMemo, useState } from "react";
import {
  StyleSheet,
  View,
  Image,
  Dimensions,
  ScrollView,
  FlatList,
} from "react-native";
import { useTheme, MD3Theme, TextInput, Text } from "react-native-paper";
import {
  DatePickerModal,
  registerTranslation,
  pl,
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
import { useSnackbar } from "@/context/SnackbarContext";
import { useLocalSearchParams, useRouter } from "expo-router";
import { useAuth } from "@/app/ctx";
import LoadingView from "./LoadingView";
import { ConditionProfile, Profile, ProfileType } from "@/types/Profile";
import { DateRange, TripErrors, TripRequest } from "@/types/Trip";
import { MARKER_ICON, CALENDAR_ICON } from "@/constants/Icons";
import { API_TRIPS } from "@/constants/Endpoints";
import { validateTripForm } from "@/utils/validations";
import { useAnimatedKeyboard } from "react-native-reanimated";
import {
  useGetCategoryProfiles,
  useGetConditionProfiles,
  useGetFavouriteProfiles,
} from "@/composables/useProfiles";

const { height, width } = Dimensions.get("window");
registerTranslation("pl", pl);

const DEFAULT_CURRENCY = "PLN";

const AddingTripView = () => {
  const { api } = useAuth();

  useAnimatedKeyboard();

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

  const [tripName, setTripName] = useState("");
  const [budget, setBudget] = useState<number>(0);
  const [isOpen, setOpen] = useState(false);
  const [dateRangeText, setDateRangeText] = useState("");
  const [numberOfPeople, setNumberOfPeople] = useState("");
  const [visible, setVisible] = useState(false);

  const [range, setRange] = useState<DateRange>({});
  const [errors, setErrors] = useState<TripErrors>({});

  const [categoryProfileId, setCategoryProfileId] = useState<string | null>(
    null,
  );
  const [conditionProfileId, setConditionProfileId] = useState<string | null>(
    null,
  );

  const [profileType, setProfileType] = useState<ProfileType>("Category");

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

  const handleProfileSelection = useCallback(
    (profile: Profile) => {
      if (profileType === "Category") setCategoryProfileId(profile.id);
      else setConditionProfileId(profile.id);
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
    router.navigate("/trips");
  };

  const handleSubmit = async () => {
    if (!validateForm()) return;

    const tripRequest: TripRequest = {
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
      await api!.post(API_TRIPS, tripRequest);
      router.navigate({ pathname: "/trips", params: { refresh: "true" } });
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
              value={tripName}
              onChangeText={handleChange(setTripName, "tripName")}
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
      <LoadingView show={loading} />
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
