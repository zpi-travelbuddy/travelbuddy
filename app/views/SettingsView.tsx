import BottomSheet, { BottomSheetView } from "@gorhom/bottom-sheet";
import React, { useCallback, useMemo, useRef, useState } from "react";
import { Dimensions, StyleSheet, View } from "react-native";
import { GestureHandlerRootView } from "react-native-gesture-handler";
import {
  Title,
  List,
  Switch,
  Button,
  Divider,
  Text,
  RadioButton,
} from "react-native-paper";

type RenderListItemProps = {
  title: string;
  rightComponent: () => React.ReactNode;
  onPress: () => void;
};

const windowWidth = Dimensions.get("window").width;

const SettingsView = () => {
  const styles = createStyles();
  const [isSwitchOn, setIsSwitchOn] = useState(false);

  const sheetRef = useRef<BottomSheet>(null);
  const [isOpen, setIsOpen] = useState(false);

  const snapPoints = useMemo(() => ["30%", "70%", "100%"], []);

  const handleSnapPress = useCallback((index: number) => {
    sheetRef.current?.snapToIndex(index);
    setIsOpen(true);
  }, []);

  const toggleSwitch = () => setIsSwitchOn((prev) => !prev);

  const items = ["test1", "test2", "test3"];
  const [selectedOption, setSelectedOption] = useState<string>("");

  const handleSelect = (item: string) => {
    setSelectedOption(item);
    sheetRef.current?.close();
  };

  const renderListItem = ({
    title,
    rightComponent,
    onPress,
  }: RenderListItemProps) => (
    <>
      <List.Item title={title} right={rightComponent} onPress={onPress} />
      <Divider style={styles.divider} />
    </>
  );

  return (
    <GestureHandlerRootView style={styles.container}>
      <View style={styles.content}>
        <Title style={styles.title}>Wygląd</Title>
        {renderListItem({
          title: "Czcionka",
          rightComponent: () => <Text style={styles.rightText}>średnia</Text>,
          onPress: () => {
            console.log("Czcionka kliknięty");
            handleSnapPress(1);
          },
        })}
        {renderListItem({
          title: "Motyw",
          rightComponent: () => <Text style={styles.rightText}>jasny</Text>,
          onPress: () => console.log("Motyw kliknięty"),
        })}
        {renderListItem({
          title: "Wysoki kontrast",
          rightComponent: () => (
            <Switch
              style={styles.switch}
              value={isSwitchOn}
              onValueChange={toggleSwitch}
            />
          ),
          onPress: toggleSwitch,
        })}

        <Title style={styles.title}>Moje Statystyki</Title>
        {renderListItem({
          title: "Oceny atrakcji",
          rightComponent: () => <List.Icon icon="chevron-right" />,
          onPress: () => console.log("Oceny atrakcji kliknięte"),
        })}
        {renderListItem({
          title: "Wydatki",
          rightComponent: () => <List.Icon icon="chevron-right" />,
          onPress: () => console.log("Wydatki kliknięte"),
        })}
        {renderListItem({
          title: "Statystyki wycieczek",
          rightComponent: () => <List.Icon icon="chevron-right" />,
          onPress: () => console.log("Statystyki wycieczek kliknięte"),
        })}

        <Title style={styles.title}>Preferencje i statystyki</Title>
        {renderListItem({
          title: "Profile preferencji",
          rightComponent: () => <List.Icon icon="chevron-right" />,
          onPress: () => console.log("Profile preferencji kliknięte"),
        })}
        {renderListItem({
          title: "Profile udogodnień",
          rightComponent: () => <List.Icon icon="chevron-right" />,
          onPress: () => console.log("Profile udogodnień kliknięte"),
        })}
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
      >
        <BottomSheetView style={styles.bottomSheetContainer}>
          {items.map((item, index) => (
            <List.Item
              key={index}
              title={item}
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

const createStyles = () =>
  StyleSheet.create({
    container: {
      flex: 1,
      padding: 16,
      paddingTop: 0,
      alignItems: "center",
      justifyContent: "flex-start",
    },
    content: {
      flex: 1,
      width: "100%",
    },
    rightText: {
      alignSelf: "center",
    },
    divider: {
      backgroundColor: "#000000",
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
      backgroundColor: "white",
      padding: 20,
      margin: 20,
      borderRadius: 8,
    },
    modalText: {
      marginBottom: 20,
    },
  });

export default SettingsView;
