import { Stack } from "expo-router";
import { PaperProvider } from "react-native-paper";
import { Themes } from "@/constants/Themes";
import {
  Manrope_400Regular,
  Manrope_500Medium,
  useFonts,
} from "@expo-google-fonts/manrope";
import { useEffect } from "react";
import { useColorScheme } from "react-native";
import { useMemo } from "react";
import * as SplashScreen from "expo-splash-screen";

SplashScreen.preventAutoHideAsync();

export default function RootLayout() {
  const systemTheme = useColorScheme();

  const [loaded, error] = useFonts({
    Manrope_400Regular,
    Manrope_500Medium,
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

  return (
    <PaperProvider theme={theme}>
      <Stack>
        <Stack.Screen name="index" />
      </Stack>
    </PaperProvider>
  );
}
