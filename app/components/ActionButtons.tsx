import React from "react";
import { View, StyleSheet } from "react-native";
import { Button } from "react-native-paper";

const ActionButtons: React.FC<ActionButtonsProps> = ({
  onCancel,
  cancelButtonLabel,
  cancelIcon,
  onConfirm,
  confirmButtonLabel,
  confirmIcon,
}) => {
  const confirmLabel = confirmButtonLabel || "Zapisz";
  const cancelLabel = cancelButtonLabel || "Anuluj";
  return (
    <View style={styles.buttonContainer}>
      <Button
        icon={cancelIcon}
        mode="outlined"
        style={styles.button}
        onPress={onCancel}
      >
        {cancelLabel}
      </Button>

      <Button
        icon={confirmIcon}
        mode="contained"
        style={styles.button}
        onPress={onConfirm}
      >
        {confirmLabel}
      </Button>
    </View>
  );
};

const styles = StyleSheet.create({
  button: {
    marginVertical: 20,
    marginHorizontal: 20,
    flex: 1,
  },
  buttonContainer: {
    flexDirection: "row",
    justifyContent: "space-between",
    alignItems: "center",
    margin: 10,
  },
});

export default ActionButtons;
