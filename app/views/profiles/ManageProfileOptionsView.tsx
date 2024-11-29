/* eslint-disable prettier/prettier */
import ActionTextButtons from "@/components/ActionTextButtons";
import CustomModal from "@/components/CustomModal";
import { DELETE_ICON, STAR_ICON, STAR_OUTLINE_ICON } from "@/constants/Icons";
import { MD3ThemeExtended } from "@/constants/Themes";
import {
  Category,
  Condition,
  CategoryProfile,
  ProfileType,
} from "@/types/Profile";
import { useNavigation, useRouter } from "expo-router";
import React, { useLayoutEffect, useState } from "react";
import { SafeAreaView, StyleSheet, TouchableOpacity, View } from "react-native";
import { useTheme, Text } from "react-native-paper";
import ProfileOptionsList from "@/components/ProfileOptionsList";
import Icon from "react-native-vector-icons/MaterialIcons";

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

const conditions: Condition[] = [
  { id: "1", name: "activity", subConditions: [] },
];

interface ManageProfileCategoryViewProps {
  profileType: ProfileType;
}

const ManageProfileCategoryView: React.FC<ManageProfileCategoryViewProps> = ({
  profileType,
}) => {
  const theme = useTheme();
  const styles = createStyles(theme as MD3ThemeExtended);
  const navigation = useNavigation();
  const router = useRouter();

  // const { profile_id } = useLocalSearchParams();

  // const { profile, loading, error, refetch } = useGetProfile(profileType, profile_id);

  const profile: CategoryProfile = {
    id: "123-456-789-000",
    name: "Zwiedzanie",
    categories: [
      { id: "3", name: "entertainment", subCategories: [] },
      { id: "4", name: "heritage", subCategories: [] },
      { id: "5", name: "leisure", subCategories: [] },
    ],
  };

  const favouriteProfileId = "123-456-789-000";

  const [isModalVisible, setIsModalVisible] = useState(false);

  const hideModal = () => setIsModalVisible(false);

  const showRemovalModal = () => setIsModalVisible(true);

  const toggleFavourite = () => {
    console.log("Toggle favourite");
  }

  useLayoutEffect(() => {
    navigation.setOptions({
      actions: [
        {
          hasMenu: true,
          menuActions: [
            {
              title:
                profile.id === favouriteProfileId
                  ? "Usuń z ulubionych"
                  : "Ustaw jako ulubiony",
              icon:
                profile.id === favouriteProfileId
                  ? STAR_OUTLINE_ICON
                  : STAR_ICON,
              color: theme.colors.onSurface,
              onPress: toggleFavourite,
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
      <View style={styles.favouriteContainer}>
        <Text style={styles.leftText}> {profileType === "Category" ? "Preferencje: " : "Udogodnienia"}</Text>
        <TouchableOpacity style={styles.rightContainer} onPress={toggleFavourite}>
          <Text style={styles.rightText}>Ulubiony</Text>
          <Icon name={profile.id === favouriteProfileId ? STAR_ICON : STAR_OUTLINE_ICON} size={20} color={theme.colors.onSurface} />
        </TouchableOpacity>
      </View>
      <ProfileOptionsList
        items={profileType === "Category" ? categories : conditions}
        profile={profile}
        profileType={profileType}
      />
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
    favouriteContainer: {
      flexDirection: 'row',
      justifyContent: 'space-between',
      alignItems: 'center',
      width: '100%',
      padding: 10,
      backgroundColor: theme.colors.surface,
    },
    leftText: {
      ...theme.fonts.bodyLarge,
      color: theme.colors.onSurface,
    },
    rightContainer: {
      flexDirection: 'row',
      alignItems: 'center',
    },
    rightText: {
      ...theme.fonts.bodyLarge,
      color: theme.colors.onSurface,
      marginRight: 5,
    },
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
    modalSubtitle: {
      color: theme.colors.onSurface,
    },
  });

export default ManageProfileCategoryView;
