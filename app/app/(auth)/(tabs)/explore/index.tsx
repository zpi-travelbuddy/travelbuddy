import { useEffect, useState } from "react";
import { View, StyleSheet, FlatList } from "react-native";
import { Text, useTheme } from "react-native-paper";
import { Searchbar } from "react-native-paper";
import { PlaceCard } from "@/components/explore/PlaceCard";
import { MD3ThemeExtended } from "@/constants/Themes";

// TODO: Match interface to actual data
interface Place {
  id: string;
  title: string;
  subtitle: string;
}

const renderPlace = ({ item }: { item: Place }) => (
  <PlaceCard title={item.title} subtitle={item.subtitle} />
);

export default function Explore() {
  const [searchQuery, setSearchQuery] = useState("");
  const [places, setPlaces] = useState<Place[]>([]);

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
      <FlatList
        data={places}
        renderItem={renderPlace}
        keyExtractor={(item) => item.id}
        ListEmptyComponent={() => (
          <Text style={styles.text} variant="bodyLarge">
            Użyj wyszukiwania aby przeglądać dostępne atrakcje
          </Text>
        )}
        ItemSeparatorComponent={() => <View style={styles.separator} />}
      />
    </View>
  );
}

const makeStyles = (theme: MD3ThemeExtended) =>
  StyleSheet.create({
    container: {
      flex: 1,
      flexDirection: "column",
      alignItems: "stretch",
      paddingHorizontal: 20,
      paddingBottom: 20,
      backgroundColor: theme.colors.background,
    },
    searchbar: {
      backgroundColor: theme.colors.surfaceContainerHigh,
      marginVertical: 20,
    },
    text: {
      textAlign: "center",
    },
    separator: {
      height: 10,
    },
  });
