import { Dimensions, StyleSheet } from "react-native";
import React, { useCallback } from "react";
import { Card, MD3Theme, Text, useTheme } from "react-native-paper";

interface TripCardProps {
  title: string;
  subtitle: string;
  imageUri: string;
  isArchived: boolean;
}

const { width } = Dimensions.get("window");

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
      marginVertical: 10,
      width: width * 0.85,
    },
    card: {
      width: width * 0.85,
      height: 265,
      alignSelf: "center",
      marginVertical: 10,
      borderWidth: 1,
      borderColor: theme.colors.outlineVariant,
      backgroundColor: theme.colors.surfaceVariant,
    },
  });
