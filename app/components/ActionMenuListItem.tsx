import React from "react";
import { TouchableOpacity, StyleSheet } from "react-native";
import { Text, Divider, useTheme } from "react-native-paper";
import Icon from "react-native-vector-icons/MaterialIcons";

type Props = {
  onPress: () => void;
  label: string;
  icon: string;
};

const ActionMenuListItem: React.FC<Props> = ({ onPress, label, icon }) => {
  const theme = useTheme();

  const isDeleteAction = icon === "delete";
  const textColor = isDeleteAction
    ? theme.colors.error
    : theme.colors.onSurface;
  const iconColor = isDeleteAction
    ? theme.colors.error
    : theme.colors.onSurface;

  return (
    <>
      <Divider />
      <TouchableOpacity style={styles.container} onPress={onPress}>
        <Icon name={icon} size={20} color={iconColor} />
        <Text style={[styles.label, { color: textColor }]}>{label}</Text>
      </TouchableOpacity>
    </>
  );
};

const styles = StyleSheet.create({
  container: {
    height: 50,
    flexDirection: "row",
    alignItems: "center",
  },
  label: {
    fontSize: 16,
    marginLeft: 10,
  },
  divider: {
    width: "100%",
    height: 1,
  },
});

export default ActionMenuListItem;
