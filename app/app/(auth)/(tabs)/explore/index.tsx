import { useEffect, useState } from "react";
import { View, StyleSheet } from "react-native";
import { Text, useTheme } from "react-native-paper";
import { Searchbar } from "react-native-paper";
import { MD3ThemeExtended } from "@/constants/Themes";

export default function Explore() {
  const [searchQuery, setSearchQuery] = useState("");
  const [places, setPlaces] = useState([]);

  const theme = useTheme() as MD3ThemeExtended;
  const styles = makeStyles(theme);

  return (
    <View style={styles.container}>
      <Searchbar
        value={searchQuery}
        onChangeText={setSearchQuery}
        placeholder="Wyszukaj atrakcję"
        style={styles.searchbar}
      />
      {places.length > 0 ? (
        "test"
      ) : (
        <Text style={styles.text} variant="bodyLarge">
          Użyj wyszukiwania aby przeglądać dostępne atrakcje
        </Text>
      )}
    </View>
  );
}

const makeStyles = (theme: MD3ThemeExtended) =>
  StyleSheet.create({
    container: {
      flex: 1,
      flexDirection: "column",
      alignItems: "center",
      paddingHorizontal: 20,
      backgroundColor: theme.colors.background,
    },
    searchbar: {
      alignSelf: "stretch",
      backgroundColor: theme.colors.surfaceContainerHigh,
      marginVertical: 20,
    },
    text: {
      textAlign: "center",
    },
  });
