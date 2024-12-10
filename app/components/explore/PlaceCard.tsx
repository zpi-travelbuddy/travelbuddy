import { Button, Card } from "react-native-paper";
import { StyleSheet, View } from "react-native";
import { truncateText } from "@/utils/TextUtils";
import { PlaceViewModel } from "@/types/Place";

import { useRouter } from "expo-router";

interface PlaceCardProps {
  place: PlaceViewModel;
  handleAddPress: () => void;
  handleDetailsPress?: () => void;
}

export function PlaceCard({
  place,
  handleAddPress,
  handleDetailsPress,
}: PlaceCardProps) {
  const router = useRouter();

  const onDetailsPress = () => {
    if (handleDetailsPress) {
      handleDetailsPress();
      return;
    }
    console.log("Go to attraction's details", place.providerId);
    router.push(`/explore/place/${place.providerId}`);
  };

  const onAddPress = () => {
    console.log("Go to adding attraction to trip.", place.providerId);
    handleAddPress();
  };
  return (
    <Card mode="outlined">
      <View style={styles.headerContainer}>
        <Card.Title
          title={truncateText(place.title, 50)}
          subtitle={truncateText(place.subtitle, 50)}
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
