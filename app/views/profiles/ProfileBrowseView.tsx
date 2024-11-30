import {
  ActivityIndicator,
  FlatList,
  StyleSheet,
  Text,
  View,
  Keyboard,
} from "react-native";
import React, {
  useCallback,
  useEffect,
  useMemo,
  useRef,
  useState,
} from "react";
import { MD3ThemeExtended } from "@/constants/Themes";
import { router, useFocusEffect } from "expo-router";
import { GestureHandlerRootView } from "react-native-gesture-handler";
import { useTheme, FAB, MD3Theme } from "react-native-paper";
import {
  CreateProfileRequest,
  Profile,
  ProfileDetails,
  ProfileType,
} from "@/types/Profile";
import ProfileCard from "@/components/ProfileCard";
import CreatingProfileBottonSheet from "@/components/CreatingProfileBottomSheet";
import ActionMenuBottomSheet from "@/components/ActionMenu/ActionMenuBottomSheet";
import {
  DELETE_ICON,
  STAR_OUTLINE_ICON,
  STAR_ICON,
  ADD_ICON,
} from "@/constants/Icons";
import CustomModal from "@/components/CustomModal";
import ActionTextButtons from "@/components/ActionTextButtons";
import {
  useDynamicProfiles,
  useGetFavouriteProfiles,
} from "@/composables/useProfiles";
import { useSnackbar } from "@/context/SnackbarContext";
import {
  API_CATEGORY_PROFILES,
  API_CONDITION_PROFILES,
} from "@/constants/Endpoints";
import { useAuth } from "@/app/ctx";

interface ProfileBrowseViewProps {
  profileType: ProfileType;
}

