import { Dimensions, StyleSheet, Text, View } from "react-native";
import React from "react";
import { Button, MD3Theme, useTheme } from "react-native-paper";
import IconComponent from "./IconComponent";
import { DEFAULT_ICON_SIZE } from "@/constants/Icons";
import {
  CategoryIcons,
  CategoryLabels,
  DEFAULT_CATEGORY_NAME,
} from "@/types/Profile";
import { Category } from "@/types/TripDayData";

interface TripPointCategoryPickerProps {
  selectedCategory: Category | undefined;
  onPress: () => void;
  disabled?: boolean;
}

const { width } = Dimensions.get("window");

const TripPointTypePicker: React.FC<TripPointCategoryPickerProps> = ({
  selectedCategory,
  onPress,
  disabled = false,
}) => {
  const theme = useTheme();
  const styles = createStyles(theme);
  const iconName =
    CategoryIcons[selectedCategory?.name || DEFAULT_CATEGORY_NAME];
  return (
    <>
      <Text style={styles.header}>Rodzaj punktu wycieczki</Text>
      <View style={styles.rowContainer}>
        <View style={styles.leftContainer}>
          <IconComponent
            source={iconName}
            iconSize={DEFAULT_ICON_SIZE}
            color={theme.colors.onSurface}
            backgroundColor={theme.colors.primaryContainer}
          />
          <Text style={styles.label}>
            {CategoryLabels[selectedCategory?.name || DEFAULT_CATEGORY_NAME]}
          </Text>
        </View>
        <Button
          mode="outlined"
          disabled={disabled}
          style={styles.button}
          onPress={onPress}
        >
          Wybierz
        </Button>
      </View>
    </>
  );
};

export default TripPointTypePicker;

const createStyles = (theme: MD3Theme) =>
  StyleSheet.create({
    header: {
      width: 0.85 * width,
      marginTop: 15,
      color: theme.colors.onBackground,
    },
    label: {
      ...theme.fonts.bodyLarge,
      marginLeft: 10,
      textAlign: "center",
      color: theme.colors.onBackground,
    },
    rowContainer: {
      flexDirection: "row",
      justifyContent: "space-between",
      alignItems: "center",
      width: "90%",
      marginVertical: 10,
    },
    leftContainer: {
      flexDirection: "row",
      alignItems: "center",
      flex: 3,
      marginLeft: 10,
    },
    button: {
      marginVertical: 10,
      marginHorizontal: 10,
      flex: 2,
    },
  });
