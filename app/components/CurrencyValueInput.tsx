import { Dimensions, StyleSheet, View } from "react-native";
import React, { useMemo, useState } from "react";
import { MD3Theme, TextInput, useTheme } from "react-native-paper";
import {
  formatMoneyToString,
  formatMoneyToNumber,
} from "@/utils/CurrencyUtils";
import ClickableInput from "./ClickableInput";

const { width } = Dimensions.get("window");

interface CurrencyValueInputProps {
  amount: number;
  currency: Currency;
  onAmountChange: (amount: number) => void;
  onCurrencyPress: () => void;
}

const CurrencyValueInput: React.FC<CurrencyValueInputProps> = ({
  amount,
  currency,
  onAmountChange,
  onCurrencyPress,
}) => {
  const theme = useTheme();
  const styles = useMemo(() => createStyles(theme), [theme]);

  const [valueString, setValueString] = useState<string>(
    formatMoneyToString(amount),
  );
  const [budget, setBudget] = useState<number>(amount);

  const handleBudgetChange = (value: string) => {
    setValueString(value);
  };

  const handleBudgetEndEditing = () => {
    const numericValue = formatMoneyToNumber(valueString);
    setBudget(numericValue);
    onAmountChange(numericValue);
    setValueString(formatMoneyToString(numericValue));
  };

  return (
    <View style={styles.row}>
      <TextInput
        mode="outlined"
        style={styles.budgetInput}
        label="Budżet"
        value={valueString}
        onChangeText={handleBudgetChange}
        onEndEditing={handleBudgetEndEditing}
        keyboardType="numeric"
        contentStyle={styles.inputContent}
      />
      <ClickableInput
        label="Waluta"
        value={currency.id}
        onPress={onCurrencyPress}
        touchableStyle={styles.currencyTouchable}
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
      paddingHorizontal: 0.05 * width,
    },
    budgetInput: {
      flex: 0.65,
      backgroundColor: theme.colors.surface,
      marginBottom: 0,
      marginRight: 10,
    },
    inputContent: {
      justifyContent: "center",
    },
    currencyTouchable: {
      flex: 0.3,
      justifyContent: "center",
      height: 35,
      backgroundColor: theme.colors.surface,
    },
  });
