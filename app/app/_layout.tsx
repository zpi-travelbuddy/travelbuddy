import { Slot } from "expo-router";
import { PaperProvider } from "react-native-paper";
import { MD3ThemeExtended, Themes } from "@/constants/Themes";
import {
  Manrope_400Regular,
  Manrope_500Medium,
  Manrope_700Bold,
  useFonts,
} from "@expo-google-fonts/manrope";
import { useEffect } from "react";
import { useColorScheme, View, StyleSheet, StatusBar } from "react-native";
import { useMemo } from "react";
import * as SplashScreen from "expo-splash-screen";
import { AuthProvider } from "./ctx";

SplashScreen.preventAutoHideAsync();

export default function RootLayout() {
  const systemTheme = useColorScheme();

  const [loaded, error] = useFonts({
    Manrope_400Regular,
    Manrope_500Medium,
    Manrope_700Bold,
  });

  const theme = useMemo(() => {
    switch (systemTheme) {
      case "dark":
        return Themes.darkTheme;
      case "light":
      default:
        return Themes.lightTheme;
    }
  }, [systemTheme]);

  useEffect(() => {
    if (loaded || error) {
      SplashScreen.hideAsync();
    }
  }, [loaded, error]);

  if (!loaded && !error) {
    return null;
  }

  const styles = makeStyles(theme);

  return (
    <AuthProvider>
      <PaperProvider theme={theme}>
        <StatusBar />
        <View style={styles.container}>
          <Slot />
        </View>
      </PaperProvider>
    </AuthProvider>
  );
}

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
