import React, { useState } from "react";
import { Dimensions, StyleSheet, View } from "react-native";
import { Title, List, Switch, Button, Divider, Text } from "react-native-paper";

type RenderListItemProps = {
  title: string;
  rightComponent: () => React.ReactNode;
  onPress: () => void;
};

const windowWidth = Dimensions.get("window").width;

const SettingsView = () => {
  const styles = createStyles();
  const [isSwitchOn, setIsSwitchOn] = useState(false);

  const toggleSwitch = () => setIsSwitchOn((prev) => !prev);

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
    <View style={styles.container}>
      <View style={styles.content}>
        <Title style={styles.title}>Wygląd</Title>
        {renderListItem({
          title: "Czcionka",
          rightComponent: () => <Text style={styles.rightText}>średnia</Text>,
          onPress: () => console.log("Czcionka kliknięta"),
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
    </View>
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
  });

export default SettingsView;
