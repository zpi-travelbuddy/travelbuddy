import React from "react";
import { View, StyleSheet, Text } from "react-native";
import { Button, MD3Theme, useTheme } from "react-native-paper";

interface ActionButtonsProps {
  onCancel: () => void;
  onConfirm: () => void;
}

const ActionTextButtons: React.FC<ActionButtonsProps> = ({
  onCancel,
  onConfirm,
}) => {
  const theme: MD3Theme = useTheme();
  const styles = createStyles(theme);
  return (
    <View style={styles.container}>
      <Text onPress={onCancel} style={styles.text}>
        Anuluj
      </Text>
      <Text
        onPress={onConfirm}
        style={{ ...styles.text, color: theme.colors.error }}
      >
        Usuń
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
