import React from "react";
import { View, StyleSheet } from "react-native";
import { Icon } from "react-native-paper";

interface IconComponentProps {
  source: string;
  iconSize: number;
  color: string;
  backgroundColor: string;
}

const IconComponent: React.FC<IconComponentProps> = ({
  source,
  iconSize: size,
  color,
  backgroundColor,
}) => {
  const styles = createStyles(2 * size);

  return (
    <View style={[styles.circle, { backgroundColor }]}>
      <Icon source={source} size={size} color={color} />
    </View>
  );
};

const createStyles = (circleSize: number) =>
  StyleSheet.create({
    circle: {
      width: circleSize,
      height: circleSize,
      borderRadius: 1000,
      alignItems: "center",
      justifyContent: "center",
    },
  });

export default IconComponent;
