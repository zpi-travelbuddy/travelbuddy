import { useState, useMemo } from "react";
import { View, StyleSheet, FlatList } from "react-native";
import { Text, useTheme, Searchbar } from "react-native-paper";
import { PlaceCard } from "@/components/explore/PlaceCard";
import { MD3ThemeExtended } from "@/constants/Themes";
import { useRouter } from "expo-router";
import { PlaceViewModel } from "@/types/Place";

// TODO: Match interface to actual data

const defaultPlaces: PlaceViewModel[] = [
  {
    id: "1",
    name: "Restauracja Rzym",
    address: {
      city: "Rzym",
      country: "Włochy",
      street: "",
      number: "",
    },
    attractionType: "food",
    conditions: ["internet_access"],
    rating: 4.5,
    averageCostPerPerson: 50,
    averageVisitTime: "2 godziny",
    latitude: 41.9028,
    longitude: 12.4964,
    imageUrl:
      "https://upload.wikimedia.org/wikipedia/commons/thumb/8/84/Sant%27Angelo_bridge%2C_dusk%2C_Rome%2C_Italy.jpg/320px-Sant%27Angelo_bridge%2C_dusk%2C_Rome%2C_Italy.jpg",
  },
  {
    id: "2",
    name: "Łazienki Królewskie",
    address: {
      city: "Warszawa",
      country: "Polska",
      street: "",
      number: "",
    },
    attractionType: "park",
    conditions: [],
    rating: 4.7,
    averageCostPerPerson: 0,
    averageVisitTime: "3 godziny",
    latitude: 52.2167,
    longitude: 21.0333,
    imageUrl:
      "https://upload.wikimedia.org/wikipedia/commons/thumb/5/55/%C5%81azienki_Kr%C3%B3lewskie.jpg/320px-%C5%81azienki_Kr%C3%B3lewskie.jpg",
  },
  {
    id: "3",
    name: "Wieża Eiffle'a",
    address: {
      city: "Paryż",
      country: "Francja",
      street: "",
      number: "",
    },
    attractionType: "attraction",
    conditions: ["internet_access"],
    rating: 4.8,
    averageCostPerPerson: 25,
    averageVisitTime: "1 godzina",
    latitude: 48.8584,
    longitude: 2.2945,
    imageUrl:
      "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Paris_-_The_Eiffel_Tower_in_spring_-_2307.jpg/320px-Paris_-_The_Eiffel_Tower_in_spring_-_2307.jpg",
  },
  {
    id: "4",
    name: "Statua Wolności",
    address: {
      city: "Waszyngton",
      country: "Stany Zjednoczone Ameryki",
      street: "",
      number: "",
    },
    attractionType: "attraction",
    conditions: ["dogs", "wheelchair"],
    rating: 4.6,
    averageCostPerPerson: 30,
    averageVisitTime: "2 godziny",
    latitude: 38.8893,
    longitude: -77.0502,
    imageUrl:
      "https://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Liberty_Enlightening_the_World_at_%C3%8Ele_aux_Cygnes_%2834801496070%29.jpg/320px-Liberty_Enlightening_the_World_at_%C3%8Ele_aux_Cygnes_%2834801496070%29.jpg",
  },
];

const Explore = () => {
  const [searchQuery, setSearchQuery] = useState("");
  const theme = useTheme() as MD3ThemeExtended;
  const styles = makeStyles(theme);
  const router = useRouter();

  const filteredPlaces = useMemo(
    () =>
      defaultPlaces.filter((place) =>
        place.name.toLowerCase().includes(searchQuery.toLowerCase()),
      ),
    [searchQuery],
  );

  const EmptyListComponent = () => (
    <Text style={styles.emptyText} variant="bodyLarge">
      {searchQuery
        ? "Brak wyników wyszukiwania"
        : "Użyj wyszukiwania aby przeglądać dostępne atrakcje"}
    </Text>
  );

  const renderPlace = ({ item }: { item: PlaceViewModel }) => (
    <PlaceCard
      place={item}
      onDetailsClick={(id: string) =>
        router.push(`/(auth)/(tabs)/explore/place/${item.id}`)
      }
    />
  );

  return (
    <View style={styles.container}>
      <Searchbar
        value={searchQuery}
        onChangeText={setSearchQuery}
        placeholder="Wyszukaj atrakcję"
        style={styles.searchbar}
      />
      <FlatList
        data={filteredPlaces}
        renderItem={renderPlace}
        keyExtractor={(item) => item.id}
        ListEmptyComponent={EmptyListComponent}
        contentContainerStyle={styles.contentContainer}
        ItemSeparatorComponent={() => <View style={styles.separator} />}
      />
    </View>
  );
};

const makeStyles = (theme: MD3ThemeExtended) =>
  StyleSheet.create({
    contentContainer: {
      paddingBottom: 20,
    },
    container: {
      flex: 1,
      paddingHorizontal: 20,
      backgroundColor: theme.colors.background,
    },
    searchbar: {
      backgroundColor: theme.colors.surfaceContainerHigh,
      marginVertical: 20,
    },
    emptyText: {
      textAlign: "center",
      marginVertical: 20,
      color: theme.colors.onSurface,
    },
    separator: {
      height: 20,
    },
  });

export default Explore;
