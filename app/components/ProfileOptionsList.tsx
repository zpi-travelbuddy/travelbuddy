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
import { Category, Condition, ProfileType } from "@/types/Profile";

interface ProfileListProps {
  items: (Category | Condition)[];
  labels: Record<string, string>;
  profileType: ProfileType;
  selectedIds: string[];
  onChange: (id: string) => void;
}

const ProfileOptionsList: React.FC<ProfileListProps> = ({
  items,
  labels,
  selectedIds,
  onChange,
}) => {
  const theme = useTheme();
  const styles = createStyles(theme as MD3ThemeExtended);

  const renderItem = ({ item }: { item: Category | Condition }) => {
    const isSelected = selectedIds.includes(item.id);
    const label = labels[item.name] || item.name;
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
      data={items}
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
      backgroundColor: theme.colors.surface,
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
