/* eslint-disable @typescript-eslint/no-explicit-any */
import { StyleSheet, View, Text, RefreshControl } from "react-native";
import { useCallback, useEffect, useMemo, useRef, useState } from "react";
import { TripCard } from "@/components/TripCard";
import { router, useFocusEffect, useLocalSearchParams } from "expo-router";
import {
  useTheme,
  FAB,
  Searchbar,
  SegmentedButtons,
  MD3Theme,
  ActivityIndicator,
} from "react-native-paper";
import { FlatList } from "react-native";
import { GestureHandlerRootView } from "react-native-gesture-handler";
import ActionMenuBottomSheet from "@/components/ActionMenu/ActionMenuBottomSheet";
import CustomModal from "@/components/CustomModal";
import ActionTextButtons from "@/components/ActionTextButtons";
import { DELETE_ICON, DETAILS_ICON, EDIT_ICON } from "@/constants/Icons";
import { useSnackbar } from "@/context/SnackbarContext";
import { useAuth } from "@/app/ctx";
import { API_TRIPS_CURRENT, API_TRIPS_PAST } from "@/constants/Endpoints";
import { useAnimatedKeyboard } from "react-native-reanimated";
import { TripCompact } from "@/types/Trip";
import { formatTimeRange, stringToDateDots } from "@/utils/TimeUtils";
import { convertTripsFromAPI } from "@/converters/tripConverters";
import useTripImageStorage from "@/hooks/useTripImageStore";
import { conditionalItem } from "@/utils/ArrayUtils";
import { useShouldRefresh } from "@/context/ShouldRefreshContext";

type TripViewMode = "actual" | "archive";

