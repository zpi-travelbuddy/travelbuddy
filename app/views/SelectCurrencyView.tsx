import { FlatList, StyleSheet, TouchableOpacity, View } from "react-native";
import React, { useEffect, useState } from "react";
import {
  MD3Theme,
  RadioButton,
  Searchbar,
  useTheme,
  Text,
} from "react-native-paper";

interface Currency {
  name: string;
  code: string;
}

const SelectCurrencyView = () => {
  const theme = useTheme();
  const styles = createStyles(theme);

  const [searchQuery, setSearchQuery] = useState("");
  const [selectedCurrency, setSelectedCurrency] = useState<Currency>({
    name: "Polski złoty",
    code: "PLN",
  });
  const [currencies, setCurrencies] = useState<Currency[]>([]);

  const renderCurrency = ({ item }: { item: Currency }) => (
    <TouchableOpacity
      style={styles.card}
      onPress={() => setSelectedCurrency(item)}
    >
      <View style={styles.currencyContainer}>
        <Text style={styles.currencyText}>
          [{item.code}] {item.name}
        </Text>
        <RadioButton
          value={item.code}
          status={selectedCurrency.code === item.code ? "checked" : "unchecked"}
          onPress={() => setSelectedCurrency(item)}
        />
      </View>
    </TouchableOpacity>
  );

  useEffect(() => {
    setCurrencies([
      { name: "Polski złoty", code: "PLN" },
      { name: "Euro", code: "EUR" },
      { name: "Dolar amerykański", code: "USD" },
    ]);
  }, []);

  return (
    <View style={styles.container}>
      <Searchbar
        value={searchQuery}
        onChangeText={setSearchQuery}
        placeholder="Wyszukaj walutę"
        style={styles.searchbar}
      />
      <FlatList
        data={currencies}
        renderItem={renderCurrency}
        keyExtractor={(item) => item.code}
        ItemSeparatorComponent={() => <View style={styles.separator} />}
      />
    </View>
  );
};

export default SelectCurrencyView;

const createStyles = (theme: MD3Theme) =>
  StyleSheet.create({
    container: {
      flex: 1,
      flexDirection: "column",
      alignItems: "stretch",
      paddingHorizontal: 20,
      paddingBottom: 20,
      backgroundColor: theme.colors.background,
    },
    searchbar: {
      backgroundColor: theme.colors.elevation.level2,
      marginVertical: 20,
    },
    text: {
      ...theme.fonts,
      textAlign: "center",
    },
    separator: {},
    currencyItem: {
      paddingVertical: 8,
    },
    currencyText: {
      fontSize: 16,
    },
    card: {
      padding: 15,
      backgroundColor: theme.colors.surface,
      elevation: 3,
    },
    currencyContainer: {
      flexDirection: "row",
      justifyContent: "space-between",
      alignItems: "center",
    },
  });
