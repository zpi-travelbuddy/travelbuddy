import {
  FlatList,
  StyleSheet,
  View,
  TouchableWithoutFeedback,
  Keyboard,
} from "react-native";
import { useEffect, useMemo, useState } from "react";
import {
  MD3Theme,
  Searchbar,
  useTheme,
  Text,
  ActivityIndicator,
} from "react-native-paper";
import { RenderItem } from "@/components/RenderItem";
import ActionButtons from "@/components/ActionButtons";
import { router, useLocalSearchParams } from "expo-router";
import { useAuth } from "@/app/ctx";
import { Currency, APICurrency } from "@/types/Currency";
import { API_CURRENCY } from "@/constants/Endpoints";

const SelectCurrencyView = () => {
  const { api } = useAuth();

  const theme = useTheme();
  const styles = createStyles(theme);

  const [currencies, setCurrencies] = useState<Currency[]>([]);
  const { currency } = useLocalSearchParams<{ currency: string }>();

  const [isLoading, setIsLoading] = useState<boolean>(false);

  const [searchQuery, setSearchQuery] = useState("");
  const [selectedCurrency, setSelectedCurrency] = useState<string>(currency);

  useEffect(() => {
    const fetchCurrencies = async () => {
      setIsLoading(true);
      try {
        const response = await api!.get(API_CURRENCY);
        const parsedCurrencies = response.data.map((currency: APICurrency) => ({
          name: currency.name,
          id: currency.code,
        })) as Currency[];
        parsedCurrencies.sort((a, b) => a.id.localeCompare(b.id));
        setCurrencies(parsedCurrencies);
      } catch (error) {
        console.error(error);
      } finally {
        setIsLoading(false);
      }
    };

    fetchCurrencies();
  }, []);

  const filteredCurrencies = useMemo(() => {
    return currencies.filter((currency) =>
      currency.name.toLowerCase().includes(searchQuery.toLowerCase()),
    );
  }, [searchQuery, currencies]);

  const renderCurrencyContent = (item: Currency) => `[${item.id}] ${item.name}`;

  const renderCurrency = ({ item }: { item: Currency }) => (
    <RenderItem
      item={item}
      isSelected={selectedCurrency === item.id}
      onSelect={(item) => setSelectedCurrency(item.id)}
      renderContent={renderCurrencyContent}
    />
  );

  const handleCancel = () => {
    router.back();
  };

  const handleConfirm = () => {
    router.back();
    router.setParams({ currency: selectedCurrency });
  };

  return (
    <TouchableWithoutFeedback onPress={Keyboard.dismiss}>
      <View style={styles.container}>
        <Searchbar
          value={searchQuery}
          onChangeText={setSearchQuery}
          placeholder="Wyszukaj walutę"
          style={styles.searchbar}
        />
        <FlatList
          style={styles.scrollView}
          contentContainerStyle={styles.container}
          data={filteredCurrencies}
          renderItem={renderCurrency}
          keyExtractor={(item) => item.id}
          ListEmptyComponent={
            isLoading ? (
              <ActivityIndicator
                style={styles.loadingIndicator}
                animating={true}
                size="large"
                color={theme.colors.primary}
              />
            ) : (
              <Text style={styles.emptyMessage}>Nie znaleziono walut</Text>
            )
          }
        />

        <ActionButtons
          onAction1={handleCancel}
          onAction2={handleConfirm}
          action1ButtonLabel="Anuluj"
          action2ButtonLabel="Zapisz"
          action1Icon={undefined}
          action2Icon={undefined}
        />
      </View>
    </TouchableWithoutFeedback>
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
      marginHorizontal: 20,
    },
    emptyMessage: {
      textAlign: "center",
      marginTop: 20,
      color: theme.colors.onSurface,
    },
    loadingIndicator: { margin: "auto" },
  });
