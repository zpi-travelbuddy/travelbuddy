import { Dimensions, StyleSheet } from "react-native";
import React from "react";
import { Card, useTheme } from "react-native-paper";
import { useNavigation } from "@react-navigation/native";

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
  const navigation = useNavigation();
  const styles = StyleSheet.create({
    card: {
      width: screenWidth * 0.9,
      height: screenHeight * 0.25,
      backgroundColor: theme.colors.background,
      borderColor: theme.colors.outlineVariant,
      borderWidth: 1,
      borderRadius: 20,
      overflow: "hidden",
      elevation: 0,
      shadowOpacity: 0,
      marginTop: 10,
      marginBottom: 10,
      marginHorizontal: 20,
    },
    cardCover: {
      borderBottomLeftRadius: 0,
      borderBottomRightRadius: 0,
      height: "70%",
    },
  });

  return (
    <Card
      mode="outlined"
      style={styles.card}
      onPress={() => navigation.navigate("TripDetails")}
      onLongPress={() => console.log("Karta kliknięta long press!")}
    >
      <Card.Cover source={{ uri: imageUri }} style={styles.cardCover} />
      <Card.Title title={title} subtitle={subtitle} />
    </Card>
  );
};
