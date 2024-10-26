import { Dimensions, StyleSheet, View } from "react-native";
import React, { useMemo, useState } from "react";
import { MD3Theme, TextInput, useTheme } from "react-native-paper";
import { formatCurrency, formatMoney } from "@/utils/CurrencyUtils";

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
    const numericValue = formatMoney(amount);
    setBudget(numericValue);
    setAmount(formatCurrency(numericValue));
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

      <TextInput
        mode="outlined"
        style={styles.currencyInput}
        label="Waluta"
        value={currency}
        onChangeText={setCurrency}
        onPress={() => console.log("Navigate to currency select")}
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
      marginVertical: 10,
    },
    budgetInput: {
      flex: 0.65,
      marginLeft: 0.05 * width,
      backgroundColor: theme.colors.surface,
    },
    currencyInput: {
      flex: 0.3,
      marginRight: 0.05 * width,
      backgroundColor: theme.colors.surface,
    },
  });
