import { Stack } from "expo-router";
import { PaperProvider, configureFonts } from "react-native-paper";
import {
  lightThemeHighContrast,
  darkThemeHighContrast,
} from "@/constants/Colors";
import { FontConfigs } from "@/constants/FontConfigs";
import {
  Manrope_400Regular,
  Manrope_500Medium,
  useFonts,
} from "@expo-google-fonts/manrope";
import { useEffect } from "react";
import * as SplashScreen from "expo-splash-screen";
import { ThemeProp } from "react-native-paper/lib/typescript/types";

const theme: ThemeProp = {
  ...lightThemeHighContrast,
  fonts: configureFonts({ config: FontConfigs.manrope }),
};

SplashScreen.preventAutoHideAsync();

export default function RootLayout() {
  const [loaded, error] = useFonts({
    Manrope_400Regular,
    Manrope_500Medium,
  });

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
