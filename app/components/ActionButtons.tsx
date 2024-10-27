import React from "react";
import { View, StyleSheet } from "react-native";
import { Button } from "react-native-paper";

interface ActionButtonsProps {
  onCancel: () => void;
  onSave: () => void;
}

const ActionButtons: React.FC<ActionButtonsProps> = ({ onCancel, onSave }) => {
  return (
    <View style={styles.buttonContainer}>
      <Button mode="outlined" style={styles.button} onPress={onCancel}>
        Anuluj
      </Button>

      <Button mode="contained" style={styles.button} onPress={onSave}>
        Zapisz
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
