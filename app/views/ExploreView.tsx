import { useState, useCallback, useEffect } from "react";
import { View, StyleSheet, FlatList } from "react-native";
import {
  Text,
  useTheme,
  Searchbar,
  ActivityIndicator,
} from "react-native-paper";
import { PlaceCard } from "@/components/explore/PlaceCard";
import { MD3ThemeExtended } from "@/constants/Themes";
import { APIPlace, Place } from "@/types/Place";
import { useAnimatedKeyboard } from "react-native-reanimated";
import { useDebouncedCallback } from "use-debounce";
import { useAuth } from "@/app/ctx";
import { API_PLACES_AUTOCOMPLETE } from "@/constants/Endpoints";
import CustomModal from "@/components/CustomModal";
import { RenderItem } from "@/components/RenderItem";
import ActionTextButtons from "@/components/ActionTextButtons";
import { truncateText } from "@/utils/TextUtils";

const convertPlace = (place: APIPlace): Place => {
  const subtitle = [place.city, place.state, place.country]
    .filter(Boolean)
    .join(", ");

  return {
    id: place.providerId,
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

  const [searchQuery, setSearchQuery] = useState("");

  const theme = useTheme() as MD3ThemeExtended;
  const styles = makeStyles(theme);

  const [places, setPlaces] = useState<Place[]>([]);
  const [currentTrips, setCurrentTrips] = useState<any[]>([]); // will change to Trips later (after trips browse merge)
  const [isLoading, setIsLoading] = useState<boolean>(false);
  const [tripModalVisible, setTripModalVisible] = useState(false);

  const [selectedTripId, setSelectedTripId] = useState<string | null>(null);

  useAnimatedKeyboard();

  const fetchPlaces = async (query: string) => {
    try {
      const response = await api!.get(API_PLACES_AUTOCOMPLETE, {
        params: {
          query,
        },
      });

      const parsedData = response.data.map(convertPlace) as Place[];
      setPlaces(parsedData.filter((place) => place.title && place.subtitle));
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
  };

  const handleTripSelection = (item: any) => {
    setSelectedTripId(item.id);
    console.log("Selected trip", item.id);
  };

  const handleAddPress = (place: Place) => {
    console.log("Selected place", place);
    if (tripId) {
      // logic for adding place to trip
    } else {
      setTripModalVisible(true);
    }
    // logic for navigating to trip point add
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

  const renderPlace = ({ item }: { item: Place }) => {
    return (
      <PlaceCard
        place={item}
        handleAddPress={() => {
          handleAddPress(item);
        }}
      />
    );
  };

  useEffect(() => {
    if (!tripId) {
      fetchCurrentTrips();
    }
  }, [tripId]);

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
          keyExtractor={(item) => item.id}
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