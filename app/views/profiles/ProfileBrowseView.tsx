import {
  ActivityIndicator,
  FlatList,
  RefreshControl,
  StyleSheet,
  Text,
  View,
} from "react-native";
import React, { useCallback, useRef, useState } from "react";
import { MD3ThemeExtended } from "@/constants/Themes";
import { router } from "expo-router";
import { GestureHandlerRootView } from "react-native-gesture-handler";
import { useTheme, FAB, MD3Theme } from "react-native-paper";
import { useGetCategoryProfiles } from "@/composables/useProfiles";
import { Profile } from "@/types/Profile";
import ProfileCard from "@/components/ProfileCard";
import BottomSheet from "@gorhom/bottom-sheet";
import CreatingProfileBottonSheet from "@/components/CreatingProfileBottomSheet";

const ProfileBrowseView = () => {
  const theme = useTheme();
  const styles = createStyles(theme as MD3ThemeExtended);

  const id = "123-456-789-000";
  const loading = false;

  const [isBottomSheetVisible, setIsBottomSheetVisible] =
    useState<boolean>(false);

  const [refreshing, setRefreshing] = useState<boolean>(false);
  const [favourites, setFavourites] = useState<Profile[]>([]);

  //   const {
  //     profiles,
  //     loading,
  //     error,
  //     refetch: fetchCategoryProfiles,
  //   } = useGetCategoryProfiles();

  const profiles = [
    { id: "123-456-789-000", name: "Zwiedzanie i jedzenie" },
    { id: "123-456-789-111", name: "Zamki i inne budowle" },
    { id: "123-456-789-222", name: "Parki i góry" },
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
    router.push(
      `/(auth)/(tabs)/settings/categoryProfiles/manage/${profile.id}`,
    );
  };

  const handleFABClick = () => {
    console.log("FAB clicked");
    setIsBottomSheetVisible(true);
  };

  const handleSave = () => {
    router.push(`/(auth)/(tabs)/settings/categoryProfiles/manage/1234`);
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
          data={profiles}
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
                Nie masz jeszcze żadnych profili preferencji
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
