import {
  ActivityIndicator,
  FlatList,
  RefreshControl,
  StyleSheet,
  Text,
  View,
} from "react-native";
import React, { useCallback, useEffect, useRef, useState } from "react";
import { MD3ThemeExtended } from "@/constants/Themes";
import { router } from "expo-router";
import { GestureHandlerRootView } from "react-native-gesture-handler";
import { useTheme, FAB, MD3Theme } from "react-native-paper";
import { Profile, ProfileType } from "@/types/Profile";
import ProfileCard from "@/components/ProfileCard";
import CreatingProfileBottonSheet from "@/components/CreatingProfileBottomSheet";

interface ProfileBrowseViewProps {
  profileType: ProfileType;
}

const ProfileBrowseView: React.FC<ProfileBrowseViewProps> = ({
  profileType,
}) => {
  const theme = useTheme();
  const styles = createStyles(theme as MD3ThemeExtended);

  const id = "123-456-789-000";

  const [isBottomSheetVisible, setIsBottomSheetVisible] =
    useState<boolean>(false);

  const [refreshing, setRefreshing] = useState<boolean>(false);
  const favourites: Profile[] = [];
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
    { id: "123-456-789-111", name: "Jebany weganizm" },
    { id: "123-456-789-222", name: "Dla allaha" },
  ];

  const flatListRef = useRef<FlatList>(null);

  const renderProfileCard = ({ item }: { item: Profile }) => (
    <ProfileCard
      text={item.name}
      showStar={favourites.some((item) => item.id === id)}
      onPress={() => handleProfileClick(item)}
    />
  );

  const handleProfileClick = (profile: Profile) => {
    console.log("Clicked profile:", profile.name);
    router.push(`${path}/${profile.id}`);
  };

  const handleFABClick = () => {
    console.log("FAB clicked");
    setIsBottomSheetVisible(true);
  };

  const handleSave = () => {
    router.push(`${path}/1234`);
  };

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
      </View>
      <CreatingProfileBottonSheet
        label="Wpisz nazwę nowego profilu"
        isVisible={isBottomSheetVisible}
        onClose={() => setIsBottomSheetVisible(false)}
        onSave={handleSave}
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
  });
