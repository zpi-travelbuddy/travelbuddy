import {
  ActivityIndicator,
  FlatList,
  StyleSheet,
  Text,
  View,
  Keyboard,
} from "react-native";
import React, { useEffect, useMemo, useRef, useState } from "react";
import { MD3ThemeExtended } from "@/constants/Themes";
import { router } from "expo-router";
import { GestureHandlerRootView } from "react-native-gesture-handler";
import { useTheme, FAB, MD3Theme } from "react-native-paper";
import { Profile, ProfileType } from "@/types/Profile";
import ProfileCard from "@/components/ProfileCard";
import CreatingProfileBottonSheet from "@/components/CreatingProfileBottomSheet";
import ActionMenuBottomSheet from "@/components/ActionMenu/ActionMenuBottomSheet";
import { DELETE_ICON, STAR_OUTLINE_ICON, STAR_ICON } from "@/constants/Icons";
import CustomModal from "@/components/CustomModal";
import ActionTextButtons from "@/components/ActionTextButtons";

interface ProfileBrowseViewProps {
  profileType: ProfileType;
}

const ProfileBrowseView: React.FC<ProfileBrowseViewProps> = ({
  profileType,
}) => {
  const theme = useTheme();
  const styles = createStyles(theme as MD3ThemeExtended);

  const [isBottomSheetVisible, setIsBottomSheetVisible] =
    useState<boolean>(false);
  const [isActionMenuVisible, setIsActionMenuVisible] =
    useState<boolean>(false);
  const [isModalVisible, setIsModalVisible] = useState<boolean>(false);
  const [selectedProfile, setSelectedProfile] = useState<Profile | null>(null);

  const [refreshing, setRefreshing] = useState<boolean>(false);
  const loading: boolean = false;
  const [path, setPath] = useState<string>("");

  useEffect(() => {
    if (profileType === "Category")
      setPath(`/(auth)/(tabs)/settings/categoryProfiles/manage`);
    else setPath(`/(auth)/(tabs)/settings/conditionProfiles/manage`);
  }, [profileType]);

  // const { profiles, loading, error, refetch } = useDynamicProfiles(profileType);

  const categoryProfiles = [
    { id: "123-456-789-000", name: "Zwiedzanie i jedzenie" },
    { id: "123-456-789-111", name: "Zamki i inne budowle" },
    { id: "123-456-789-222", name: "Parki i góry" },
  ];

  const conditionProfiles = [
    { id: "123-456-789-000", name: "Internet dla psa" },
    { id: "123-456-789-111", name: "Weganizm" },
    { id: "123-456-789-222", name: "Dla allaha" },
  ];

  const [favouriteProfileId, setFavouriteProfileId] =
    useState<string>("123-456-789-000");

  const flatListRef = useRef<FlatList>(null);

  const renderProfileCard = ({ item }: { item: Profile }) => (
    <ProfileCard
      text={item.name}
      showStar={favouriteProfileId === item.id}
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

  const handleSave = () => {
    router.push(`${path}/1234`);
  };

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
          selectedProfile.id === favouriteProfileId
            ? "Usuń z ulubionych"
            : "Ustaw jako ulubiony",
        icon:
          selectedProfile.id === favouriteProfileId
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

  //   const onRefresh = useCallback(async () => {
  //     setRefreshing(true);
  //     await fetchTrips();
  //     setRefreshing(false);
  //   }, []);

  return (
    <GestureHandlerRootView>
      <View style={styles.container}>
        <FlatList
          ref={flatListRef}
          data={
            profileType === "Category" ? categoryProfiles : conditionProfiles
          }
          renderItem={renderProfileCard}
          keyExtractor={(item, index) => index.toString()}
          contentContainerStyle={styles.flatListContent}
          showsVerticalScrollIndicator={false}
          //   refreshControl={
          // <RefreshControl refreshing={refreshing} onRefresh={onRefresh} />
          //   }
          ListEmptyComponent={
            loading ? (
              <ActivityIndicator
                style={styles.loadingIndicator}
                animating={true}
                size="large"
                color={theme.colors.primary}
              />
            ) : (
              <Text style={styles.emptyMessage}>
                {profileType === "Category"
                  ? "Nie masz jeszcze żadnych profili preferencji"
                  : "Nie masz jeszcze żadnych profili udogodnień"}
              </Text>
            )
          }
        />
        <FAB
          style={styles.fab}
          icon="plus"
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
        onClose={() => onCloseBottomSheet()}
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
    emptyMessage: {
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
