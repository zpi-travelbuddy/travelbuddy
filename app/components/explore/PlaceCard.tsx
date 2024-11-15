/* eslint-disable react/prop-types */
import { Button, Card } from "react-native-paper";
import { StyleSheet, Image, View } from "react-native";
import { formatAddress, truncateText } from "@/utils/TextUtils";
import { PlaceViewModel } from "@/types/Place";

interface PlaceCardProps {
  place: PlaceViewModel;
  onDetailsClick: (id: string) => void;
}

export const PlaceCard: React.FC<PlaceCardProps> = ({
  place,
  onDetailsClick,
}) => {
  const { id, name, address, imageUrl } = place;

  const onDetailsPress = () => {
    onDetailsClick(id);
  };

  const onAddPress = () => {
    console.log("Go to adding attraction to trip.", id);
    // router.push(...);
  };
  return (
    <Card mode="outlined">
      <View style={styles.headerContainer}>
        <Card.Title
          title={truncateText(name, 25)}
          subtitle={truncateText(formatAddress(address), 25)}
        />
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
};

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
