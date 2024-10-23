import * as React from "react";
import { BottomNavigation, useTheme } from "react-native-paper";
import { View, Text, StyleSheet } from "react-native";
import Ionicons from "react-native-vector-icons/Ionicons";
import TripBrowse from "@/views/TripBrowse";

const TripRoute = () => <TripBrowse />;

const ExploreRoute = () => (
  <View>
    <Text>Search</Text>
  </View>
);

const SettingsRoute = () => (
  <View>
    <Text>Profile</Text>
  </View>
);

export const BottomNavigationTabs = () => {
  const theme = useTheme();
  const [index, setIndex] = React.useState(0);
  const [routes] = React.useState([
    { key: "trips", title: "Wycieczki", icon: "location-sharp" },
    { key: "explore", title: "Eksploruj", icon: "search-sharp" },
    { key: "settings", title: "Ustawienia", icon: "settings-sharp" },
  ]);

  const renderScene = BottomNavigation.SceneMap({
    trips: TripRoute,
    explore: ExploreRoute,
    settings: SettingsRoute,
  });

  const renderIcon = ({
    route,
  }: {
    route: { key: string; title: string; icon: string };
  }) => {
    return (
      <Ionicons
        name={route.icon}
        size={24}
        color={theme.colors.onSurfaceVariant}
      />
    );
  };

  const styles = StyleSheet.create({
    bar: {
      backgroundColor: theme.colors.surface,
    },
  });

  return (
    <BottomNavigation
      navigationState={{ index, routes }}
      onIndexChange={setIndex}
      renderScene={renderScene}
      renderIcon={renderIcon}
      barStyle={styles.bar}
    />
  );
};
