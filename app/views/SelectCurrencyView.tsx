import { FlatList, StyleSheet, View } from "react-native";
import React, { useMemo, useState } from "react";
import { MD3Theme, Searchbar, useTheme, Text } from "react-native-paper";
import { RenderItem } from "@/components/RenderItem";
import ActionButtons from "@/components/ActionButtons";

interface Currency {
  name: string;
  id: string;
}

const SelectCurrencyView = () => {
  const theme = useTheme();
  const styles = createStyles(theme);

  const [searchQuery, setSearchQuery] = useState("");
  const [selectedCurrency, setSelectedCurrency] = useState<Currency>({
    name: "Polski złoty",
    id: "PLN",
  });
  const [currencies, setCurrencies] = useState<Currency[]>([
    { name: "Polski złoty", id: "PLN" },
    { name: "Euro", id: "EUR" },
    { name: "Dolar amerykański", id: "USD" },
    { name: "Funt szterling", id: "GBP" },
    { name: "Dolar kanadyjski", id: "CAD" },
    { name: "Dolar australijski", id: "AUD" },
    { name: "Frank szwajcarski", id: "CHF" },
    { name: "Yen japoński", id: "JPY" },
    { name: "Won południowokoreański", id: "KRW" },
    { name: "Dolar nowozelandzki", id: "NZD" },
    { name: "Rubel rosyjski", id: "RUB" },
    { name: "Korona czeska", id: "CZK" },
    { name: "Hrywna ukraińska", id: "UAH" },
    { name: "Leu rumuński", id: "RON" },
    { name: "Korona szwedzka", id: "SEK" },
    { name: "Korona duńska", id: "DKK" },
    { name: "Dolar singapurski", id: "SGD" },
    { name: "Baht tajski", id: "THB" },
    { name: "Rial saudyjski", id: "SAR" },
    { name: "Peso meksykańskie", id: "MXN" },
  ]);

  const filteredCurrencies = useMemo(() => {
    return currencies
      .filter((currency) =>
        currency.name.toLowerCase().includes(searchQuery.toLowerCase()),
      )
      .sort((a, b) => a.id.localeCompare(b.id));
  }, [searchQuery, currencies]);

  const renderCurrencyContent = (item: Currency) => `[${item.id}] ${item.name}`;

  const renderCurrency = ({ item }: { item: Currency }) => (
    <RenderItem
      item={item}
      isSelected={selectedCurrency.id === item.id}
      onSelect={setSelectedCurrency}
      renderContent={renderCurrencyContent}
    />
  );

  return (
    <View style={styles.container}>
      <FlatList
        style={styles.scrollView}
        contentContainerStyle={styles.container}
        data={filteredCurrencies}
        renderItem={renderCurrency}
        keyExtractor={(item) => item.id}
        ListHeaderComponent={
          <Searchbar
            value={searchQuery}
            onChangeText={setSearchQuery}
            placeholder="Wyszukaj walutę"
            style={styles.searchbar}
          />
        }
        ListEmptyComponent={
          <Text style={styles.emptyMessage}> Nie znaleziono walut</Text>
        }
      />

      <ActionButtons
        onCancel={() => console.log("Anulowanie")}
        onConfirm={() => console.log("Zapisywanie")}
      />
    </View>
  );
};

export default SelectCurrencyView;

const createStyles = (theme: MD3Theme) =>
  StyleSheet.create({
    scrollView: {
      flex: 1,
      paddingHorizontal: 20,
      paddingBottom: 20,
      backgroundColor: theme.colors.background,
    },
    container: {
      flexGrow: 1,
      flexDirection: "column",
      alignItems: "stretch",
      paddingBottom: 20,
      backgroundColor: theme.colors.background,
    },
    searchbar: {
      backgroundColor: theme.colors.elevation.level3,
      marginVertical: 20,
    },
    emptyMessage: {
      textAlign: "center",
      marginTop: 20,
      color: theme.colors.onSurface, // Użyj koloru tekstu z motywu
    },
  });
