import { useCallback, useState } from "react";
import {
  View,
  StyleSheet,
  FlatList,
  TouchableWithoutFeedback,
  Keyboard,
} from "react-native";
import {
  Text,
  useTheme,
  Searchbar,
  Card,
  ActivityIndicator,
} from "react-native-paper";
import { MD3ThemeExtended } from "@/constants/Themes";
import { useAuth } from "@/app/ctx";
import { useDebouncedCallback } from "use-debounce";
import { router } from "expo-router";
import { Destination, APIDestination } from "@/types/Destination";
import { API_AUTOCOMPLETE_DESTINATION } from "@/constants/Endpoints";
import { useAnimatedKeyboard } from "react-native-reanimated";

const DestinationCard = ({ destination }: { destination: Destination }) => {
  const { id, name, country, state } = destination;

  useAnimatedKeyboard();

  const handleSelect = () => {
    router.back();
    router.setParams({ new_destination_id: id, new_destination_name: `${name}, ${country}` });
  };

  return (
    <Card mode="outlined" onPress={handleSelect}>
      <Card.Title
        title={`${name}${state ? `, ${state}` : ""}`}
        subtitle={country}
      />
    </Card>
  );
};

const SelectDestinationView = () => {
  const { api } = useAuth();

  const [destinations, setDestinations] = useState<Destination[]>([]);
  const [isLoading, setIsLoading] = useState<boolean>(false);

  const [searchQuery, setSearchQuery] = useState("");
  const theme = useTheme() as MD3ThemeExtended;
  const styles = makeStyles(theme);

  const fetchDestinations = async (query: string) => {
    try {
      const response = await api!.get(API_AUTOCOMPLETE_DESTINATION, {
        params: {
          query,
        },
      });
      console.log(response.data);
      const parsedData = response.data.map((destination: APIDestination) => ({
        id: destination.providerId,
        name: destination.city || destination.name,
        country: destination.country,
        state: destination.state,
      })) as Destination[];
      setDestinations(parsedData);
    } catch (error) {
      console.error(error);
    }
  };

  const debouncedFetchDestinations = useDebouncedCallback(
    async (query: string) => {
      if (query.length > 2) {
        await fetchDestinations(query);
      }
      setIsLoading(false);
    },
    800,
  );

  const handleChangeQuery = async (query: string) => {
    setDestinations([]);
    setSearchQuery(query);
    setIsLoading(query.length > 2);
    debouncedFetchDestinations(query);
  };

  const EmptyListComponent = useCallback(() => {
    let emptyText = "Brak wyników wyszukiwania";

    if (searchQuery.length < 3) {
      emptyText = "Wpisz co najmniej 3 znaki aby wyszukać miejsce docelowe";
    }

    if (!searchQuery) {
      emptyText = "Użyj wyszukiwania aby przeglądać dostępne cele podróży";
    }

    return (
      <Text style={styles.emptyText} variant="bodyLarge">
        {emptyText}
      </Text>
    );
  }, [searchQuery]);

  const renderPlace = ({ item }: { item: Destination }) => (
    <DestinationCard destination={item} />
  );

  return (
    <TouchableWithoutFeedback onPress={Keyboard.dismiss}>
      <View style={styles.container}>
        <Searchbar
          value={searchQuery}
          onChangeText={handleChangeQuery}
          placeholder="Wyszukaj miejsce docelowe"
          style={styles.searchbar}
        />
        <FlatList
          data={destinations}
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
    </TouchableWithoutFeedback>
  );
};

const makeStyles = (theme: MD3ThemeExtended) =>
  StyleSheet.create({
    contentContainer: {
      paddingBottom: 20,
      marginHorizontal: 20,
    },
    container: {
      flex: 1,
      backgroundColor: theme.colors.surface,
    },
    searchbar: {
      backgroundColor: theme.colors.surfaceContainerHigh,
      marginVertical: 20,
      marginHorizontal: 20,
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
  });

export default SelectDestinationView;
