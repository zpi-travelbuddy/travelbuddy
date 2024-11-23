import { StyleSheet, View, ViewStyle } from "react-native";
import React from "react";
import { Text, useTheme } from "react-native-paper";
import { StarRatingDisplay } from "react-native-star-rating-widget";

interface StarRatingDisplayComponentProps {
  rating?: number;
  style?: ViewStyle;
}

const StarRatingDisplayComponent: React.FC<StarRatingDisplayComponentProps> = ({
  rating,
  style,
}) => {
  const theme = useTheme();
  return (
    <View style={StyleSheet.flatten([styles.container, style])}>
      <StarRatingDisplay
        color={rating ? theme.colors.primary : theme.colors.surfaceDisabled}
        rating={rating || 5}
      />
      <Text variant="titleLarge" style={styles.ratingText}>
        {rating ? `(${rating?.toFixed(1)})` : "Brak"}
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
