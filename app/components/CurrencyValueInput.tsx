import { Dimensions, StyleSheet, View } from "react-native";
import React, { useMemo, useState } from "react";
import { MD3Theme, TextInput, useTheme } from "react-native-paper";
import {
  formatMoneyToString,
  formatMoneyToNumber,
} from "@/utils/CurrencyUtils";
import ClickableInput from "./ClickableInput";
import { router } from "expo-router";

const { width } = Dimensions.get("window");

interface CurrencyValueInputProps {
  budget: number | undefined;
  currency: string;
  handleBudgetChange: (value: number) => void;
  error?: boolean;
}

const CurrencyValueInput = ({
  budget,
  currency,
  handleBudgetChange,
  error,
}: CurrencyValueInputProps) => {
  const theme = useTheme();
  const styles = useMemo(() => createStyles(theme), [theme]);

  const [displayBudget, setDisplayBudget] = useState("");

  const handleChange = (value: string) => {
    setDisplayBudget(value);
  };

  const handleEndEditing = () => {
    const numericValue = formatMoneyToNumber(displayBudget);
    handleBudgetChange(parseFloat(numericValue.toFixed(2)));
    setDisplayBudget(formatMoneyToString(numericValue));
  };

  const handleSelectCurrency = () => {
    router.navigate({ pathname: "/trips/add/currency", params: { currency } });
  };

  return (
    <View style={styles.row}>
      <TextInput
        mode="outlined"
        style={styles.budgetInput}
        label="Budżet"
        value={displayBudget}
        onChangeText={handleChange}
        onEndEditing={handleEndEditing}
        keyboardType="numeric"
        error={error ?? false}
      />
      <ClickableInput
        label="Waluta"
        value={currency}
        onPress={handleSelectCurrency}
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
    },
    budgetInput: {
      flex: 0.65,
      marginLeft: 0.05 * width,
      backgroundColor: theme.colors.surface,
    },
    currencyTouchable: {
      flex: 0.3,
      marginRight: 0.05 * width,
    },
    currencyInput: {
      backgroundColor: theme.colors.surface,
    },
  });
