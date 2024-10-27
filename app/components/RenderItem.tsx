import React, { useCallback } from "react";
import {
  TouchableOpacity,
  View,
  Text,
  StyleSheet,
  ViewStyle,
  StyleProp,
} from "react-native";
import { MD3Theme, RadioButton, useTheme } from "react-native-paper";

interface RenderItemProps<T> {
  item: T;
  isSelected: boolean;
  onSelect: (item: T) => void;
  renderContent: (item: T) => React.ReactNode;
  styles?: {
    container?: StyleProp<ViewStyle>;
    content?: StyleProp<ViewStyle>;
    text?: StyleProp<ViewStyle>;
  };
}

export const RenderItem = <T extends { id: string }>({
  item,
  isSelected,
  onSelect,
  renderContent,
  styles = {},
}: RenderItemProps<T>) => {
  const theme = useTheme();
  const defaultStyles = createStyles(theme);

  const combinedStyles = {
    ...defaultStyles,
    ...styles,
  };

  const handlePress = useCallback(() => {
    onSelect(item);
  }, [onSelect, item]);

  return (
    <TouchableOpacity style={combinedStyles.card} onPress={handlePress}>
      <View style={combinedStyles.content}>
        <Text style={combinedStyles.text}>{renderContent(item)}</Text>
        <RadioButton
          value={item.id}
          status={isSelected ? "checked" : "unchecked"}
          onPress={handlePress}
        />
      </View>
    </TouchableOpacity>
  );
};

const createStyles = (theme: MD3Theme) =>
  StyleSheet.create({
    text: {
      ...theme.fonts,
      fontSize: 16,
      color: theme.colors.onBackground,
    },
    card: {
      padding: 15,
      backgroundColor: theme.colors.background,
      elevation: 3,
    },
    content: {
      flexDirection: "row",
      justifyContent: "space-between",
      alignItems: "center",
      width: "100%",
    },
  });
