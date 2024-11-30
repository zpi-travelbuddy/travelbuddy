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
import { useLocalSearchParams, useNavigation, useRouter } from "expo-router";
import React, { useLayoutEffect, useState } from "react";
import { SafeAreaView, StyleSheet, TouchableOpacity, View } from "react-native";
import { useTheme, Text } from "react-native-paper";
import ProfileOptionsList from "@/components/ProfileOptionsList";
import Icon from "react-native-vector-icons/MaterialIcons";
import { useGetProfile } from "@/composables/useProfiles";
import LoadingView from "../LoadingView";
import { useSnackbar } from "@/context/SnackbarContext";

const categories: Category[] = [
  { id: "6a5b1b6d-a6f7-41fb-8277-00756aba33bb", name: "activity", subCategories: [] },
  { id: "7c938f9f-4edb-427c-9820-d35cf87d029d", name: "commercial", subCategories: [] },
  { id:  "b313ba91-7573-434e-9b17-3afb7f14d2ac", name: "entertainment", subCategories: [] },
  { id:  "e1198615-570f-4b90-b9fc-5dbf87925416", name: "heritage", subCategories: [] },
  { id: "077b8a92-baf0-4a35-894e-ea3942cb5412", name: "leisure", subCategories: [] },
  { id: "4b94397a-d6d8-4811-9c00-5b1392618373", name: "natural", subCategories: [] },
  { id: "d0ee8558-9c05-4bf8-a0a3-ad304a3762d3", name: "national_park", subCategories: [] },
  { id:  "5021f3f6-7922-4bc2-85a9-a0df2b49d1a9", name: "tourism", subCategories: [] },
  { id: "ee552c9a-2a04-4618-9480-9da2e0652f23", name: "religion", subCategories: [] },
  { id: "3a1a34f2-c8b6-4950-96ad-0c513a972ee9", name: "sport", subCategories: [] },
  { id:  "912c5bf7-21e7-4b63-a599-58ed6e860967", name: "catering", subCategories: [] },
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
  const { showSnackbar } = useSnackbar();

  const { profile_id } = useLocalSearchParams();

  const { profile, loading, error, refetch } = useGetProfile(profileType, profile_id as string);

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
                profile?.id === favouriteProfileId
                  ? "Usuń z ulubionych"
                  : "Ustaw jako ulubiony",
              icon:
                profile?.id === favouriteProfileId
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

  if (loading) {
    return <LoadingView />;
  }

  if (error) {
    router.back();
    showSnackbar(error?.toString() || "Unknown error", "error");
    return null;
  }


  return (
    <SafeAreaView style={styles.container}>
      <View style={styles.favouriteContainer}>
        <Text style={styles.leftText}> {profileType === "Category" ? "Preferencje: " : "Udogodnienia"}</Text>
        <TouchableOpacity style={styles.rightContainer} onPress={toggleFavourite}>
          <Text style={styles.rightText}>Ulubiony</Text>
          <Icon name={profile?.id === favouriteProfileId ? STAR_ICON : STAR_OUTLINE_ICON} size={20} color={theme.colors.onSurface} />
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
