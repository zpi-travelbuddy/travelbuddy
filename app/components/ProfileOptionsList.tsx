import React, { useEffect, useState } from "react";
import { FlatList, StyleSheet, Text, TouchableOpacity } from "react-native";
import { Checkbox } from "react-native-paper";
import { MD3ThemeExtended } from "@/constants/Themes";
import { useTheme } from "react-native-paper";
import {
  Category,
  CategoryProfile,
  Condition,
  ConditionProfile,
  ProfileType,
} from "@/types/Profile";

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

interface ProfileListProps {
  profileType: ProfileType;
  profile?: CategoryProfile | ConditionProfile;
  items: (Category | Condition)[];
}

const ProfileOptionsList: React.FC<ProfileListProps> = ({
  profileType,
  profile,
  items,
}) => {
  const [selectedIds, setSelectedIds] = useState<string[]>([]);
  const theme = useTheme();
  const styles = createStyles(theme as MD3ThemeExtended);

  // Funkcja do zaznaczania/odznaczania
  const toggleSelection = (id: string) => {
    setSelectedIds((prev) =>
      prev.includes(id) ? prev.filter((item) => item !== id) : [...prev, id],
    );
  };

  // Ustawienie początkowego stanu na podstawie profilu
  useEffect(() => {
    if (profile) {
      if (profileType === "Category" && "categories" in profile) {
        setSelectedIds(
          profile.categories?.map((category) => category.id) || [],
        );
      } else if (profileType === "Condition" && "conditions" in profile) {
        setSelectedIds(
          profile.conditions?.map((condition) => condition.id) || [],
        );
      }
    }
  }, [profile, profileType]);

  const renderItem = ({ item }: { item: Category | Condition }) => {
    const isSelected = selectedIds.includes(item.id);
    const label =
      profileType === "Category" ? categoryLabels[item.name] : item.name;

    return (
      <TouchableOpacity
        style={styles.item}
        onPress={() => toggleSelection(item.id)}
      >
        <Checkbox
          status={isSelected ? "checked" : "unchecked"}
          onPress={() => toggleSelection(item.id)}
          color={theme.colors.primary}
        />
        <Text style={styles.itemText}>{label}</Text>
      </TouchableOpacity>
    );
  };

  return (
    <FlatList
      data={items} // Przekazujemy odpowiednią tablicę (categories lub conditions)
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

export default ProfileOptionsList;
