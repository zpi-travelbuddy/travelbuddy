import React from "react";
import {
  FlatList,
  StyleSheet,
  Text,
  TouchableOpacity,
  View,
} from "react-native";
import { Checkbox } from "react-native-paper";
import { MD3ThemeExtended } from "@/constants/Themes";
import { useTheme } from "react-native-paper";
import {
  Category,
  CATEGORY_LIST,
  Condition,
  CONDITION_LIST,
  ProfileType,
} from "@/types/Profile";

const categoryLabels: Record<string, string> = {
  catering: "Restauracje",
  activity: "Aktywności",
  commercial: "Sklepy",
  entertainment: "Rozrywka",
  heritage: "Zabytki",
  leisure: "Wypoczynek",
  national_park: "Parki narodowe",
  natural: "Przyroda",
  religion: "Religia",
  sport: "Sport",
  tourism: "Turystyka",
};

const conditionLabels: Record<string, string> = {
  dogs: "Psy dozwolone",
  egg_free: "Bez jajek",
  fee: "Płatne",
  gluten_free: "Bez glutenu",
  halal: "Halal",
  internet_access: "Dostęp do internetu",
  kosher: "Koszerne",
  no_dogs: "Bez psów",
  no_fee: "Bez opłat",
  organic: "Ekologiczne",
  soy_free: "Bez soi",
  sugar_free: "Bez cukru",
  vegetarian: "Wegetariańskie",
  vegan: "Wegańskie",
  wheelchair: "Dostępne dla wózków",
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
      profileType === "Category"
        ? categoryLabels[item.name] || item.name
        : conditionLabels[item.name] || item.name;

    return (
      <TouchableOpacity style={styles.item} onPress={() => onChange(item.id)}>
        <Checkbox
          status={isSelected ? "checked" : "unchecked"}
          onPress={() => onChange(item.id)}
          color={theme.colors.primary}
        />
        <View style={styles.textContainer}>
          <Text style={styles.itemText}>{label}</Text>
        </View>
      </TouchableOpacity>
    );
  };

  return (
    <FlatList
      data={
        profileType === "Category"
          ? CATEGORY_LIST.sort((a, b) => a.name.localeCompare(b.name))
          : CONDITION_LIST.sort((a, b) => a.name.localeCompare(b.name))
      }
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
    textContainer: {
      flex: 1,
      marginLeft: 10,
    },
    itemText: {
      ...theme.fonts.bodyLarge,
      color: theme.colors.onSurface,
      flexWrap: "wrap",
    },
  });

export default ProfileOptionsList;
