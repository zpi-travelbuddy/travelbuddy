import React from "react";
import { View, StyleSheet, Text } from "react-native";
import { MD3Theme, useTheme } from "react-native-paper";

const ActionTextButtons: React.FC<ActionButtonsProps> = ({
  onAction1,
  action1ButtonLabel,
  onAction2,
  action2ButtonLabel,
}) => {
  const theme: MD3Theme = useTheme();
  const action1Label = action2ButtonLabel || "Usuń";
  const action2Label = action1ButtonLabel || "Anuluj";
  const confirmLabelColor = action2ButtonLabel
    ? theme.colors.onBackground
    : theme.colors.error;
  const styles = createStyles(theme);
  return (
    <View style={styles.container}>
      <Text onPress={onAction1} style={styles.text}>
        {action2Label}
      </Text>
      <Text
        onPress={onAction2}
        style={{ ...styles.text, color: confirmLabelColor }}
      >
        {action1Label}
      </Text>
    </View>
  );
};

const createStyles = (theme: MD3Theme) =>
  StyleSheet.create({
    container: {
      flexDirection: "row",
      justifyContent: "flex-end",
      alignItems: "center",
      padding: 10,
      width: "100%",
    },
    text: {
      ...theme.fonts.bodyMedium,
      color: theme.colors.onBackground,
      marginLeft: 30,
    },
  });
export default ActionTextButtons;
