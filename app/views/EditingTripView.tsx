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
  formatToISODate,
  getISOToday,
} from "@/utils/TimeUtils";
import CurrencyValueInput from "@/components/CurrencyValueInput";
import CustomModal from "@/components/CustomModal";
import { RenderItem } from "@/components/RenderItem";
import ActionButtons from "@/components/ActionButtons";
import ClickableInput from "@/components/ClickableInput";
import { TripDetails, TripErrors } from "@/types/Trip";
import { useLocalSearchParams, useRouter } from "expo-router";
import useTripDetails, {
  useEditTripDetails,
} from "@/composables/useTripDetails";
import { useSnackbar } from "@/context/SnackbarContext";
import LoadingView from "./LoadingView";
import { API_TRIPS } from "@/constants/Endpoints";
import { CALENDAR_ICON, MARKER_ICON } from "@/constants/Icons";

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

  const { tripDetails, tripSummary, loading, error, refetch } = useTripDetails(
    trip_id as string,
  );

  const [trip, setTrip] = useState<TripDetails>({} as TripDetails);
  const [errors, setErrors] = useState<TripErrors>({});
  const [numberOfPeople, setNumberOfPeople] = useState<string>("");

  useEffect(() => {
    if (tripDetails) {
      setTrip(tripDetails);
      setNumberOfPeople(tripDetails.numberOfTravelers.toString());
    }
  }, [tripDetails]);

  const [dateRange, setDateRange] = useState<{
    startDate: Date;
    endDate: Date;
  }>({
    startDate: new Date(trip.startDate),
    endDate: new Date(trip.endDate),
  });

  const [dateRangeText, setDateRangeText] = useState<string>(
    formatDateRange(dateRange.startDate, dateRange.endDate),
  );

  const [isOpen, setOpen] = useState<boolean>(false);
  const [visible, setVisible] = useState<boolean>(false);

  const [selectedCategoryProfile, setSelectedCategoryProfile] =
    useState<Profile>({ id: "null", name: "Zwiedzanie i jedzenie" });

  const [selectedConditionProfile, setSelectedConditionProfile] =
    useState<Profile>({ id: "null", name: "Potrzebuję internetu dla psa" });

  const [profileType, setProfileType] = useState<ProfileType>("Category");

  const [categoryProfiles, setCategoryProfiles] = useState<Profile[]>([
    { id: "1", name: "Profile1" },
    { id: "null", name: "Zwiedzanie i jedzenie" },
  ]);

  const [conditionProfiles, setConditionProfiles] = useState<Profile[]>([
    { id: "11", name: "Profile11" },
    { id: "null", name: "Potrzebuję internetu dla psa" },
  ]);

  const renderProfileContent = useCallback(
    (item: { id: string; name: string }) => item.name,
    [],
  );

  const handleProfileSelection = useCallback(
    (profile: Profile) => {
      if (profileType === "Category") setSelectedCategoryProfile(profile);
      else setSelectedConditionProfile(profile);
    },
    [profileType],
  );

  const renderCategoryProfile = ({ item }: { item: Profile }) => (
    <RenderItem
      item={item}
      isSelected={selectedCategoryProfile.id === item.id}
      onSelect={() => {
        setSelectedCategoryProfile(item);
        setTrip((prevTrip: TripDetails) => ({
          ...prevTrip,
          categoryProfileId: item.id,
        }));
      }}
      renderContent={renderProfileContent}
    />
  );

  const renderConditionProfile = ({ item }: { item: Profile }) => (
    <RenderItem
      item={item}
      isSelected={selectedConditionProfile.id === item.id}
      onSelect={() => {
        setSelectedCategoryProfile(item);
        setTrip((prevTrip: TripDetails) => ({
          ...prevTrip,
          conditionProfileId: item.id,
        }));
      }}
      renderContent={renderProfileContent}
    />
  );

  const showModal = (type: ProfileType) => {
    setProfileType(type);
    setVisible(true);
  };

  const hideModal = () => setVisible(false);

  const onDismiss = React.useCallback(() => {
    setOpen(false);
  }, []);

  const onConfirm = useCallback(
    ({
      startDate,
      endDate,
    }: {
      startDate: Date | undefined;
      endDate: Date | undefined;
    }) => {
      setOpen(false);
      if (startDate && endDate) {
        setDateRange({ startDate, endDate });
        setDateRangeText(formatDateRange(startDate, endDate));
        setTrip((prevTrip: TripDetails) => ({
          ...prevTrip,
          startDate: formatToISODate(startDate),
          endDate: formatToISODate(endDate),
        }));
      }
    },
    [],
  );

  const saveTrip = async () => {
    try {
      if (
        !trip.id ||
        !trip.name ||
        !trip.destinationId ||
        !trip.startDate ||
        !trip.endDate ||
        !trip.numberOfTravelers ||
        !trip.budget ||
        !trip.categoryProfileId ||
        !trip.conditionProfileId ||
        !trip.currencyCode
      ) {
        showSnackbar("Proszę uzupełnić wszystkie wymagane pola!", "error");
        return;
      }
      const response = await useEditTripDetails(trip);

      if (response.status === 202) {
        showSnackbar("Wycieczka została zapisana!", "success");
        router.back();
      } else {
        throw new Error();
      }
    } catch (error) {
      showSnackbar("Błąd podczas zapisywania wycieczki!", "error");
      console.error(error);
    }
  };

  const handleChange = (field: keyof TripErrors = "", clearError = true) => {
    return (value: any) => {
      setTrip((prev) => ({ ...prev, [field]: value }));
      if (clearError && field) setErrors((prev) => ({ ...prev, [field]: "" }));
    };
  };

  const handleNumericChange = (
    field: keyof TripErrors = "",
    clearError = true,
  ) => {
    return (value: any) => {
      const numericValue = value.replace(/[^0-9]/g, "");
      let convertedNumber = Number(numericValue);
      if (isNaN(convertedNumber)) convertedNumber = 0;
      setTrip((prev) => ({ ...prev, [field]: convertedNumber }));
      if (clearError && field) setErrors((prev) => ({ ...prev, [field]: "" }));
    };
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
              value={trip.name}
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
              value={trip.destinationId}
              onPress={() => router.push("/trips/add/destination")}
              icon={MARKER_ICON}
              error={!!errors.destination && !trip.destinationId}
            />
            {errors.destination && !trip.destinationId && (
              <Text style={styles.textError}>{errors.destination}</Text>
            )}

            <TextInput
              mode="outlined"
              style={styles.textInput}
              label="Liczba osób"
              value={numberOfPeople}
              onChangeText={handleNumericChange("numberOfPeople")}
              keyboardType="numeric"
              error={!!errors.numberOfPeople}
            />
            {errors.numberOfPeople && (
              <Text style={styles.textError}>{errors.numberOfPeople}</Text>
            )}

            <CurrencyValueInput
              budget={trip.budget}
              currency={trip.currencyCode}
              handleBudgetChange={handleNumericChange("budget")}
              error={!!errors.budget}
            />
            {errors.budget && (
              <Text style={styles.textError}>{errors.budget}</Text>
            )}

            <ClickableInput
              label="Profil preferencji"
              value={selectedCategoryProfile?.name || "Brak"}
              onPress={() => {
                setProfileType("Category");
                setVisible(true);
              }}
            />
            <ClickableInput
              label="Profil udogodnień"
              value={selectedConditionProfile?.name || "Brak"}
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
                        ? selectedCategoryProfile
                        : selectedConditionProfile
                      )?.id === item.id
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
                setDateRangeText(
                  formatDateRange(new Date(startDate), new Date(endDate)),
                );
              } else {
                console.log("startDate lub endDate jest undefined");
              }
            }}
            locale="pl"
            validRange={{ startDate: getISOToday() }}
            startWeekOnMonday
          />
        </View>

        <ActionButtons
          onAction1={() => router.back()}
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
