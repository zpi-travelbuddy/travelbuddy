import { StyleSheet, View, Text } from "react-native";
import React, { useEffect, useMemo, useState } from "react";
import { TripCard } from "@/components/TripCard";
import { useRouter } from "expo-router";
import {
  useTheme,
  FAB,
  Searchbar,
  SegmentedButtons,
  MD3Theme,
} from "react-native-paper";
import { FlatList } from "react-native";
import { GestureHandlerRootView } from "react-native-gesture-handler";
import ActionMenuBottomSheet from "@/components/ActionMenu/ActionMenuBottomSheet";

const TripBrowseView = () => {
  const theme = useTheme();
  const styles = createStyles(theme);
  const router = useRouter();
  const [searchQuery, setSearchQuery] = useState("");

  type Trip = {
    id: string;
    title: string;
    subtitle: string;
    imageUri: string;
    isArchived: boolean;
  };

  const actualTrips = [
    {
      id: "1",
      title: "Wycieczka do Milicza",
      subtitle: "10.06.2025 - 15.06.2025",
      imageUri: "https://picsum.photos/888",
      isArchived: false,
    },
    {
      id: "2",
      title: "Wycieczka do Wrocławia",
      subtitle: "20.06.2025 - 25.06.2025",
      imageUri: "https://picsum.photos/889",
      isArchived: false,
    },
    {
      id: "3",
      title: "Wycieczka do Moszczanki",
      subtitle: "20.01.2026 - 25.01.2026",
      imageUri: "https://picsum.photos/887",
      isArchived: false,
    },
  ];

  const archivedTrips = [
    {
      id: "1000",
      title: "Wycieczka do Krakowa",
      subtitle: "15.07.2024 - 20.07.2024",
      imageUri: "https://picsum.photos/890",
      isArchived: true,
    },
    {
      id: "1001",
      title: "Wycieczka do Zakopanego",
      subtitle: "01.08.2024 - 07.08.2024",
      imageUri: "https://picsum.photos/891",
      isArchived: true,
    },
  ];

  const [trips, setTrips] = useState<Trip[]>(actualTrips);
  const [isVisible, setIsVisible] = useState<boolean>(false);
  const [selectedTrip, setSelectedTrip] = useState<Trip | null>(null);

  const filteredTrips = trips.filter((trip) =>
    trip.title.toLowerCase().includes(searchQuery.toLowerCase()),
  );

  const handleLongPress = (trip: Trip) => {
    setSelectedTrip(trip);
  };

  const onCloseBottomSheet = () => {
    setIsVisible(false);
    setSelectedTrip(null);
  };

  useEffect(() => {
    if (selectedTrip) {
      setIsVisible(true);
    }
  }, [selectedTrip]); // Zależność od selectedTrip

  const renderItem = ({ item }: { item: Trip }) => (
    <TripCard
      title={item.title}
      subtitle={item.subtitle}
      imageUri={item.imageUri}
      isArchived={item.isArchived}
      onLongPress={() => {
        handleLongPress(item);
      }}
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

  const getActionsForSelectedTrip = useMemo(() => {
    if (!selectedTrip) return [];
    return [
      {
        label: "Szczegóły wycieczki",
        icon: "info",
        onPress: () => {
          console.log(`Nawiguj do szczegółów`);
          setIsVisible(false);
          router.push({
            pathname: `/`,
            params: { id: selectedTrip.id },
          });
        },
      } as Action,
      {
        label: "Edytuj szczegóły wycieczki",
        icon: "edit",
        onPress: () => {
          console.log(`Edytuj`);
          setIsVisible(false);
        },
      } as Action,
      {
        label: "Usuń wycieczkę",
        icon: "delete",
        onPress: () => {
          console.log(`Usuń`);
          setIsVisible(false);
        },
      } as Action,
    ];
  }, [selectedTrip]);

  return (
    <GestureHandlerRootView>
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

      <ActionMenuBottomSheet
        headerComponent={() => <Text style={styles.text}>Wybierz opcję</Text>}
        actions={getActionsForSelectedTrip}
        isVisible={isVisible}
        onClose={() => onCloseBottomSheet()}
      />
    </GestureHandlerRootView>
  );
};

export default TripBrowseView;

const createStyles = (theme: MD3Theme) =>
  StyleSheet.create({
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
    },
    flatListContent: {
      flexGrow: 1,
      backgroundColor: theme.colors.background,
      flexDirection: "column",
      alignItems: "stretch",
      paddingBottom: 20,
    },
    container: {
      flex: 1,
    },
    segmentedButtons: {
      elevation: 0,
      backgroundColor: theme.colors.surface,
    },
    text: {
      marginBottom: 10,
      marginTop: -10,
      color: theme.colors.onBackground,
      ...theme.fonts.bodyMedium,
    },
  });
