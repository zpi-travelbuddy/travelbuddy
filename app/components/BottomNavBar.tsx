//@ts-nocheck
import { StyleSheet } from "react-native";
import { BottomNavigation, Icon } from "react-native-paper";
import { BottomTabBarProps } from "@react-navigation/bottom-tabs";

// Icon size
const ICON_SIZE = 24;

// Default icon
const DEFAULT_ICON = "help";

// MODIFY SOURCES AND MAPPING IF NEW TAB IS ADDED

// Icon sources
const TRIPS_ICON = "car";
const EXPLORE_ICON = "compass-outline";
const SETTINGS_ICON = "cog";

// Icon sources mapping
const iconSources = {
  trips: TRIPS_ICON,
  explore: EXPLORE_ICON,
  settings: SETTINGS_ICON,
};

export const BottomNavBar = (props: BottomTabBarProps) => {
  const styles = makeStyles(props.theme);

  return (
    <BottomNavigation.Bar
      navigationState={props.state}
      style={styles.bar}
      activeColor={props.theme.colors.onSurface}
      inactiveColor={props.theme.colors.onSurfaceVariant}
      onTabPress={({ route, preventDefault }) => {
        const event = props.navigation.emit({
          type: "tabPress",
          target: route.key,
          canPreventDefault: true,
        });

        if (!event.defaultPrevented) {
          props.navigation.navigate(route.name, route.params);
        }
      }}
      onTabLongPress={({ route }) => {
        props.navigation.emit({
          type: "tabLongPress",
          target: route.key,
        });
      }}
      renderIcon={({ route, focused, color }) => {
        const source = iconSources[route.name] || DEFAULT_ICON;

        return <Icon source={source} color={color} size={ICON_SIZE} />;
      }}
      getLabelText={({ route }) => {
        const { options } = props.descriptors[route.key];
        const label =
          options.tabBarLabel !== undefined
            ? options.tabBarLabel
            : options.title !== undefined
              ? options.title
              : route.title;

        return label;
      }}
    />
  );
};

const makeStyles = (theme: MD3ThemeExtended) =>
  StyleSheet.create({
    bar: {
      backgroundColor: theme.colors.surfaceContainer,
    },
  });
