import { Dimensions, StyleSheet } from "react-native";
import React, { useCallback } from "react";
import { Card, MD3Theme, Text, useTheme } from "react-native-paper";

interface TripCardProps {
  title: string;
  subtitle: string;
  imageUri: string;
  isArchived: boolean;
}

const { width, height } = Dimensions.get("window");
const CARD_WIDTH = width * 0.85;
const CARD_ASPECT_RATIO = 4 / 3;
const CARD_HEIGHT = CARD_WIDTH / CARD_ASPECT_RATIO + 10;

export const TripCard: React.FC<TripCardProps> = ({
  title,
  subtitle,
  imageUri,
  isArchived,
}) => {
  const theme = useTheme();
  const styles = createStyles(theme);

  const handlePress = () => {
    console.log("Go to details!");
  };

  const handleLongPress = () => {
    console.log("Go to trip settings!");
  };

  return (
    <Card
      mode="contained"
      style={styles.card}
      onPress={handlePress}
      onLongPress={handleLongPress}
    >
      <Card.Cover
        style={{ ...styles.image, opacity: isArchived ? 0.25 : 1 }}
        source={{ uri: imageUri }}
      />
      <Card.Content style={styles.textContent}>
        <Text style={{ ...styles.text, ...styles.title }}>{title}</Text>
        <Text style={{ ...styles.text, ...styles.subtitle }}>{subtitle}</Text>
      </Card.Content>
    </Card>
  );
};

const createStyles = (theme: MD3Theme) =>
  StyleSheet.create({
    image: {
      width: "100%",
      height: "70%",
      resizeMode: "cover",
      borderBottomLeftRadius: 0,
      borderBottomRightRadius: 0,
    },
    text: {
      alignSelf: "center",
      width: "100%",
    },
    title: {
      ...theme.fonts.titleMedium,
    },
    subtitle: {
      ...theme.fonts.default,
    },
    textContent: {
      marginTop: 10,
      height: "30%",
    },
    card: {
      width: CARD_WIDTH,
      height: CARD_HEIGHT,
      alignSelf: "center",
      marginVertical: 10,
      borderWidth: 1,
      borderColor: theme.colors.outlineVariant,
      backgroundColor: theme.colors.surfaceVariant,
    },
  });
