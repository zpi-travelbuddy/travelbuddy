import ActionTextButtons from "@/components/ActionTextButtons";
import CategoryList from "@/components/CategoryList";
import CustomModal from "@/components/CustomModal";
import { EDIT_ICON_MATERIAL, DELETE_ICON } from "@/constants/Icons";
import { MD3ThemeExtended } from "@/constants/Themes";
import { Category, CategoryProfile } from "@/types/Profile";
import {
  router,
  useLocalSearchParams,
  useNavigation,
  useRouter,
} from "expo-router";
import React, { useLayoutEffect, useState } from "react";
import { SafeAreaView, StyleSheet, View } from "react-native";
import { useTheme, Text } from "react-native-paper";

const categories: Category[] = [
  { id: "1", name: "activity", subCategories: [] },
  { id: "2", name: "commercial", subCategories: [] },
  { id: "3", name: "entertainment", subCategories: [] },
  { id: "4", name: "heritage", subCategories: [] },
  { id: "5", name: "leisure", subCategories: [] },
  { id: "6", name: "natural", subCategories: [] },
  { id: "7", name: "national_park", subCategories: [] },
  { id: "8", name: "tourism", subCategories: [] },
  { id: "9", name: "religion", subCategories: [] },
  { id: "10", name: "sport", subCategories: [] },
  { id: "11", name: "catering", subCategories: [] },
];

const ManageProfileCategoryView = () => {
  const theme = useTheme();
  const styles = createStyles(theme as MD3ThemeExtended);
  const navigation = useNavigation();
  const router = useRouter();

  // const { profile_id } = useLocalSearchParams();

  const profile: CategoryProfile = {
    id: "123-456-789-000",
    name: "Zwiedzanie",
    categories: [
      { id: "3", name: "entertainment", subCategories: [] },
      { id: "4", name: "heritage", subCategories: [] },
      { id: "5", name: "leisure", subCategories: [] },
    ],
  };

  const [isModalVisible, setIsModalVisible] = useState(false);

  const hideModal = () => setIsModalVisible(false);

  const showRemovalModal = () => setIsModalVisible(true);

  useLayoutEffect(() => {
    navigation.setOptions({
      actions: [
        {
          hasMenu: true,
          menuActions: [
            {
              title: "Ustaw jako domyślny",
              icon: "star",
              color: theme.colors.onSurface,
              onPress: () => {
                console.log("Favourite");
              },
            },
            {
              title: "Usuń",
              icon: DELETE_ICON,
              color: theme.colors.error,
              onPress: () => {
                showRemovalModal();
              },
            },
          ],
        },
      ],
    });
  }, [navigation]);

  return (
    <SafeAreaView style={styles.container}>
      <Text style={styles.text}> Preferencje: </Text>
      <CategoryList categories={categories} profile={profile} />
      <CustomModal visible={isModalVisible} onDismiss={hideModal}>
        <View>
          <Text style={styles.modalTitleText}>
            Czy na pewno chcesz usunąć profil?
          </Text>
          <ActionTextButtons
            onAction1={hideModal}
            onAction2={() => {
              console.log("Usuwanie profilu");
              hideModal();
              router.back();
              router.setParams({ refresh: "true" });
            }}
            action1ButtonLabel="Anuluj"
            action2ButtonLabel="Usuń"
            action1Icon={undefined}
            action2Icon={undefined}
          />
        </View>
      </CustomModal>
    </SafeAreaView>
  );
};

const createStyles = (theme: MD3ThemeExtended) =>
  StyleSheet.create({
    container: {
      flex: 1,
      backgroundColor: theme.colors.surface,
    },
    text: {
      margin: 10,
    },
    modalTitleText: {
      ...theme.fonts.titleLarge,
      color: theme.colors.onSurface,
      marginBottom: 20,
    },
    modalContent: {
      marginVertical: 20,
    },
    boldText: {
      fontWeight: "bold",
      color: theme.colors.onSurface,
    },
    modalSubtitle: {
      color: theme.colors.onSurface,
    },
  });

export default ManageProfileCategoryView;
