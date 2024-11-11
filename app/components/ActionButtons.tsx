import React from "react";
import { View, StyleSheet } from "react-native";
import { Button } from "react-native-paper";

const ActionButtons: React.FC<ActionButtonsProps> = ({
  onAction1,
  action1ButtonLabel,
  action1Icon,
  onAction2,
  action2ButtonLabel,
  action2Icon,
}) => {
  const action1Label = action1ButtonLabel || "Zapisz";
  const action2Label = action2ButtonLabel || "Anuluj";
  return (
    <View style={styles.buttonContainer}>
      <Button
        icon={action1Icon}
        mode="outlined"
        style={styles.button}
        onPress={onAction1}
      >
        {action1Label}
      </Button>

      <Button
        icon={action2Icon}
        mode="contained"
        style={styles.button}
        onPress={onAction2}
      >
        {action2Label}
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
