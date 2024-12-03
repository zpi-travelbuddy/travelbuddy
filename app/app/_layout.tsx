import { Slot } from "expo-router";
import { PaperProvider, Portal } from "react-native-paper";
import { Themes, MD3ThemeExtended } from "@/constants/Themes";
import {
  Manrope_400Regular,
  Manrope_500Medium,
  Manrope_700Bold,
  useFonts,
} from "@expo-google-fonts/manrope";
import { useEffect } from "react";
import { View, StyleSheet, StatusBar } from "react-native";
import useAppSettings from "@/hooks/useAppSettings";
import { useMemo } from "react";
import * as SplashScreen from "expo-splash-screen";
import { AuthProvider } from "./ctx";
import { SnackbarProvider } from "@/context/SnackbarContext";
import { NavigationDataProvider } from "@/context/NavigationDataContext";
import { AppSettingsProvider } from "@/context/AppSettingsContext";
import Notification from "@/utils/notifications";
import Calendar from "@/utils/calendar";

SplashScreen.preventAutoHideAsync();

function RootLayout() {
  const { theme, contrast } = useAppSettings();

  const [loaded, error] = useFonts({
    Manrope_400Regular,
    Manrope_500Medium,
    Manrope_700Bold,
  });

  const appTheme = useMemo(() => {
    if (theme === "light") {
      if (contrast === "normal") {
        return Themes.lightTheme;
      } else {
        return Themes.lightHighContrastTheme;
      }
    } else {
      if (contrast === "normal") {
        return Themes.darkTheme;
      } else {
        return Themes.darkHighContrastTheme;
      }
    }
  }, [theme, contrast]);

  useEffect(() => {
    if (loaded || error) {
      SplashScreen.hideAsync();
    }
  }, [loaded, error]);

  if (!loaded && !error) {
    return null;
  }

  const styles = makeStyles(appTheme);

  return (
    <PaperProvider theme={appTheme}>
      <NavigationDataProvider>
        <SnackbarProvider>
          <Portal.Host>
            <StatusBar
              backgroundColor={appTheme.colors.surface}
              barStyle={theme === "dark" ? "light-content" : "dark-content"}
            />
            <View style={styles.container}>
              <Slot />
            </View>
          </Portal.Host>
        </SnackbarProvider>
      </NavigationDataProvider>
    </PaperProvider>
  );
}

export default () => {
  return (
    <AppSettingsProvider>
      <AuthProvider>
        <RootLayout />
      </AuthProvider>
      <Notification />
      <Calendar />
    </AppSettingsProvider>
  );
};

const makeStyles = (theme: MD3ThemeExtended) =>
  StyleSheet.create({
    container: {
      flex: 1,
      backgroundColor: theme.colors.background,
    },
    statusBar: {
      backgroundColor: theme.colors.background,
    },
  });
