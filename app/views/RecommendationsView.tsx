import { useAuth } from "@/app/ctx";
import { PlaceCard } from "@/components/explore/PlaceCard";
import { MD3ThemeExtended } from "@/constants/Themes";
import { PlaceCompact, PlaceViewModel } from "@/types/Place";
import { router, useLocalSearchParams } from "expo-router";
import { useEffect, useState } from "react";
import { FlatList, StyleSheet, View } from "react-native";
import { ActivityIndicator, Text, useTheme } from "react-native-paper";

const NO_CATEGORY_PROFILE_MESSAGE =
  "An error occurred while retrieving place recommendations. Category profile not found.";
const NO_CATEGORIES_IN_PROFILE_MESSAGE =
  "An error occurred while retrieving place recommendations. Category profile has no categories.";

interface RecommendationsViewProps {
  tripId: string;
}

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

const RecommendationsView = ({ tripId }: RecommendationsViewProps) => {
  const { api } = useAuth();
  const theme = useTheme();
  const styles = makeStyles(theme as MD3ThemeExtended);
  const { trip_id, day_id, date } = useLocalSearchParams();

  const [recommendations, setRecommendations] = useState<PlaceViewModel[]>([]);
  const [isLoading, setIsLoading] = useState<boolean>(false);
  const [error, setError] = useState<string | null>(null);
  const [refreshing, setRefreshing] = useState<boolean>(false);

  const handleRefresh = async () => {
    setRefreshing(true);
    await fetchRecommendations();
    setRefreshing(false);
  };

  const renderPlace = (item: PlaceViewModel) => {
    const handleDetailsPress = () => {
      router.navigate({
        // @ts-ignore
        pathname: `/trips/place/${item.providerId}`,
        params: {
          trip_id: trip_id,
          day_id: day_id,
          date: date,
        },
      });
    };

    const handleAddPress = () => {
      router.navigate({
        // @ts-ignore
        pathname: `/trips/details/${trip_id}/day/${day_id}/tripPoints/create`,
        params: {
          attractionProviderId: item.providerId,
          date: date,
        },
      });
    };

    return (
      <PlaceCard
        place={item}
        handleDetailsPress={handleDetailsPress}
        handleAddPress={handleAddPress}
      />
    );
  };

  const fetchRecommendations = async () => {
    setIsLoading(true);
    try {
      const response = await api!.get(`/trips/recommendations/${tripId}`);
      const parsedData = response.data.map(convertPlace) as PlaceViewModel[];
      setRecommendations(parsedData);
      setError(null);
    } catch (error: any) {
      console.error(error.response);
      switch (error.response?.data) {
        case NO_CATEGORY_PROFILE_MESSAGE:
          setError("Brak wybranego profilu kategorii");
          break;
        case NO_CATEGORIES_IN_PROFILE_MESSAGE:
          setError("Brak kategorii w profilu");
          break;
        default:
          setError("Błąd podczas pobierania rekomendacji");
          break;
      }
    } finally {
      setIsLoading(false);
    }
  };

  useEffect(() => {
    fetchRecommendations();
  }, []);

  return (
    <View style={styles.container}>
      <FlatList
        data={recommendations}
        renderItem={({ item }) => renderPlace(item)}
        ListEmptyComponent={
          isLoading ? (
            <ActivityIndicator
              style={styles.loadingIndicator}
              animating={true}
              size="large"
              color={theme.colors.primary}
            />
          ) : (
            <Text style={styles.emptyText} variant="bodyLarge">
              {error || "Brak rekomendacji"}
            </Text>
          )
        }
        contentContainerStyle={styles.contentContainer}
        ItemSeparatorComponent={() => <View style={styles.separator} />}
        onRefresh={handleRefresh}
        refreshing={refreshing}
      />
    </View>
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

export default RecommendationsView;
