import { FontConfigs } from "@/constants/FontConfigs";
import { Colors } from "@/constants/Colors";
import { MD3LightTheme, MD3DarkTheme } from "react-native-paper";
import { MD3Theme } from "react-native-paper/lib/typescript/types";
import { configureFonts } from "react-native-paper";
import { MD3ColorsExtended } from "@/constants/Colors";

export interface MD3ThemeExtended extends MD3Theme {
  colors: MD3ColorsExtended;
}

const fontConfigManrope = configureFonts({ config: FontConfigs.manrope });

export const Themes = {
  lightTheme: {
    ...MD3LightTheme,
    fonts: fontConfigManrope,
    colors: Colors.light,
  } as MD3ThemeExtended,
  lightHighContrastTheme: {
    ...MD3LightTheme,
    fonts: fontConfigManrope,
    colors: Colors.lightHighContrast,
  } as MD3ThemeExtended,
  darkTheme: {
    ...MD3DarkTheme,
    fonts: fontConfigManrope,
    colors: Colors.dark,
  } as MD3ThemeExtended,
  darkHighContrastTheme: {
    ...MD3DarkTheme,
    fonts: fontConfigManrope,
    colors: Colors.darkHighContrast,
  } as MD3ThemeExtended,
};
