import { Button, Card } from "react-native-paper";
import { StyleSheet, Image, View } from "react-native";
import { truncateText } from "@/utils/TextUtils";
import { Place } from "@/types/Place";

interface PlaceCardProps {
  place: Place;
  handleAddPress: () => void;
}

export function PlaceCard({ place, handleAddPress }: PlaceCardProps) {
  const { id, title, subtitle } = place;

  const onDetailsPress = () => {
    console.log("Go to attraction's details", id);
    // router.push(...);
  };

  const onAddPress = () => {
    console.log("Go to adding attraction to trip.", id);
    handleAddPress();
  };
  return (
    <Card mode="outlined">
      <View style={styles.headerContainer}>
        <Card.Title
          title={truncateText(title, 50)}
          subtitle={truncateText(subtitle, 50)}
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
