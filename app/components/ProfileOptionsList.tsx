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

const categories: Category[] = [
  {
    id: "6a5b1b6d-a6f7-41fb-8277-00756aba33bb",
    name: "activity",
    subCategories: [],
  },
  {
    id: "7c938f9f-4edb-427c-9820-d35cf87d029d",
    name: "commercial",
    subCategories: [],
  },
  {
    id: "b313ba91-7573-434e-9b17-3afb7f14d2ac",
    name: "entertainment",
    subCategories: [],
  },
  {
    id: "e1198615-570f-4b90-b9fc-5dbf87925416",
    name: "heritage",
    subCategories: [],
  },
  {
    id: "077b8a92-baf0-4a35-894e-ea3942cb5412",
    name: "leisure",
    subCategories: [],
  },
  {
    id: "4b94397a-d6d8-4811-9c00-5b1392618373",
    name: "natural",
    subCategories: [],
  },
  {
    id: "d0ee8558-9c05-4bf8-a0a3-ad304a3762d3",
    name: "national_park",
    subCategories: [],
  },
  {
    id: "5021f3f6-7922-4bc2-85a9-a0df2b49d1a9",
    name: "tourism",
    subCategories: [],
  },
  {
    id: "ee552c9a-2a04-4618-9480-9da2e0652f23",
    name: "religion",
    subCategories: [],
  },
  {
    id: "3a1a34f2-c8b6-4950-96ad-0c513a972ee9",
    name: "sport",
    subCategories: [],
  },
  {
    id: "912c5bf7-21e7-4b63-a599-58ed6e860967",
    name: "catering",
    subCategories: [],
  },
];

const conditions: Condition[] = [
  { id: "1", name: "activity", subConditions: [] },
];

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
  selectedIds: string[];
  onChange: (id: string) => void;
}

const ProfileOptionsList: React.FC<ProfileListProps> = ({
  profileType,
  selectedIds,
  onChange,
}) => {
  const theme = useTheme();
  const styles = createStyles(theme as MD3ThemeExtended);

  const renderItem = ({ item }: { item: Category | Condition }) => {
    const isSelected = selectedIds.includes(item.id);
    const label =
      profileType === "Category" ? categoryLabels[item.name] : item.name;

    return (
      <TouchableOpacity style={styles.item} onPress={() => onChange(item.id)}>
        <Checkbox
          status={isSelected ? "checked" : "unchecked"}
          onPress={() => onChange(item.id)}
          color={theme.colors.primary}
        />
        <Text style={styles.itemText}>{label}</Text>
      </TouchableOpacity>
    );
  };

  return (
    <FlatList
      data={profileType === "Category" ? categories : conditions}
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
