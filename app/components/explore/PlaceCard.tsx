import { Button, Card } from "react-native-paper";
import { StyleSheet, PixelRatio } from "react-native";
import { MD3ThemeExtended } from "@/constants/Themes";

interface PlaceCardProps {
  title: string;
  subtitle: string;
}

export function PlaceCard({ title, subtitle }: PlaceCardProps) {
  return (
    <Card mode="outlined">
      <View style={styles.headerContainer}>
        <Card.Title
          title={truncateText(title, 25)}
          subtitle={truncateText(subtitle, 25)}
        />
        {imageUrl && <Image source={{ uri: imageUrl }} style={styles.image} />}
      </View>
      <Card.Actions>
        <Button icon="information-outline" mode="outlined">
          Szczegóły
        </Button>
        <Button icon="plus">Dodaj</Button>
      </Card.Actions>
    </Card>
  );
}

const makeStyles = (theme: MD3ThemeExtended) =>
  StyleSheet.create({
    card: {},
  });
