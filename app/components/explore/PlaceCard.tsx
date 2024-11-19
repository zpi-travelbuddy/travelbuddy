import { Button, Card } from "react-native-paper";
import { StyleSheet, View } from "react-native";
import { truncateText } from "@/utils/TextUtils";
import { PlaceCompact } from "@/types/Place";
import { useState, useEffect } from "react";

interface PlaceCardProps {
  place: PlaceCompact;
  handleAddPress: () => void;
}

export function PlaceCard({ place, handleAddPress }: PlaceCardProps) {
  const { id, name: title, country, city } = place;

  const [subtitle, setSubtitle] = useState<string>("");

  useEffect(() => {
    setSubtitle(`${country}, ${city}`);
  }, [place]);

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
