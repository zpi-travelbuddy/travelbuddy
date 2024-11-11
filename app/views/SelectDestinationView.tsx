import { useState } from "react";
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

const DestinationCard = ({ destination }: { destination: Destination }) => {
  const { id, name, country } = destination;

  const handleSelect = () => {
    router.back();
    router.setParams({ destinationId: id, destinationName: name });
  };

  return (
    <Card mode="outlined" onPress={handleSelect}>
      <Card.Title title={name} subtitle={country} />
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
    setIsLoading(true);
    try {
      const response = await api!.get(API_AUTOCOMPLETE_DESTINATION, {
        params: {
          query,
        },
      });
      const parsedData = response.data.map((destination: APIDestination) => ({
        id: destination.providerId,
        name: destination.city || destination.name,
        country: destination.country,
      })) as Destination[];
      setDestinations(parsedData);
    } catch (error) {
      console.error(error);
    } finally {
      setIsLoading(false);
    }
  };

  const debouncedFetchDestinations = useDebouncedCallback(
    async (query: string) => {
      if (query.length > 2) {
        await fetchDestinations(query);
      }
    },
    800,
  );

  const handleChangeQuery = (query: string) => {
    setDestinations([]);
    setSearchQuery(query);
    debouncedFetchDestinations(query);
  };

  const EmptyListComponent = () => (
    <Text style={styles.emptyText} variant="bodyLarge">
      {searchQuery
        ? "Brak wyników wyszukiwania"
        : "Użyj wyszukiwania aby przeglądać dostępne cele podróży"}
    </Text>
  );

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
      backgroundColor: theme.colors.background,
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
