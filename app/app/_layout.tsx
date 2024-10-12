import { Stack } from "expo-router";
import { PaperProvider, configureFonts } from "react-native-paper";
import {
  lightThemeHighContrast,
  darkThemeHighContrast,
} from "@/constants/Colors";
import {
  Manrope_400Regular,
  Manrope_500Medium,
  useFonts,
} from "@expo-google-fonts/manrope";
import { useEffect } from "react";
import * as SplashScreen from "expo-splash-screen";
import { ThemeProp } from "react-native-paper/lib/typescript/types";

const fontConfig = {
  default: {
    fontFamily: "Manrope_400Regular",
  },
  bodySmall: {
    fontFamily: "Manrope_400Regular",
  },
  bodyMedium: {
    fontFamily: "Manrope_400Regular",
  },
  bodyLarge: {
    fontFamily: "Manrope_400Regular",
  },
  headlineSmall: {
    fontFamily: "Manrope_400Regular",
  },
  headlineMedium: {
    fontFamily: "Manrope_400Regular",
  },
  headlineLarge: {
    fontFamily: "Manrope_400Regular",
  },
  labelSmall: {
    fontFamily: "Manrope_500Medium",
  },
  labelMedium: {
    fontFamily: "Manrope_500Medium",
  },
  labelLarge: {
    fontFamily: "Manrope_500Medium",
  },
  titleSmall: {
    fontFamily: "Manrope_500Medium",
  },
  titleMedium: {
    fontFamily: "Manrope_500Medium",
  },
  titleLarge: {
    fontFamily: "Manrope_500Medium",
  },
  displaySmall: {
    fontFamily: "Manrope_400Regular",
  },
  displayMedium: {
    fontFamily: "Manrope_400Regular",
  },
  displayLarge: {
    fontFamily: "Manrope_400Regular",
  },
};

const theme: ThemeProp = {
  ...lightThemeHighContrast,
  fonts: configureFonts({ config: fontConfig }),
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
