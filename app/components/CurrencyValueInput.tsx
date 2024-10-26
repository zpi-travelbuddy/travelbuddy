import { Dimensions, StyleSheet, View } from "react-native";
import React, { useEffect, useState } from "react";
import { MD3Theme, TextInput, useTheme } from "react-native-paper";
import { formatCurrency, formatMoney } from "@/utils/CurrencyUtils";

const { width } = Dimensions.get("window");

const CurrencyValueInput = () => {
  const theme = useTheme();
  const styles = createStyles(theme);

  const [amount, setAmount] = useState("");
  const [budget, setBudget] = useState<number | undefined>(undefined);
  const [currency, setCurrency] = useState("");

  const handleBudgetChange = (value: string) => {
    setAmount(value);
  };

  return (
    <View style={styles.row}>
      <TextInput
        mode="outlined"
        style={styles.budgetInput}
        label="Budżet"
        value={amount}
        onChangeText={handleBudgetChange}
        onEndEditing={() => {
          const numericValue = formatMoney(amount);
          setBudget(numericValue);
          setAmount(formatCurrency(numericValue));
        }}
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
    },
    currencyInput: {
      flex: 0.3,
      marginRight: 0.05 * width,
    },
  });
