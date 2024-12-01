import { StyleSheet, View, ViewStyle } from "react-native";
import React, { useState } from "react";
import { Text, useTheme } from "react-native-paper";
import StarRating from "react-native-star-rating-widget";

interface StarRatingDisplayComponentProps {
  rating?: number;
  editable?: boolean;
  style?: ViewStyle;
  onRatingChange?: (rating: number) => void;
}

const StarRatingDisplayComponent: React.FC<StarRatingDisplayComponentProps> = ({
  rating = 5,
  editable = false,
  style,
  onRatingChange,
}) => {
  const [currentRating, setCurrentRating] = useState(rating);
  const theme = useTheme();

  const handleRatingChange = (newRating: number): void => {
    setCurrentRating(newRating);
    if (onRatingChange) onRatingChange(newRating);
  };

  return (
    <View style={StyleSheet.flatten([styles.container, style])}>
      <StarRating
        rating={currentRating}
        onChange={handleRatingChange}
        color={theme.colors.primary}
        starSize={30} // Rozmiar gwiazdek
      />
      <Text variant="titleLarge" style={styles.ratingText}>
        {currentRating ? `(${currentRating.toFixed(1)})` : "Brak"}
      </Text>
    </View>
  );
};

export default StarRatingDisplayComponent;

const styles = StyleSheet.create({
  container: {
    flexDirection: "row",
    alignItems: "center",
  },
  ratingText: {
    marginLeft: 8,
  },
});
