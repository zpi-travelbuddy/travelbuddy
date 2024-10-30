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
      <Card.Title title={title} subtitle={subtitle} />
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