const TripBrowseView = () => {
  const { api } = useAuth();

  const flatListRef = useRef<FlatList>(null);

  useAnimatedKeyboard();

  const theme = useTheme();
  const styles = createStyles(theme);

  const { refreshScreens, removeRefreshScreen } = useShouldRefresh();

  const { removeImage } = useTripImageStorage();

  const [searchQuery, setSearchQuery] = useState("");

  const [isLoading, setIsLoading] = useState<boolean>(false);
  const [refreshing, setRefreshing] = useState<boolean>(false);

  const { showSnackbar } = useSnackbar();

  const [currentTrips, setCurrentTrips] = useState<TripCompact[]>([]);
  const [pastTrips, setPastTrips] = useState<TripCompact[]>([]);
  const [isVisible, setIsVisible] = useState<boolean>(false);
  const [isModalVisible, setIsModalVisible] = useState<boolean>(false);
  const [selectedTrip, setSelectedTrip] = useState<TripCompact | null>(null);

  const [value, setValue] = useState<TripViewMode>("actual");

  const shouldRefresh = useMemo(
    () => refreshScreens.includes("trips"),
    [refreshScreens],
  );

  const trips = useMemo(() => {
    const tripsToFilter = value === "actual" ? currentTrips : pastTrips;

    return tripsToFilter
      .filter((trip) =>
        trip.name.toLowerCase().includes(searchQuery.toLowerCase()),
      )
      .sort((a, b) => {
        if (a.startDate === b.startDate)
          return a.endDate.localeCompare(b.endDate);

        return a.startDate.localeCompare(b.startDate);
      });
  }, [value, searchQuery, currentTrips, pastTrips]);

  const handleValueChange = (newValue: string) => {
    setValue(newValue as TripViewMode);
    flatListRef.current!.scrollToOffset({ animated: true, offset: 0 });
  };

  const handlePress = (trip: TripCompact) => {
    setIsVisible(false);
    router.push(`/trips/details/${trip.id}`);
  };

  const handleLongPress = (trip: TripCompact) => {
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

  const deleteTrip = async (trip: TripCompact | null) => {
    if (!trip) return;
    console.log(`Usuwanie wycieczki: ${trip?.name}`);
    hideModal();
    try {
      await api!.delete(`/trips/${trip.id}`);
      await removeImage(trip.id);
      await fetchTrips();
      showSnackbar("Usunięto wycieczkę!");
    } catch (error: any) {
      showSnackbar("Wystąpił błąd podczas usuwania wycieczki", "error");
    }
  };

  const fetchTripsByType = async (
    endpoint: string,
    setTrips: (trips: TripCompact[]) => void,
    errorFallback: () => void,
  ) => {
    try {
      const trips: TripCompact[] = (await api!.get(endpoint)).data;
      const isArchived = endpoint === API_TRIPS_PAST;
      const parsedTrips = convertTripsFromAPI(trips, isArchived);
      setTrips(parsedTrips);
    } catch (error: any) {
      if (error.response && error.response.status === 404) {
        errorFallback();
      } else {
        console.error(
          `Error fetching trips from ${endpoint}`,
          error.response?.data || error,
        );
      }
    }
  };

  const fetchCurrentTrips = async () => {
    await fetchTripsByType(API_TRIPS_CURRENT, setCurrentTrips, () =>
      setCurrentTrips([]),
    );
  };

  const fetchPastTrips = async () => {
    await fetchTripsByType(API_TRIPS_PAST, setPastTrips, () =>
      setPastTrips([]),
    );
  };

  const fetchTrips = async () => {
    setIsLoading(true);
    try {
      await Promise.all([fetchCurrentTrips(), fetchPastTrips()]);
    } finally {
      setIsLoading(false);
    }
  };

  useEffect(() => {
    fetchTrips();
  }, []);

  const onRefresh = useCallback(async () => {
    setRefreshing(true);
    await fetchTrips();
    setRefreshing(false);
  }, []);

  useEffect(() => {
    if (selectedTrip) {
      setIsVisible(true);
    }
  }, [selectedTrip]);

  useEffect(() => {
    const refreshOnFocus = async () => {
      if (shouldRefresh) {
        console.log("Refetching day data");

        await fetchTrips();
        removeRefreshScreen("trips");
      }
    };
    refreshOnFocus();
  }, [shouldRefresh]);

  const renderItem = ({ item }: { item: TripCompact }) => (
    <TripCard
      id={item.id}
      title={item.name}
      subtitle={formatTimeRange(item.startDate, item.endDate)}
      isArchived={item.isArchived}
      onPress={() => handlePress(item)}
      onLongPress={() => {
        handleLongPress(item);
      }}
    />
  );

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
      ...conditionalItem(stringToDateDots(selectedTrip.endDate) >= new Date(), {
        label: "Edytuj szczegóły wycieczki",
        icon: EDIT_ICON,
        onPress: () => {
          console.log(selectedTrip.endDate);
          console.log(`Edytuj`);
          setIsVisible(false);
          router.push(`/trips/edit/${selectedTrip.id}`);
        },
      }),
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
        <Searchbar
          value={searchQuery}
          onChangeText={setSearchQuery}
          placeholder="Wyszukaj wycieczkę"
          style={styles.searchbar}
        />
        <FlatList
          ref={flatListRef}
          data={trips}
          renderItem={renderItem}
          keyExtractor={(item, index) => index.toString()}
          contentContainerStyle={styles.flatListContent}
          showsVerticalScrollIndicator={false}
          refreshControl={
            <RefreshControl refreshing={refreshing} onRefresh={onRefresh} />
          }
          ListEmptyComponent={
            isLoading ? (
              <ActivityIndicator
                style={styles.loadingIndicator}
                animating={true}
                size="large"
                color={theme.colors.primary}
              />
            ) : (
              <Text style={styles.emptyMessage}>Nie znaleziono wycieczek</Text>
            )
          }
        />
        {value === "actual" && (
          <FAB
            style={styles.fab}
            icon="plus"
            color={theme.colors.onPrimary}
            label="Dodaj"
            onPress={() => router.push(`/trips/add`)}
          />
        )}
        <CustomModal visible={isModalVisible} onDismiss={hideModal}>
          <View>
            <Text style={styles.modalTitleText}>
              Czy na pewno chcesz usunąć tą wycieczkę?
            </Text>
            <View style={styles.modalContent}>
              <Text style={styles.boldText}>{selectedTrip?.name}</Text>
              <Text style={styles.modalSubtitle}>
                {formatTimeRange(
                  selectedTrip?.startDate || "",
                  selectedTrip?.endDate || "",
                )}
              </Text>
            </View>
            <ActionTextButtons
              onAction1={hideModal}
              onAction2={() => deleteTrip(selectedTrip)}
              action1ButtonLabel="Anuluj"
              action2ButtonLabel="Usuń"
              action1Icon={undefined}
              action2Icon={undefined}
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
      backgroundColor: theme.colors.surface,
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
      backgroundColor: theme.colors.surface,
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
      color: theme.colors.onSurface,
    },
    modalContent: {
      marginVertical: 20,
    },
    boldText: {
      fontWeight: "bold",
      color: theme.colors.onSurface,
    },
    modalSubtitle: {
      color: theme.colors.onSurface,
    },
    bottomSheetText: {
      marginBottom: 10,
      marginTop: -10,
      color: theme.colors.onSurface,
      ...theme.fonts.bodyMedium,
    },
    emptyMessage: {
      textAlign: "center",
      marginTop: 20,
      color: theme.colors.onSurface,
    },
    loadingIndicator: { margin: "auto" },
  });
