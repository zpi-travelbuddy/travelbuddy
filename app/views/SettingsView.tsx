import SettingListItem from "@/components/SettingListItem";
import BottomSheet, { BottomSheetView } from "@gorhom/bottom-sheet";
import React, { useCallback, useMemo, useRef, useState } from "react";
import { Dimensions, StyleSheet, View } from "react-native";
import { GestureHandlerRootView } from "react-native-gesture-handler";
import {
  Title,
  List,
  Switch,
  Button,
  Text,
  RadioButton,
  useTheme,
  MD3Theme,
  PaperProvider,
} from "react-native-paper";

const windowWidth = Dimensions.get("window").width;

const SettingsView = () => {
  const theme = useTheme();
  const styles = createStyles(theme);
  const [isSwitchOn, setIsSwitchOn] = useState(false);

  const sheetRef = useRef<BottomSheet>(null);
  const [isOpen, setIsOpen] = useState(false);

  const snapPoints = useMemo(() => ["30%", "70%", "100%"], []);

  const handleSnapPress = useCallback((index: number) => {
    sheetRef.current?.snapToIndex(index);
    setIsOpen(true);
  }, []);

  const toggleSwitch = () => setIsSwitchOn((prev) => !prev);

  const fontItems = ["mała", "średnia", "duża"];
  const fontTitle = "Wybierz czcionkę";
  const themeItems = ["jasny", "ciemny"];
  const themeTitle = "Wybierz motyw";

  const [bottomSheetTitle, setBottomSheetTitle] = useState(fontTitle);
  const [bottomSheetItems, setBottomSheetItems] = useState(fontItems);

  const [selectedOption, setSelectedOption] = useState<string>("");

  const handleSelect = (item: string) => {
    setSelectedOption(item);
    sheetRef.current?.close();
    setIsOpen(false);
  };

  const openBottomSheet = (title: string, items: string[]) => {
    setBottomSheetTitle(title);
    setBottomSheetItems(items);
    handleSnapPress(1);
    setIsOpen(true);
  };

  return (
    <GestureHandlerRootView style={styles.container}>
      <View style={styles.content}>
        <Title style={styles.title}>Wygląd</Title>
        <SettingListItem
          title="Czcionka"
          rightComponent={() => <Text style={styles.rightText}>średnia</Text>}
          onPress={() => {
            console.log("Czcionka kliknięta");
            openBottomSheet(fontTitle, fontItems);
          }}
        />
        <SettingListItem
          title="Motyw"
          rightComponent={() => <Text style={styles.rightText}>jasny</Text>}
          onPress={() => {
            console.log("Motyw kliknięty");
            openBottomSheet(themeTitle, themeItems);
          }}
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
        onPress={() => console.log("Wylogowanie")}
      >
        Wyloguj się
      </Button>

      <BottomSheet
        ref={sheetRef}
        index={-1}
        snapPoints={snapPoints}
        enablePanDownToClose={true}
        onClose={() => {
          sheetRef.current?.close();
        }}
        backgroundComponent={({ style }) => (
          <View style={[style, styles.bottomSheetContainer]} />
        )}
      >
        <BottomSheetView>
          <View style={styles.titleContainer}>
            <Text style={styles.bottomSheetTitle}>{bottomSheetTitle}</Text>
          </View>
          {bottomSheetItems.map((item, index) => (
            <List.Item
              key={index}
              title={item}
              titleStyle={styles.bottomSheetItemTitle}
              right={() => (
                <RadioButton
                  value={item}
                  status={selectedOption === item ? "checked" : "unchecked"}
                  onPress={() => handleSelect(item)}
                />
              )}
            />
          ))}
        </BottomSheetView>
      </BottomSheet>
    </GestureHandlerRootView>
  );
};

const createStyles = (theme: MD3Theme) =>
  StyleSheet.create({
    container: {
      flex: 1,
      padding: 16,
      paddingTop: 0,
      alignItems: "center",
      justifyContent: "flex-start",
      backgroundColor: theme.colors.background,
    },
    content: {
      flex: 1,
      width: "100%",
    },
    bottomSheetTitle: {
      ...theme.fonts.titleMedium,
    },
    bottomSheetItemTitle: {
      ...theme.fonts.bodyMedium,
    },
    titleContainer: {
      padding: 16,
      justifyContent: "flex-start",
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
    bottomSheetContainer: {
      padding: 30,
      borderTopLeftRadius: 40,
      borderTopRightRadius: 40,
    },
    modalText: {
      marginBottom: 20,
    },
  });

export default SettingsView;
