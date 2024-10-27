import { Dimensions, StyleSheet, View } from "react-native";
import React, { useMemo, useState } from "react";
import { MD3Theme, TextInput, useTheme } from "react-native-paper";
import {
  formatMoneyToString,
  formatMoneyToNumber,
} from "@/utils/CurrencyUtils";
import ClickableInput from "./ClickableInput";

const { width } = Dimensions.get("window");

const CurrencyValueInput = () => {
  const theme = useTheme();
  const styles = useMemo(() => createStyles(theme), [theme]);

  const [amount, setAmount] = useState("");
  const [budget, setBudget] = useState<number | undefined>(undefined);
  const [currency, setCurrency] = useState("");

  const handleBudgetChange = (value: string) => {
    setAmount(value);
  };

  const handleBudgetEndEditing = () => {
    const numericValue = formatMoneyToNumber(amount);
    setBudget(numericValue);
    setAmount(formatMoneyToString(numericValue));
  };

  return (
    <View style={styles.row}>
      <TextInput
        mode="outlined"
        style={styles.budgetInput}
        label="Budżet"
        value={amount}
        onChangeText={handleBudgetChange}
        onEndEditing={handleBudgetEndEditing}
        keyboardType="numeric"
      />

      <ClickableInput
        label="Waluta"
        value={currency}
        onPress={() => console.log("Navigate to currency select")}
        touchableStyle={styles.currencyTouchable}
        inputStyle={styles.currencyInput}
        left={<View />}
      />
    </View>
  );
};

export default CurrencyValueInput;

const createStyles = (theme: MD3Theme) =>
  StyleSheet.create({
    row: {
      flexDirection: "row",
      alignItems: "center",
      justifyContent: "space-between",
      width: "100%",
      marginTop: 10,
    },
    budgetInput: {
      flex: 0.65,
      marginLeft: 0.05 * width,
      backgroundColor: theme.colors.surface,
      marginBottom: 12,
    },
    currencyTouchable: {
      flex: 0.3,
      marginRight: 0.05 * width,
    },
    currencyInput: {
      backgroundColor: theme.colors.surface,
      height: 50,
      marginTop: -10,
    },
  });
