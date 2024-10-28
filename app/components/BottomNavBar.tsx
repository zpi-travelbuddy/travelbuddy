//@ts-nocheck
import { StyleSheet } from "react-native";
import { BottomNavigation, Icon } from "react-native-paper";
import { BottomTabBarProps } from "@react-navigation/bottom-tabs";
import { MD3ThemeExtended } from "@/constants/Themes";
import {
  DEFAULT_NAV_BAR_ICON,
  TRIPS_ICON,
  EXPLORE_ICON,
  SETTINGS_ICON,
} from "@/constants/Icons";

const ICON_SIZE = 24;

// MODIFY SOURCES AND MAPPING IF NEW TAB IS ADDED
const ICON_MAP = {
  trips: TRIPS_ICON,
  explore: EXPLORE_ICON,
  settings: SETTINGS_ICON,
};

export const BottomNavBar = ({
  navigation,
  state,
  theme,
  descriptors,
}: BottomTabBarProps) => {
  const styles = makeStyles(theme);

  const handleTabPress = ({ route }: { route: any }) => {
    const event = navigation.emit({
      type: "tabPress",
      target: route.key,
      canPreventDefault: true,
    });
    if (!event.defaultPrevented) {
      navigation.navigate(route.name, route.params);
    }
  };

  const handleTabLongPress = ({ route }: { route: any }) => {
    navigation.emit({
      type: "tabLongPress",
      target: route.key,
    });
  };

  const renderIcon = ({ route, color }: { route: any; color: string }) => {
    const iconSource = ICON_MAP[route.name] || DEFAULT_NAV_BAR_ICON;
    return <Icon source={iconSource} color={color} size={ICON_SIZE} />;
  };

  const getLabelText = ({ route }: { route: any }) => {
    const { options } = descriptors[route.key];
    return options.tabBarLabel ?? options.title ?? route.title;
  };

  return (
    <BottomNavigation.Bar
      navigationState={state}
      style={styles.bar}
      activeColor={theme.colors.onSurface}
      inactiveColor={theme.colors.onSurfaceVariant}
      onTabPress={handleTabPress}
      onTabLongPress={handleTabLongPress}
      renderIcon={renderIcon}
      getLabelText={getLabelText}
    />
  );
};

const makeStyles = (theme: MD3ThemeExtended) =>
  StyleSheet.create({
    bar: {
      backgroundColor: theme.colors.surfaceContainer,
    },
  });
