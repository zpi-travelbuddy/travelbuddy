import { SafeAreaView, ScrollView, StyleSheet, View } from "react-native";
import React, { useState } from "react";
import { TripCard } from "@/components/TripCard";
import { useTheme, FAB, Searchbar, SegmentedButtons } from "react-native-paper";
import { FlatList } from "react-native";

const TripBrowse = () => {
  const theme = useTheme();
  const [searchQuery, setSearchQuery] = useState("");

  type Trip = {
    title: string;
    subtitle: string;
    imageUri: string;
    isArchived: boolean;
  };

  const actualTrips = [
    {
      title: "Wycieczka do Milicza",
      subtitle: "10.06.2025 - 15.06.2025",
      imageUri: "https://picsum.photos/888",
      isArchived: false,
    },
    {
      title: "Wycieczka do Wrocławia",
      subtitle: "20.06.2025 - 25.06.2025",
      imageUri: "https://picsum.photos/889",
      isArchived: false,
    },
    {
      title: "Wycieczka do Moszczanki",
      subtitle: "20.01.2026 - 25.01.2026",
      imageUri: "https://picsum.photos/887",
      isArchived: false,
    },
  ];

  const archivedTrips = [
    {
      title: "Wycieczka do Krakowa",
      subtitle: "15.07.2024 - 20.07.2024",
      imageUri: "https://picsum.photos/890",
      isArchived: true,
    },
    {
      title: "Wycieczka do Zakopanego",
      subtitle: "01.08.2024 - 07.08.2024",
      imageUri: "https://picsum.photos/891",
      isArchived: true,
    },
  ];

  const [trips, setTrips] = useState<Trip[]>(actualTrips);

  const filteredTrips = trips.filter((trip) =>
    trip.title.toLowerCase().includes(searchQuery.toLowerCase()),
  );

  const styles = StyleSheet.create({
    fab: {
      position: "absolute",
      margin: 16,
      right: 0,
      bottom: 0,
      backgroundColor: theme.colors.primary,
    },
    searchbar: {
      backgroundColor: theme.colors.elevation.level3,
      margin: 20,
      marginTop: 0,
    },
    flatListContent: {
      flexGrow: 1,
      flexDirection: "column",
      alignItems: "stretch",
      paddingBottom: 20,
    },
    container: {
      flex: 1,
    },
    segmentedButtons: {
      elevation: 0,
      marginBottom: 20,
      backgroundColor: theme.colors.surface,
    },
  });

  const renderItem = ({ item }: { item: Trip }) => (
    <TripCard
      title={item.title}
      subtitle={item.subtitle}
      imageUri={item.imageUri}
      isArchived={item.isArchived}
    />
  );

  const [value, setValue] = React.useState("actual");

  const handleValueChange = (newValue: string) => {
    setValue(newValue);
    switch (newValue) {
      case "actual":
        setTrips(actualTrips);
        break;
      case "archive":
        setTrips(archivedTrips);
        break;
      default:
        break;
    }
  };

  return (
    <View style={styles.container}>
      <SegmentedButtons
        value={value}
        onValueChange={handleValueChange}
        style={styles.segmentedButtons}
        theme={{
          ...theme,
          roundness: 0,
        }}
        buttons={[
          {
            value: "actual",
            label: "Aktualne",
            style: {
              borderWidth: 0,
              borderBottomWidth: 1,
              borderColor: theme.colors.elevation.level3,
            },
          },
          {
            value: "archive",
            label: "Archiwum",
            style: {
              borderWidth: 0,
              borderBottomWidth: 1,
              borderColor: theme.colors.elevation.level3,
            },
          },
        ]}
      />
      <FlatList
        data={filteredTrips}
        renderItem={renderItem}
        keyExtractor={(item, index) => index.toString()}
        contentContainerStyle={styles.flatListContent}
        showsVerticalScrollIndicator={false}
        ListHeaderComponent={
          <Searchbar
            value={searchQuery}
            onChangeText={setSearchQuery}
            placeholder="Wyszukaj wycieczkę"
            style={styles.searchbar}
          />
        }
      />
      <FAB
        style={styles.fab}
        icon="plus"
        color={theme.colors.onPrimary}
        label="Dodaj"
        onPress={() => {
          console.log("FAB Clicked");
        }}
      />
    </View>
  );
};

export default TripBrowse;
