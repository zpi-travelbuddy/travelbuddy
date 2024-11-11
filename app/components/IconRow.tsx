import { BLACK } from "@/constants/Colors";
import { DEFAULT_ICON_SIZE } from "@/constants/Icons";
import React from "react";
import { View, StyleSheet, ViewStyle } from "react-native";
import { Icon } from "react-native-paper";

interface IconRowProps {
  icons: string[];
  size?: number;
  style?: ViewStyle;
  iconColor?: string;
  spacing?: number;
}

const IconRow: React.FC<IconRowProps> = ({
  icons,
  size = DEFAULT_ICON_SIZE,
  style,
  iconColor = BLACK,
  spacing = 8,
}) => {
  return (
    <View style={[styles.container, style]}>
      {icons.map((iconName, index) => (
        <View
          key={index}
          style={[styles.iconContainer, { marginRight: spacing }]}
        >
          <Icon source={iconName} size={size} color={iconColor} />
        </View>
      ))}
    </View>
  );
};

export default IconRow;

const styles = StyleSheet.create({
  container: {
    flexDirection: "row",
    alignItems: "center",
  },
  iconContainer: {
    // margines ustawiany dynamicznie za pomocą props `spacing`
  },
});
