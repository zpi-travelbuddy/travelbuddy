import React from "react";
import { View, StyleSheet, Text } from "react-native";
import { MD3Theme, useTheme } from "react-native-paper";

const ActionTextButtons: React.FC<ActionButtonsProps> = ({
  onCancel,
  cancelButtonLabel,
  onConfirm,
  confirmButtonLabel,
}) => {
  const theme: MD3Theme = useTheme();
  const confirmLabel = confirmButtonLabel || "Usuń";
  const cancelLabel = cancelButtonLabel || "Anuluj";
  const confirmLabelColor = confirmButtonLabel
    ? theme.colors.onBackground
    : theme.colors.error;
  const styles = createStyles(theme);
  return (
    <View style={styles.container}>
      <Text onPress={onCancel} style={styles.text}>
        {cancelLabel}
      </Text>
      <Text
        onPress={onConfirm}
        style={{ ...styles.text, color: confirmLabelColor }}
      >
        {confirmLabel}
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
