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
import { DatePickerModal } from "react-native-paper-dates";
import {
  formatDateRange,
  registerTranslationForDatePicker,
} from "@/utils/DateUtils";
import CurrencyValueInput from "@/components/CurrencyValueInput";
import CustomModal from "@/components/CustomModal";
import { RenderItem } from "@/components/RenderItem";
import ActionButtons from "@/components/ActionButtons";
import ClickableInput from "@/components/ClickableInput";

const { height, width } = Dimensions.get("window");

registerTranslationForDatePicker();

const editedTrip: Trip = {
  tripName: "Wycieczka do Londynu",
  startDate: new Date("2024-06-10"),
  endDate: new Date("2024-06-15"),
  destination: "London, UK",
  numberOfPeople: 3,
  cost: 4700.0,
  budget: 6000.0,
  currency: {
    name: "Polski złoty",
    id: "PLN",
  },
  preferenceProfileName: "Zwiedzanie i jedzenie",
  convenienceProfileName: "Potrzebuję internetu",
};

const EditTripView = () => {

  interface Profile {
    id: string;
    name: string;
  }

  type ProfileType = "Preference" | "Convenience";

  const theme = useTheme();
  const styles = useMemo(() => createStyles(theme), [theme]);

  const [trip, setTrip] = useState<Trip>(editedTrip);

  const [isOpen, setOpen] = React.useState<boolean>(false);
  const [visible, setVisible] = React.useState(false);

  const [selectedPreferenceProfile, setSelectedPreferencesProfile] =
    useState<Profile>({
      id: "1",
      name: "Profile1",
    });

  const [selectedConvenienceProfile, setSelectedConvenienceProfile] =
    useState<Profile>({
      id: "11",
      name: "Profile11",
    });

  const [preferenceProfiles, setPreferenceProfiles] = useState<Profile[]>([
    { id: "1", name: "Profile1" },
    { id: "2", name: "Profile2" },
  ]);

  const [convenienceProfiles, setConvenienceProfiles] = useState<Profile[]>([
    { id: "11", name: "Profile11" },
    { id: "22", name: "Profile22" },
  ]);

  const renderProfileContent = useCallback(
    (item: { id: string; name: string }) => item.name,
    [],
  );

  const renderPreferenceProfile = ({ item }: { item: Profile }) => (
    <RenderItem
      item={item}
      isSelected={selectedPreferenceProfile.id === item.id}
      onSelect={setSelectedPreferencesProfile}
      renderContent={renderProfileContent}
    />
  );

  const renderConvenienceProfile = ({ item }: { item: Profile }) => (
    <RenderItem
      item={item}
      isSelected={selectedConvenienceProfile.id === item.id}
      onSelect={setSelectedConvenienceProfile}
      renderContent={renderProfileContent}
    />
  );

  const [selectedProfileType, setSelectedProfileType] =
    useState<ProfileType>("Preference");

  const showModal = (type: ProfileType) => {
    setSelectedProfileType(type);
    setVisible(true);
  };

  const hideModal = () => setVisible(false);

  const onDismiss = React.useCallback(() => {
    setOpen(false);
  }, []);

  const onConfirm = React.useCallback(
    ({
      startDate,
      endDate,
    }: {
      startDate: Date | undefined;
      endDate: Date | undefined;
    }) => {
      setOpen(false);
      setRange({ startDate, endDate });
      setDateRangeText(formatDateRange(startDate, endDate));
    },
    [],
  );

  const handleTextChange = (text: string) => {
    const numericText = text.replace(/[^0-9]/g, "");
    setNumberOfPeople(numericText);
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
          value={tripName}
          placeholder={tripName}
          onChangeText={setTripName}
        ></TextInput>

        <ClickableInput
          label="Termin wycieczki"
          value={dateRangeText}
          onPress={() => setOpen(true)}
          icon="calendar"
        />

        <DatePickerModal
          mode="range"
          visible={isOpen}
          onDismiss={onDismiss}
          startDate={range.startDate}
          endDate={range.endDate}
          onConfirm={onConfirm}
          locale="pl"
          validRange={{
            startDate: new Date(),
          }}
        />

        <TextInput
          mode="outlined"
          style={styles.textInput}
          label="Cel wycieczki"
          value={destination}
          placeholder={destination}
          onChangeText={setDestination}
        ></TextInput>

        <TextInput
          mode="outlined"
          style={styles.textInput}
          label="Liczba osób"
          value={numberOfPeople}
          onChangeText={handleTextChange}
          keyboardType="numeric"
        ></TextInput>

        <CurrencyValueInput />

        <ClickableInput
          label="Profil preferencji"
          value={selectedPreferenceProfile.name}
          onPress={() => showModal("Preference")}
        />

        <ClickableInput
          label="Profil udogodnień"
          value={selectedConvenienceProfile.name}
          onPress={() => showModal("Convenience")}
        />

        <CustomModal visible={visible} onDismiss={hideModal}>
          <FlatList
            data={
              selectedProfileType === "Preference"
                ? preferenceProfiles
                : convenienceProfiles
            }
            renderItem={
              selectedProfileType === "Preference"
                ? renderPreferenceProfile
                : renderConvenienceProfile
            }
            keyExtractor={(item) => item.id}
            ItemSeparatorComponent={() => <View />}
            ListEmptyComponent={<Text>Brak dostępnych profili</Text>}
          />
        </CustomModal>
      </View>

      <ActionButtons
        onCancel={() => console.log("Anulowanie")}
        onSave={() => console.log("Zapisywanie")}
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
