import React, { useState } from "react";
import { Dimensions, ScrollView, View } from "react-native";
import SettingListItem from "@/components/SettingListItem";
import SettingsBottomSheet from "@/components/SettingsBottomSheet";
import { StyleSheet } from "react-native";
import {
  List,
  MD3Theme,
  Text,
  Title,
  useTheme,
  Button,
  Switch,
} from "react-native-paper";
import { GestureHandlerRootView } from "react-native-gesture-handler";
import { useAuth } from "@/app/ctx";
import { router } from "expo-router";
import CustomModal from "@/components/CustomModal";
import ActionTextButtons from "@/components/ActionTextButtons";

type ModalOption = "FONT" | "THEME";

const windowWidth = Dimensions.get("window").width;

const SettingsView = () => {
  const { signOut } = useAuth();

  const theme = useTheme();
  const styles = createStyles(theme);

  const [isSwitchOn, setIsSwitchOn] = useState(false);

  const [selectedFont, setSelectedFont] = useState("small");
  const [selectedTheme, setSelectedTheme] = useState("dark");

  const [isSheetVisible, setIsSheetVisible] = useState(false);
  const [isLogoutModalVisible, setIsLogoutModalVisible] = useState(false);
  const [bottomSheetTitle, setBottomSheetTitle] = useState("");
  const [bottomSheetItems, setBottomSheetItems] = useState<
    Record<string, string>
  >({});
  const [selectedOptionToModal, setSelectedOptionToModal] =
    useState<ModalOption>("FONT");

  const [selectedOption, setSelectedOption] = useState("");

  const fontItems: Record<string, string> = {
    small: "mała",
    medium: "średnia",
    large: "duża",
  };
  const themeItems: Record<string, string> = { light: "jasny", dark: "ciemny" };

  const openBottomSheet = (
    title: string,
    items: Record<string, string>,
    option: ModalOption,
    selectedItem: string,
  ) => {
    setBottomSheetTitle(title);
    setBottomSheetItems(items);
    setSelectedOptionToModal(option);
    setSelectedOption(selectedItem);
    setIsSheetVisible(true);
  };

  const toggleSwitch = () => setIsSwitchOn((prev) => !prev);

  const handleSelect = (option: string) => {
    switch (selectedOptionToModal) {
      case "FONT":
        setSelectedFont(option);
        break;
      case "THEME":
        setSelectedTheme(option);
        break;
      default:
        break;
    }
    setIsSheetVisible(false);
  };

  const handleLogoutButton = async () => {
    setIsLogoutModalVisible(true);
  };

  const logout = async () => {
    try {
      await signOut!();
      router.navigate("/");
    } catch (error) {
      console.error("Error while logging out", error);
    }
  };

  const handleDismissLogoutModal = () => setIsLogoutModalVisible(false);

  return (
    <GestureHandlerRootView style={styles.container}>
      <ScrollView contentContainerStyle={styles.scrollView}>
        <View style={styles.content}>
          <SettingListItem
            title="Czcionka"
            rightComponent={() => (
              <Text style={styles.rightText}>{fontItems[selectedFont]}</Text>
            )}
            onPress={() =>
              openBottomSheet(
                "Wybierz czcionkę",
                fontItems,
                "FONT",
                selectedFont,
              )
            }
          />
          <SettingListItem
            title="Motyw"
            rightComponent={() => (
              <Text style={styles.rightText}>{themeItems[selectedTheme]}</Text>
            )}
            onPress={() =>
              openBottomSheet(
                "Wybierz motyw",
                themeItems,
                "THEME",
                selectedTheme,
              )
            }
          />
          <SettingListItem
            title="Wysoki kontrast"
            rightComponent={() => (
              <Switch
                style={styles.switch}
                value={isSwitchOn}
                onValueChange={toggleSwitch}
              />
            )}
            onPress={() => {
              console.log("Wysoki kontrast kliknięty");
              setIsSwitchOn(!isSwitchOn);
            }}
          />

          <Title style={styles.title}>Moje Statystyki</Title>
          <SettingListItem
            title="Oceny atrakcji"
            rightComponent={() => <List.Icon icon="chevron-right" />}
            onPress={() => {
              console.log("Oceny atrakcji kliknięte");
            }}
          />
          <SettingListItem
            title="Wydatki"
            rightComponent={() => <List.Icon icon="chevron-right" />}
            onPress={() => {
              console.log("Wydatki kliknięte");
            }}
          />
          <SettingListItem
            title="Statystyki wycieczek"
            rightComponent={() => <List.Icon icon="chevron-right" />}
            onPress={() => {
              console.log("Statystyki wycieczek kliknięte");
            }}
          />

          <Title style={styles.title}>Preferencje i statystyki</Title>
          <SettingListItem
            title="Profile preferencji"
            rightComponent={() => <List.Icon icon="chevron-right" />}
            onPress={() => {
              console.log("Profile preferencji kliknięte");
            }}
          />
          <SettingListItem
            title="Profile udogodnień"
            rightComponent={() => <List.Icon icon="chevron-right" />}
            onPress={() => {
              console.log("Profile udogodnień kliknięte");
            }}
          />
        </View>

        <Button
          mode="contained"
          style={styles.logOutButton}
          icon="logout"
          onPress={handleLogoutButton}
        >
          Wyloguj się
        </Button>
      </ScrollView>

      <SettingsBottomSheet
        title={bottomSheetTitle}
        items={bottomSheetItems}
        selectedItem={selectedOption}
        isVisible={isSheetVisible}
        onSelect={handleSelect}
        onClose={() => setIsSheetVisible(false)}
      />

      <CustomModal
        visible={isLogoutModalVisible}
        onDismiss={handleDismissLogoutModal}
      >
        <Text style={styles.modalTitleText}>
          Czy na pewno chcesz się wylogować?
        </Text>
        <ActionTextButtons
          onCancel={handleDismissLogoutModal}
          onConfirm={logout}
          cancelButtonLabel="Nie"
          confirmButtonLabel="Tak"
          confirmIcon={undefined}
          cancelIcon={undefined}
        />
      </CustomModal>
    </GestureHandlerRootView>
  );
};

const createStyles = (theme: MD3Theme) =>
  StyleSheet.create({
    container: {
      flex: 1,
      padding: 16,
      paddingTop: 0,
      justifyContent: "flex-start",
      backgroundColor: theme.colors.surface,
    },
    content: {
      flex: 1,
      width: "100%",
    },
    scrollView: {
      alignItems: "center",
    },
    rightText: {
      alignSelf: "center",
    },
    switch: { marginRight: -10 },
    logOutButton: {
      marginVertical: 30,
      width: windowWidth * 0.5,
      alignContent: "center",
    },
    title: {
      width: "100%",
      marginTop: 20,
    },
    modalTitleText: {
      ...theme.fonts.titleLarge,
      color: theme.colors.onBackground,
    },
  });

export default SettingsView;