const ProfileBrowseView: React.FC<ProfileBrowseViewProps> = ({
  profileType,
}) => {
  const theme = useTheme();
  const styles = createStyles(theme as MD3ThemeExtended);
  const { showSnackbar } = useSnackbar();
  const { api } = useAuth();

  const [isBottomSheetVisible, setIsBottomSheetVisible] =
    useState<boolean>(false);
  const [isActionMenuVisible, setIsActionMenuVisible] =
    useState<boolean>(false);
  const [isModalVisible, setIsModalVisible] = useState<boolean>(false);
  const [selectedProfile, setSelectedProfile] = useState<Profile | null>(null);

  const [path, setPath] = useState<string>("");

  useEffect(() => {
    if (profileType === "Category")
      setPath(`/(auth)/(tabs)/settings/categoryProfiles/manage`);
    else setPath(`/(auth)/(tabs)/settings/conditionProfiles/manage`);
  }, [profileType]);

  const {
    profiles,
    loading: loadingProfiles,
    error: loadingProfilesError,
    refetch,
  } = useDynamicProfiles(profileType);

  const {
    favouriteProfiles,
    loading: loadingFavouritesLoading,
    error: loadingFavouritesError,
    refetch: refetchFavourites,
  } = useGetFavouriteProfiles();

  useFocusEffect(
    useCallback(() => {
      refetch();
      refetchFavourites();
    }, [refetch, refetchFavourites, profileType]),
  );

  const [loading, setLoading] = useState<boolean>(false);
  const [error, setError] = useState<string>("");

  useEffect(() => {
    setLoading(loadingFavouritesLoading || loadingProfiles || false);
  }, [loadingFavouritesLoading, loadingProfiles]);

  useEffect(() => {
    setError(loadingFavouritesError || loadingProfilesError || "");
  }, [loadingFavouritesError, loadingProfilesError]);

  useEffect(() => {
    if (error) showSnackbar(error);
  }, [error]);

  useEffect(() => {
    if (selectedProfile) console.log(selectedProfile);
  }, [selectedProfile]);

  const flatListRef = useRef<FlatList>(null);

  const renderProfileCard = ({ item }: { item: Profile }) => (
    <ProfileCard
      text={item.name}
      showStar={favouriteProfiles[profileType] === item.id}
      onPress={() => handleProfileClick(item)}
      onLongPress={() => handleProfileLongClick(item)}
    />
  );

  const handleProfileClick = (profile: Profile) => {
    console.log("Clicked profile:", profile.name);
    router.push(`${path}/${profile.id}`);
  };

  const handleProfileLongClick = (profile: Profile) => {
    setSelectedProfile(profile);
    console.log("Long clicked profile:", profile.name);
    setIsActionMenuVisible(true);
  };

  const onCloseBottomSheet = () => {
    setIsActionMenuVisible(false);
    if (!isModalVisible) setSelectedProfile(null);
  };

  const handleFABClick = () => {
    console.log("FAB clicked");
    setIsBottomSheetVisible(true);
  };

  const handleCreateProfile = async (
    request: CreateProfileRequest,
    onSuccess?: (profile: ProfileDetails) => void,
  ): Promise<void> => {
    try {
      setLoading(true);
      const endpoint =
        profileType === "Category"
          ? API_CATEGORY_PROFILES
          : API_CONDITION_PROFILES;

      const response = await api!.post<ProfileDetails>(endpoint, request);

      if (!response) {
        showSnackbar("Nie udało się stworzyć profilu.");
        return;
      }

      const newProfile = response.data;
      setSelectedProfile(newProfile);
      showSnackbar("Profil został utworzony!");

      if (onSuccess) onSuccess(newProfile);

    } catch (err: any) {
      console.error(
        "Błąd podczas zapisywania profilu: ",
        JSON.stringify(err.response.data),
      );
      showSnackbar("Nie dodano profilu. " + JSON.stringify(err.response.data));
    } finally {
      setLoading(false);
    }
  };

  const handleSave = useCallback(
    async (name: string) => {
      await handleCreateProfile(
        {
          profileType: profileType,
          name: name,
          categoryIds: [],
          conditionIds: [],
        },
        (newProfile) => {
          router.push(`${path}/${newProfile.id}`);
        },
      );
    },
    [handleCreateProfile, router, path, profileType],
  );

  const deleteProfile = (selectedProfile: Profile | null) => {
    hideModal();
    if (selectedProfile) console.log(`Delete profile ${selectedProfile.name}`);
  };

  const showModal = () => {
    setIsModalVisible(true);
  };

  const hideModal = () => {
    setIsModalVisible(false);
    setSelectedProfile(null);
  };

  const getActionsForSelectedProfile: Action[] = useMemo(() => {
    if (!selectedProfile) return [];
    return [
      {
        label:
          selectedProfile.id === favouriteProfiles[profileType]
            ? "Usuń z ulubionych"
            : "Ustaw jako ulubiony",
        icon:
          selectedProfile.id === favouriteProfiles[profileType]
            ? STAR_OUTLINE_ICON
            : STAR_ICON,
        onPress: () => {
          console.log(`Ulubione`);
          setIsActionMenuVisible(false);
        },
      },
      {
        label: "Usuń profil",
        icon: DELETE_ICON,
        onPress: () => {
          console.log(`Usuń`);
          setIsActionMenuVisible(false);
          showModal();
        },
      },
    ];
  }, [selectedProfile]);

  return (
    <GestureHandlerRootView>
      <View style={styles.container}>
        <FlatList
          ref={flatListRef}
          data={profiles}
          renderItem={renderProfileCard}
          keyExtractor={(item, index) => index.toString()}
          contentContainerStyle={styles.flatListContent}
          showsVerticalScrollIndicator={false}
          ListEmptyComponent={
            loading ? (
              <ActivityIndicator
                style={styles.loadingIndicator}
                animating={true}
                size="large"
                color={theme.colors.primary}
              />
            ) : (
              <View style={styles.emptyContainer}>
                <Text style={styles.emptyMessage}>
                  {profileType === "Category"
                    ? "Nie masz jeszcze żadnych profili preferencji"
                    : "Nie masz jeszcze żadnych profili udogodnień"}
                </Text>
              </View>
            )
          }
        />
        <FAB
          style={styles.fab}
          icon={ADD_ICON}
          color={theme.colors.onPrimary}
          label="Dodaj"
          onPress={handleFABClick}
        />
        <CustomModal visible={isModalVisible} onDismiss={hideModal}>
          <View>
            <Text style={styles.modalTitleText}>
              Czy na pewno chcesz usunąć ten profil?
            </Text>
            <View style={styles.modalContent}>
              <Text style={styles.boldText}>{selectedProfile?.name}</Text>
              <Text style={styles.modalSubtitle}>
                {profileType === "Category"
                  ? "Profil preferencji"
                  : "Profil udogodnień"}
              </Text>
            </View>
            <ActionTextButtons
              onAction1={hideModal}
              onAction2={() => deleteProfile(selectedProfile)}
              action1ButtonLabel="Anuluj"
              action2ButtonLabel="Usuń"
              action1Icon={undefined}
              action2Icon={undefined}
            />
          </View>
        </CustomModal>
      </View>
      <CreatingProfileBottonSheet
        label="Wpisz nazwę nowego profilu"
        isVisible={isBottomSheetVisible}
        onClose={() => {
          setIsBottomSheetVisible(false);
          Keyboard.dismiss();
        }}
        onSave={handleSave}
      />
      <ActionMenuBottomSheet
        headerComponent={() => (
          <Text style={styles.bottomSheetText}>Wybierz opcję</Text>
        )}
        actions={getActionsForSelectedProfile}
        isVisible={isActionMenuVisible}
        onClose={onCloseBottomSheet}
      />
    </GestureHandlerRootView>
  );
};

export default ProfileBrowseView;

const createStyles = (theme: MD3Theme) =>
  StyleSheet.create({
    container: {
      flex: 1,
      backgroundColor: theme.colors.surface,
    },
    flatListContent: {
      flexGrow: 1,
      backgroundColor: theme.colors.surface,
      paddingBottom: 20,
    },
    fab: {
      position: "absolute",
      margin: 16,
      right: 0,
      bottom: 0,
      backgroundColor: theme.colors.primary,
    },
    bottomSheetText: {
      marginBottom: 10,
      marginTop: -10,
      color: theme.colors.onSurface,
      ...theme.fonts.bodyMedium,
    },
    emptyContainer: {
      flex: 1,
      justifyContent: "center",
      alignItems: "center",
    },
    emptyMessage: {
      ...theme.fonts.bodyLarge,
      textAlign: "center",
      marginTop: 20,
      color: theme.colors.onSurface,
    },
    loadingIndicator: { margin: "auto" },
    modalTitleText: {
      ...theme.fonts.titleLarge,
      color: theme.colors.onSurface,
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
