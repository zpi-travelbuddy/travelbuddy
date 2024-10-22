import { Dimensions, StyleSheet } from "react-native";
import React from "react";
import { Card, useTheme } from "react-native-paper";

interface TripCardProps {
  title: string;
  subtitle: string;
  imageUri: string;
}

const screenWidth = Dimensions.get("window").width;
const screenHeight = Dimensions.get("window").height;

export const TripCard: React.FC<TripCardProps> = ({
  title,
  subtitle,
  imageUri,
}) => {
  const theme = useTheme();
  const styles = StyleSheet.create({
    card: {
      width: screenWidth * 0.9,
      height: screenHeight * 0.25,
      borderColor: theme.colors.outlineVariant,
      borderWidth: 1,
      borderRadius: 20,
      overflow: "hidden",
      elevation: 0,
      shadowOpacity: 0,
    },
    cardCover: {
      borderBottomLeftRadius: 0,
      borderBottomRightRadius: 0,
      height: "70%",
    },
  });

  return (
    <Card mode="outlined" style={styles.card}>
      <Card.Cover source={{ uri: imageUri }} style={styles.cardCover} />
      <Card.Title title={title} subtitle={subtitle} />
    </Card>
  );
};
