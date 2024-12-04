/* eslint-disable @typescript-eslint/no-explicit-any */
import { useState, useCallback, useEffect, useMemo } from "react";
import { View, StyleSheet, FlatList } from "react-native";
import {
  Text,
  useTheme,
  Searchbar,
  ActivityIndicator,
} from "react-native-paper";
import { PlaceCard } from "@/components/explore/PlaceCard";
import { MD3ThemeExtended } from "@/constants/Themes";
import { PlaceCompact, PlaceViewModel } from "@/types/Place";
import { useAnimatedKeyboard } from "react-native-reanimated";
import { useDebouncedCallback } from "use-debounce";
import { useAuth } from "@/app/ctx";
import { API_PLACES_AUTOCOMPLETE } from "@/constants/Endpoints";
import CustomModal from "@/components/CustomModal";
import { RenderItem } from "@/components/RenderItem";
import ActionTextButtons from "@/components/ActionTextButtons";
import { truncateText } from "@/utils/TextUtils";
import { useFocusEffect, useLocalSearchParams, useRouter } from "expo-router";
import SingleDatePickerModal from "@/components/SingleDatePickerModal";
import useTripDetails from "@/composables/useTripDetails";
import { CalendarDate } from "react-native-paper-dates/lib/typescript/Date/Calendar";
import { TripDay } from "@/types/Trip";
import { useSnackbar } from "@/context/SnackbarContext";

const convertPlace = (place: PlaceCompact): PlaceViewModel => {
  const subtitle = [place.city, place.state, place.country]
    .filter(Boolean)
    .join(", ");

  return {
    id: place.id,
    providerId: place.providerId || "",
    title: place.name,
    subtitle: subtitle,
  };
};

interface ExploreViewProps {
  tripId?: string;
}

