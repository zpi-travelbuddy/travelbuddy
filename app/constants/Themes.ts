import { ThemeProp } from "react-native-paper/lib/typescript/types";
import { FontConfigs } from "@/constants/FontConfigs";
import { Colors } from "@/constants/Colors";
import { MD3LightTheme, MD3DarkTheme } from "react-native-paper";
import { configureFonts } from "react-native-paper";

const fontConfigManrope = configureFonts({ config: FontConfigs.manrope });

export const Themes = {
  lightTheme: {
    ...MD3LightTheme,
    fonts: fontConfigManrope,
    colors: Colors.light,
  } as ThemeProp,
  lightHighContrastTheme: {
    ...MD3LightTheme,
    fonts: fontConfigManrope,
    colors: Colors.lightHighContrast,
  } as ThemeProp,
  darkTheme: {
    ...MD3DarkTheme,
    fonts: fontConfigManrope,
    colors: Colors.dark,
  } as ThemeProp,
  darkHighContrastTheme: {
    ...MD3DarkTheme,
    fonts: fontConfigManrope,
    colors: Colors.darkHighContrast,
  } as ThemeProp,
};
