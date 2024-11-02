import { Button, Card } from "react-native-paper";
import { StyleSheet, Image, View } from "react-native";
import { useRouter } from "expo-router";
import { truncateText } from "@/utils/TextUtils";

export function PlaceCard({ place }: { place: PlaceView }) {
  const { id, title, subtitle, imageUrl } = place;
  const router = useRouter();

  const onDetailsPress = () => {
    console.log("Go to attraction's details", id);
    // router.push(...);
  };

  const onAddPress = () => {
    console.log("Go to adding attraction to trip.", id);
    // router.push(...);
  };
  return (
    <Card mode="outlined">
      <View style={styles.headerContainer}>
        <Card.Title title={truncateText(title, 25)} subtitle={truncateText(subtitle, 25)} />
        {imageUrl && <Image source={{ uri: imageUrl }} style={styles.image} />}
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
  image: {
    position: "absolute",
    top: 8,
    right: 8,
    width: 100,
    height: 60,
    borderRadius: 20,
  },
});
