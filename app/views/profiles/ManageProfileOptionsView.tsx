/* eslint-disable prettier/prettier */
import ActionTextButtons from "@/components/ActionTextButtons";
import CustomModal from "@/components/CustomModal";
import { DELETE_ICON, STAR_ICON, STAR_OUTLINE_ICON } from "@/constants/Icons";
import { MD3ThemeExtended } from "@/constants/Themes";
import {
  Category,
  Condition,
  ProfileType,
  EditProfileRequest,
} from "@/types/Profile";
import { useFocusEffect, useLocalSearchParams, useNavigation, useRouter } from "expo-router";
import React, { useCallback, useEffect, useLayoutEffect, useMemo, useState } from "react";
import { SafeAreaView, StyleSheet, TouchableOpacity, View } from "react-native";
import { useTheme, Text } from "react-native-paper";
import ProfileOptionsList from "@/components/ProfileOptionsList";
import Icon from "react-native-vector-icons/MaterialIcons";
import { useEditProfile, useGetFavouriteProfiles, useGetProfile } from "@/composables/useProfiles";
import LoadingView from "../LoadingView";
import { useSnackbar } from "@/context/SnackbarContext";
import { API_CATEGORY_PROFILES, API_CONDITION_PROFILES, API_FAVOURITE_CATEGORY_PROFILE, API_FAVOURITE_CONDITION_PROFILE } from "@/constants/Endpoints";
import { useAuth } from "@/app/ctx";
import ActionButtons from "@/components/ActionButtons";

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

  const [isModalVisible, setIsModalVisible] = useState(false);
  const [selectedIds, setSelectedIds] = useState<string[]>([]);
  const [loading, setLoading] = useState<boolean>(false);
  const [error, setError] = useState<string>("");

  const { profile_id } = useLocalSearchParams();

  const { api } = useAuth();

  const { profile, loading: fetchLoading, error: fetchError } = useGetProfile(profileType, profile_id as string);

  const editRequest: EditProfileRequest = useMemo(() => {
    if (!profile) return {} as EditProfileRequest;
    return profileType === "Category"
      ? {...profile, profileType, categoryIds: selectedIds}
      : {...profile, profileType, conditionIds: selectedIds};
  }, [profile, profileType, selectedIds]);

  const {editProfile, loading: editLoading, error: editError} = useEditProfile(editRequest, {immediate: false})

  const {
    favouriteProfiles,
    error: favouritesError,
    refetch: refetchFavourites,
  } = useGetFavouriteProfiles();

  const hideModal = () => setIsModalVisible(false);

  const showRemovalModal = () => setIsModalVisible(true);

  const getSelectedItems = useCallback((): string[] => {
    if (!profile) return [];
  
    if (profileType === "Category" && "categories" in profile) {
      return (profile.categories as Category[]).map((item: Category) => item.id);
    } else if (profileType === "Condition" && "conditions" in profile) {
      return (profile.conditions as Condition[]).map((item: Condition) => item.id);
    }
  
    return [];
  }, [profile, profileType]);

  useFocusEffect(
    useCallback(() => {
      const items = getSelectedItems();
      setSelectedIds(items);
    }, [getSelectedItems]),
  );

  const toggleFavourite = useCallback(async () => {
    const endpoint =
      profileType === "Category"
        ? `${API_FAVOURITE_CATEGORY_PROFILE}/${profile?.id}`
        : `${API_FAVOURITE_CONDITION_PROFILE}/${profile?.id}`;
    try {
      if (profile?.id === favouriteProfiles[profileType]) await api!.delete(endpoint, {});
      else await api!.post(endpoint, {});
    } catch (err: any) {
      console.log(err.response.data);
    }
    await refetchFavourites();
  }, [profile, favouriteProfiles, profileType]);

  useEffect(() => {
    setLoading(fetchLoading || editLoading || false)
  }, [fetchLoading, editLoading])
  
  useEffect(() => {
    setError(fetchError || editError || favouritesError || "")
  }, [fetchError, editError, favouritesError])

  const deleteProfile = useCallback(async () => {
    const endpoint =
        profileType === "Category"
          ? `${API_CATEGORY_PROFILES}/${profile?.id}`
          : `${API_CONDITION_PROFILES}/${profile?.id}`;
    try {
        await api!.delete(endpoint, {});
        hideModal();
        navigation.goBack();
    } catch (err: any) {
        showSnackbar("Wystąpił błąd podczas usuwania profilu!", "error");
    }
}, [profile, profileType, hideModal, navigation]);

  const handleEditProfile = async () => {
    hideModal();
    await editProfile();
    navigation.goBack();
  }

  const menuActions = useMemo(() => {
    const isFavourite = profile?.id === favouriteProfiles[profileType];
    return [
      {
        title: isFavourite ? "Usuń z ulubionych" : "Ustaw jako ulubiony",
        icon: isFavourite ? STAR_OUTLINE_ICON : STAR_ICON,
        color: theme.colors.onSurface,
        onPress: toggleFavourite,
      },
      {
        title: "Usuń",
        icon: DELETE_ICON,
        color: theme.colors.error,
        onPress: showRemovalModal,
      },
    ];
  }, [profile?.id, favouriteProfiles, profileType, toggleFavourite, showRemovalModal, deleteProfile]);
  
  useLayoutEffect(() => {
    navigation.setOptions({
      actions: [{ hasMenu: true, menuActions }],
    });
  }, [navigation, menuActions]);


  const onChange = (id: string) => {
    setSelectedIds((prev) =>
      prev.includes(id) ? prev.filter((selectedId) => selectedId !== id) : [...prev, id]
    );
  };  

  if (loading) return <LoadingView />;

  if (error) {
    router.back();
    showSnackbar(error?.toString() || "Unknown error", "error");
    return null;
  }

  return (
    <SafeAreaView style={styles.container}>
      <View style={styles.favouriteContainer}>
        <Text style={styles.leftText}> {profileType === "Category" ? "Preferencje: " : "Udogodnienia: "}</Text>
        <TouchableOpacity style={styles.rightContainer} onPress={toggleFavourite}>
          <Text style={styles.rightText}>Ulubiony</Text>
          <Icon name={profile?.id === favouriteProfiles[profileType] ? STAR_ICON : STAR_OUTLINE_ICON} size={20} color={theme.colors.onSurface} />
        </TouchableOpacity>
      </View>
      <ProfileOptionsList
        selectedIds={selectedIds}
        profileType={profileType}
        onChange={onChange}
      />
      <ActionButtons
        onAction1={navigation.goBack}
        action1ButtonLabel="Anuluj"
        action1Icon={undefined}
        onAction2={handleEditProfile}
        action2ButtonLabel="Zapisz"
        action2Icon={undefined}
      />
      <CustomModal visible={isModalVisible} onDismiss={hideModal}>
        <View>
          <Text style={styles.modalTitleText}>
            Czy na pewno chcesz usunąć profil?
          </Text>
          <ActionTextButtons
            onAction1={hideModal}
            onAction2={deleteProfile}
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
