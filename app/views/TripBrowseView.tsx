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
import CustomModal from "@/components/CustomModal";
import ActionTextButtons from "@/components/ActionTextButtons";
import { DELETE_ICON, DETAILS_ICON, EDIT_ICON } from "@/constants/Icons";

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
  const [isModalVisible, setIsModalVisible] = useState<boolean>(false);
  const [selectedTrip, setSelectedTrip] = useState<Trip | null>(null);

  const filteredTrips = trips.filter((trip) =>
    trip.title.toLowerCase().includes(searchQuery.toLowerCase()),
  );

  const handlePress = (trip: Trip) => {
    setIsVisible(false);
    router.push(`/trips/details/${trip.id}`);
  };

  const handleLongPress = (trip: Trip) => {
    setSelectedTrip(trip);
  };

  const onCloseBottomSheet = () => {
    setIsVisible(false);
    if (!isModalVisible) setSelectedTrip(null);
  };

  const showModal = () => {
    setIsModalVisible(true);
  };

  const hideModal = () => {
    setIsModalVisible(false);
    setSelectedTrip(null);
  };

  const deleteTrip = (trip: Trip | null) => {
    console.log(`Usuwanie wycieczki: ${trip?.title}`);
    hideModal();
  };

  useEffect(() => {
    if (selectedTrip) {
      setIsVisible(true);
    }
  }, [selectedTrip]);

  const renderItem = ({ item }: { item: Trip }) => (
    <TripCard
      title={item.title}
      subtitle={item.subtitle}
      imageUri={item.imageUri}
      isArchived={item.isArchived}
      onPress={() => handlePress(item)}
      onLongPress={() => {
        handleLongPress(item);
      }}
    />
  );

  const [value, setValue] = React.useState("actual");

  const handleValueChange = (newValue: string) => {
    setValue(newValue);
    setTrips(newValue === "actual" ? actualTrips : archivedTrips);
  };

  const getActionsForSelectedTrip: Action[] = useMemo(() => {
    if (!selectedTrip) return [];
    return [
      {
        label: "Szczegóły wycieczki",
        icon: DETAILS_ICON,
        onPress: () => {
          console.log(`Nawiguj do szczegółów`);
          setIsVisible(false);
          router.push(`/trips/details/${selectedTrip.id}`);
        },
      },
      {
        label: "Edytuj szczegóły wycieczki",
        icon: EDIT_ICON,
        onPress: () => {
          console.log(`Edytuj`);
          setIsVisible(false);
          router.push(`/trips/edit/${selectedTrip.id}`);
        },
      },
      {
        label: "Usuń wycieczkę",
        icon: DELETE_ICON,
        onPress: () => {
          console.log(`Usuń`);
          setIsVisible(false);
          showModal();
        },
      },
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
              style: styles.segmentedButton,
            },
            {
              value: "archive",
              label: "Archiwum",
              style: styles.segmentedButton,
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
          onPress={() => router.push(`/trips/add`)}
        />
        <CustomModal visible={isModalVisible} onDismiss={hideModal}>
          <View>
            <Text style={styles.modalTitleText}>
              Czy na pewno chcesz usunąć tą wycieczkę?
            </Text>
            <View style={styles.modalContent}>
              <Text style={styles.boldText}>{selectedTrip?.title}</Text>
              <Text style={styles.modalSubtitle}>{selectedTrip?.subtitle}</Text>
            </View>
            <ActionTextButtons
              onAction1={hideModal}
              onAction2={() => deleteTrip(selectedTrip)}
            />
          </View>
        </CustomModal>
      </View>

      <ActionMenuBottomSheet
        headerComponent={() => (
          <Text style={styles.bottomSheetText}>Wybierz opcję</Text>
        )}
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
    container: {
      flex: 1,
      backgroundColor: theme.colors.background,
    },
    segmentedButtons: {
      elevation: 0,
      backgroundColor: theme.colors.surface,
    },
    segmentedButton: {
      borderWidth: 0,
      borderBottomWidth: 1,
      borderColor: theme.colors.elevation.level3,
    },
    searchbar: {
      backgroundColor: theme.colors.elevation.level3,
      margin: 20,
    },
    flatListContent: {
      flexGrow: 1,
      backgroundColor: theme.colors.background,
      paddingBottom: 20,
    },
    fab: {
      position: "absolute",
      margin: 16,
      right: 0,
      bottom: 0,
      backgroundColor: theme.colors.primary,
    },
    modalTitleText: {
      ...theme.fonts.titleLarge,
      color: theme.colors.onBackground,
    },
    modalContent: {
      marginVertical: 20,
    },
    boldText: {
      fontWeight: "bold",
      color: theme.colors.onBackground,
    },
    modalSubtitle: {
      color: theme.colors.onBackground,
    },
    bottomSheetText: {
      marginBottom: 10,
      marginTop: -10,
      color: theme.colors.onBackground,
      ...theme.fonts.bodyMedium,
    },
  });
