import { Button, Card } from "react-native-paper";
import { StyleSheet, View } from "react-native";
import { formatAddress, truncateText } from "@/utils/TextUtils";
import { PlaceDetails } from "@/types/Place";

interface PlaceCardProps {
  place: PlaceDetails;
  handleAddPress: () => void;
}

export function PlaceCard({ place, handleAddPress }: PlaceCardProps) {
  const onDetailsPress = () => {
    console.log("Go to attraction's details", place.id);
    // router.push(...);
  };

  const onAddPress = () => {
    console.log("Go to adding attraction to trip.", place.id);
    handleAddPress();
  };
  return (
    <Card mode="outlined">
      <View style={styles.headerContainer}>
        <Card.Title
          title={truncateText(place.name, 50)}
          subtitle={truncateText(formatAddress(place), 50)}
        />
      </View>
      <Card.Actions>
        <Button
          icon="information-outline"
          mode="outlined"
          onPress={onDetailsPress}
        >
          Szczegóły
        </Button>
        <Button icon="plus" onPress={onAddPress}>
          Dodaj
        </Button>
      </Card.Actions>
    </Card>
  );
}

const styles = StyleSheet.create({
  card: {
    marginBottom: 16,
  },
  headerContainer: {
    position: "relative",
  },
});