// If we navigate from trip details -> we pass tripId
// If we navigate from main menu -> we don't pass tripId and we have to select trip from modal
const ExploreView = ({ tripId }: ExploreViewProps) => {
  const { api } = useAuth();
  const { showSnackbar } = useSnackbar();
  const { trip_id, day_id, date } = useLocalSearchParams();

  const router = useRouter();

  const [searchQuery, setSearchQuery] = useState("");

  const theme = useTheme() as MD3ThemeExtended;
  const styles = makeStyles(theme);

  const [places, setPlaces] = useState<PlaceViewModel[]>([]);
  const [currentTrips, setCurrentTrips] = useState<any[]>([]); // will change to Trips later (after trips browse merge)
  const [isLoading, setIsLoading] = useState<boolean>(false);
  const [tripModalVisible, setTripModalVisible] = useState(false);
  const [isDateModalVisible, setIsDateModalVisible] = useState(false);

  const [selectedTripId, setSelectedTripId] = useState<string | null>(null);
  const [selectedAttractionProviderId, setSelectedAttractionProviderId] =
    useState<string | null>(null);

  const {
    tripDetails,
    loading: tripLoading,
    error: tripError,
    refetch: tripFetch,
  } = useTripDetails(selectedTripId as string, { immediate: false });

  useEffect(() => {
    setIsLoading(tripLoading);
  }, [tripLoading]);

  useEffect(() => {
    if (tripError) showSnackbar(tripError);
  }, [tripError]);

  useAnimatedKeyboard();

  const fetchPlaces = async (query: string) => {
    try {
      const response = await api!.get(API_PLACES_AUTOCOMPLETE, {
        params: {
          query,
        },
      });

      const parsedData = response.data.map(convertPlace) as PlaceViewModel[];
      setPlaces(
        parsedData.filter(
          (place) =>
            place.title && place.subtitle && !place.providerId.includes("null"),
        ),
      );
    } catch (error: any) {
      console.error(error.response.data);
    }
  };

  const fetchCurrentTrips = async () => {
    try {
      const response = await api!.get("/trips/current");
      setCurrentTrips(response.data);
    } catch (error: any) {
      console.log(error.response.data);
    }
  };

  const debouncedFetchPlaces = useDebouncedCallback(async (query: string) => {
    if (query.length > 2) {
      await fetchPlaces(query);
    }
    setIsLoading(false);
  }, 800);

  const handleChangeQuery = async (query: string) => {
    setPlaces([]);
    setSearchQuery(query);
    setIsLoading(query.length > 2);
    debouncedFetchPlaces(query);
  };

  const handleDismissTripModal = () => {
    setTripModalVisible(false);
    setSelectedTripId(null);
  };

  const handleConfirmTrip = () => {
    // logic for navigating to trip point add
    console.log("Navigating to trip point add for trip", selectedTripId);
    if (selectedTripId && selectedAttractionProviderId) {
      tripFetch();
      setIsDateModalVisible(true);
    }
  };

  const handleTripSelection = (item: any) => {
    setSelectedTripId(item.id);
    console.log("Selected trip", item.id);
  };

  const handleAddPress = (place: PlaceViewModel) => {
    console.log("Selected place", place);
    if (trip_id && day_id && date) {
      console.log("Data: " + date);
      router.push({
        pathname: `/(auth)/(tabs)/trips/details/${trip_id}/day/${day_id}/tripPoints/create`,
        params: {
          date: new Date(date as string).toLocaleDateString(),
          attractionProviderId: place.providerId,
        },
      });
    } else {
      setTripModalVisible(true);
      setSelectedAttractionProviderId(place.providerId);
    }
  };

  const EmptyListComponent = useCallback(() => {
    let emptyText = "Brak wyników wyszukiwania";

    if (searchQuery.length < 3) {
      emptyText = "Wpisz co najmniej 3 znaki aby wyszukać atrakcję";
    }

    if (!searchQuery) {
      emptyText = "Użyj wyszukiwania aby przeglądać dostępne atrakcje";
    }

    return (
      <Text style={styles.emptyText} variant="bodyLarge">
        {emptyText}
      </Text>
    );
  }, [searchQuery]);

  const renderPlace = ({ item }: { item: PlaceViewModel }) => {
    return (
      <PlaceCard
        place={item}
        handleAddPress={() => {
          handleAddPress(item);
        }}
      />
    );
  };

  useFocusEffect(
    useCallback(() => {
      if (!tripId) {
        fetchCurrentTrips();
      }
    }, [tripId]),
  );

  const handleDismiss = useCallback(() => {
    setIsDateModalVisible(false);
  }, [setIsDateModalVisible]);

  const dateToIdMap = useMemo(() => {
    return new Map(
      tripDetails?.tripDays.map((day: TripDay) => [day.date, day.id]) || [],
    );
  }, [tripDetails]);

  const handleConfirm = useCallback(
    ({ date }: { date: CalendarDate }) => {
      setTripModalVisible(false);
      const fixedDate = date as Date;
      const formattedDate = fixedDate.toISOString().split("T")[0];
      const tripDayId = dateToIdMap.get(formattedDate);
      if (tripDetails?.id && tripDayId) {
        console.log("Redirecting to day with id " + tripDayId);
        console.log(
          "Redirecting to adding trip point for attraction id " +
            selectedAttractionProviderId,
        );
        setIsDateModalVisible(false);
        router.push({
          pathname: `/(auth)/(tabs)/trips/details/${tripDetails?.id}/day/${tripDayId}/tripPoints/create`,
          params: {
            date: fixedDate.toLocaleDateString(),
            attractionProviderId: selectedAttractionProviderId,
          },
        });
      } else {
        console.error("Day not found");
      }
    },
    [
      setIsDateModalVisible,
      selectedAttractionProviderId,
      tripDetails,
      dateToIdMap,
    ],
  );

  return (
    <>
      <View style={styles.container}>
        <Searchbar
          value={searchQuery}
          onChangeText={handleChangeQuery}
          placeholder="Wyszukaj atrakcję"
          style={styles.searchbar}
        />
        <FlatList
          data={places}
          renderItem={renderPlace}
          keyExtractor={(item) => item.providerId}
          ListEmptyComponent={
            isLoading ? (
              <ActivityIndicator
                style={styles.loadingIndicator}
                animating={true}
                size="large"
                color={theme.colors.primary}
              />
            ) : (
              EmptyListComponent
            )
          }
          contentContainerStyle={styles.contentContainer}
          ItemSeparatorComponent={() => <View style={styles.separator} />}
        />

        {tripDetails && (
          <SingleDatePickerModal
            visible={isDateModalVisible}
            startDate={tripDetails?.startDate}
            endDate={tripDetails?.endDate}
            onDismiss={handleDismiss}
            onConfirm={handleConfirm}
          />
        )}
      </View>
      <CustomModal
        visible={tripModalVisible}
        onDismiss={handleDismissTripModal}
      >
        <Text style={styles.modalHeadline} variant="headlineSmall">
          Wybierz wycieczkę
        </Text>
        <FlatList
          style={styles.tripList}
          data={currentTrips}
          renderItem={({ item }) => (
            <RenderItem
              item={item}
              isSelected={selectedTripId === item.id}
              onSelect={handleTripSelection}
              renderContent={(item: any) => truncateText(item.name, 25)}
            />
          )}
          keyExtractor={(item) => item.id}
          ItemSeparatorComponent={() => <View />}
          ListEmptyComponent={<Text>Brak dostępnych wycieczek</Text>}
        />
        <ActionTextButtons
          onAction1={handleDismissTripModal}
          onAction2={handleConfirmTrip}
          action1ButtonLabel="Anuluj"
          action2ButtonLabel="OK"
          action1Icon={undefined}
          action2Icon={undefined}
        />
      </CustomModal>
    </>
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
    loadingIndicator: { margin: "auto" },
    modalHeadline: {
      alignSelf: "flex-start",
      marginBottom: 20,
    },
    tripList: {
      maxHeight: 200,
      marginBottom: 20,
    },
  });

export default ExploreView;
