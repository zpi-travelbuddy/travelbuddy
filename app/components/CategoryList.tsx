import React, { useEffect, useState } from "react";
import { FlatList, StyleSheet, Text, TouchableOpacity } from "react-native";
import { Checkbox } from "react-native-paper";
import { MD3ThemeExtended } from "@/constants/Themes";
import { useTheme } from "react-native-paper";
import { Category, CategoryProfile } from "@/types/Profile";

const categoryLabels: Record<string, string> = {
  activity: "Aktywności",
  commercial: "Komercja",
  entertainment: "Rozrywka",
  heritage: "Dziedzictwo",
  leisure: "Wypoczynek",
  natural: "Przyroda",
  national_park: "Park Narodowy",
  tourism: "Turystyka",
  religion: "Religia",
  sport: "Sport",
  catering: "Catering",
};

interface CategoryListProps {
  categories: Category[];
  profile?: CategoryProfile;
}

const CategoryList: React.FC<CategoryListProps> = ({ categories, profile }) => {
  const [selectedCategoriesIds, setSelectedCategoriesIds] = useState<string[]>([]);
  const theme = useTheme();
  const styles = createStyles(theme as MD3ThemeExtended);

  const toggleCategory = (id: string) => {
    setSelectedCategoriesIds((prev) =>
      prev.includes(id) ? prev.filter((item) => item !== id) : [...prev, id],
    );
  };

  useEffect(() => {
    if (profile?.categories) {
      setSelectedCategoriesIds(
        profile.categories.map((category) => category.id),
      );
    }
  }, [profile]);

  const renderItem = ({ item }: { item: Category }) => {
    const isSelected = selectedCategoriesIds.includes(item.id);
    const label = categoryLabels[item.name] || item.name;

    return (
      <TouchableOpacity
        style={styles.item}
        onPress={() => toggleCategory(item.id)}
      >
        <Checkbox
          status={isSelected ? "checked" : "unchecked"}
          onPress={() => toggleCategory(item.id)}
          color={theme.colors.primary}
        />
        <Text style={styles.itemText}>{label}</Text>
      </TouchableOpacity>
    );
  };

  return (
    <FlatList
      data={categories}
      renderItem={renderItem}
      keyExtractor={(item) => item.id}
      numColumns={2}
      contentContainerStyle={styles.listContainer}
      columnWrapperStyle={styles.row}
    />
  );
};

const createStyles = (theme: MD3ThemeExtended) =>
  StyleSheet.create({
    listContainer: {
      padding: 10,
      backgroundColor: theme.colors.background,
    },
    row: {
      flex: 1,
      justifyContent: "space-between",
    },
    item: {
      flexDirection: "row",
      alignItems: "center",
      marginVertical: 10,
      flex: 1,
    },
    itemText: {
      ...theme.fonts.bodyLarge,
      marginLeft: 10,
      color: theme.colors.onSurface,
    },
  });

export default CategoryList;
