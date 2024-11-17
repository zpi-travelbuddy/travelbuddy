import {
  StyleSheet,
  View,
  Image,
  Dimensions,
  ScrollView,
  FlatList,
} from "react-native";
import React, { useCallback, useMemo, useState } from "react";
import { useTheme, MD3Theme, TextInput, Text } from "react-native-paper";
import {
  DatePickerModal,
  pl,
  registerTranslation,
} from "react-native-paper-dates";
import { formatDateRange, formatToISODate } from "@/utils/TimeUtils";
import CurrencyValueInput from "@/components/CurrencyValueInput";
import CustomModal from "@/components/CustomModal";
import { RenderItem } from "@/components/RenderItem";
import ActionButtons from "@/components/ActionButtons";
import ClickableInput from "@/components/ClickableInput";
import { TripDay, TripDetails } from "@/types/Trip";

const { height, width } = Dimensions.get("window");

registerTranslation("pl", pl);

const editedTrip: TripDetails = {
  id: "77b6b9bd-99d8-4b56-b74d-ed69c3a1238a",
  name: "Wycieczka do Londynu",
  numberOfTravelers: 3,
  startDate: "2025-11-10",
  endDate: "2025-11-15",
  destinationId: "eb2a3de6-8998-4a3c-992c-9e4fd76ef027",
  budget: 6000,
  currencyCode: "USD",
  categoryProfileId: "null",
  conditionProfileId: "null",
  tripDays: [] as TripDay[],
};

const EditTripView = () => {
  interface Profile {
    id: string;
    name: string;
  }

  type ProfileType = "Category" | "Condition";

  const theme = useTheme();
  const styles = useMemo(() => createStyles(theme), [theme]);

  const [trip, setTrip] = useState<TripDetails>(editedTrip);

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
  const [selectedProfileType, setSelectedProfileType] =
    useState<ProfileType>("Category");

  const showModal = (type: ProfileType) => {
    setSelectedProfileType(type);
    setVisible(true);
  };

  const hideModal = () => setVisible(false);

  const onDismiss = useCallback(() => {
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

  const onSaveTrip = () => {
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
      console.log("Brak wymaganych danych!");
      return;
    }

    console.log("Zapisany obiekt wycieczki:", trip);
  };

  const handleTextChange = (text: string) => {
    const numericText = text.replace(/[^0-9]/g, "");

    setTrip((prevTrip) => ({
      ...prevTrip,
      numberOfTravelers: parseInt(numericText) || 0,
    }));
  };
  return (
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
          value={trip.name}
          placeholder="Wprowadź nazwę wycieczki"
          onChangeText={(text) =>
            setTrip((prevTrip) => ({ ...prevTrip, name: text }))
          }
        />

        <ClickableInput
          label="Termin wycieczki"
          value={formatDateRange(
            new Date(trip.startDate),
            new Date(trip.endDate),
          )}
          onPress={() => setOpen(true)}
          icon="calendar"
        />

        <DatePickerModal
          mode="range"
          visible={isOpen}
          onDismiss={onDismiss}
          startDate={new Date(trip.startDate)}
          endDate={new Date(trip.endDate)}
          onConfirm={onConfirm}
          locale="pl"
        />

        <TextInput
          mode="outlined"
          style={styles.textInput}
          label="Cel wycieczki"
          value={trip.destinationId}
          placeholder="Podaj miejsce wycieczki"
          onChangeText={(text) =>
            setTrip((prevTrip) => ({ ...prevTrip, destination: text }))
          }
        />

        <TextInput
          mode="outlined"
          style={styles.textInput}
          label="Liczba osób"
          value={trip.numberOfTravelers.toString()}
          onChangeText={handleTextChange}
          keyboardType="numeric"
        />

        <CurrencyValueInput />

        <ClickableInput
          label="Profil preferencji"
          value={selectedCategoryProfile.name}
          onPress={() => showModal("Category")}
        />

        <ClickableInput
          label="Profil udogodnień"
          value={selectedConditionProfile.name}
          onPress={() => showModal("Condition")}
        />

        <CustomModal visible={visible} onDismiss={hideModal}>
          <FlatList
            data={
              selectedProfileType === "Category"
                ? categoryProfiles
                : conditionProfiles
            }
            renderItem={
              selectedProfileType === "Category"
                ? renderCategoryProfile
                : renderConditionProfile
            }
            keyExtractor={(item) => item.id}
            ItemSeparatorComponent={() => <View />}
            ListEmptyComponent={<Text>Brak dostępnych profili</Text>}
          />
        </CustomModal>
      </View>

      <ActionButtons
        onAction1={() => console.log("Anulowanie")}
        onAction2={onSaveTrip}
        action1ButtonLabel="Anuluj"
        action2ButtonLabel="Zapisz"
        action1Icon={undefined}
        action2Icon={undefined}
      />
    </ScrollView>
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
  });
