import {
  MD3LightTheme as DefaultTheme,
  MD3DarkTheme as DarkTheme,
} from "react-native-paper";
import { MD3Colors } from "react-native-paper/lib/typescript/types";

export const BLACK = "#000000";
export const WHITE = "#FFFFFF";
export const YELLOW = "#FFCC00";
export const BACKDROP = "rgba(0, 0, 0, 0.32)";

export interface MD3ColorsExtended extends MD3Colors {
  surfaceContainerLowest: string;
  surfaceContainerLow: string;
  surfaceContainer: string;
  surfaceContainerHigh: string;
  surfaceContainerHighest: string;
}

export const Colors = {
  light: {
    ...DefaultTheme.colors,
    primary: "#226A4C",
    surfaceTint: "#226A4C",
    onPrimary: "#FFFFFF",
    primaryContainer: "#AACCBA",
    onPrimaryContainer: "#002113",
    secondary: "#4D6357",
    onSecondary: "#FFFFFF",
    secondaryContainer: "#D0E9D8",
    onSecondaryContainer: "#0A1F16",
    tertiary: "#3D6473",
    onTertiary: "#FFFFFF",
    tertiaryContainer: "#C0E9FB",
    onTertiaryContainer: "#001F29",
    error: "#BA1A1A",
    onError: "#FFFFFF",
    errorContainer: "#FFDAD6",
    onErrorContainer: "#410002",
    background: "#F5FBF5",
    onBackground: "#171D19",
    surface: "#F5FAFB",
    onSurface: "#171D1E",
    surfaceVariant: "#DCE5DD",
    onSurfaceVariant: "#404943",
    outline: "#707973",
    outlineVariant: "#C0C9C1",
    shadow: "#000000",
    scrim: "#000000",
    inverseSurface: "#2B3133",
    inverseOnSurface: "#ECF2F3",
    inversePrimary: "#8ED5B1",
    primaryFixed: "#AAF2CC",
    onPrimaryFixed: "#002113",
    primaryFixedDim: "#8ED5B1",
    onPrimaryFixedVariant: "#005236",
    secondaryFixed: "#D0E9D8",
    onSecondaryFixed: "#0A1F16",
    secondaryFixedDim: "#B4CCBD",
    onSecondaryFixedVariant: "#364B40",
    tertiaryFixed: "#C0E9FB",
    onTertiaryFixed: "#001F29",
    tertiaryFixedDim: "#A5CDDE",
    onTertiaryFixedVariant: "#244C5A",
    surfaceDim: "#D5DBDC",
    surfaceBright: "#F5FAFB",
    surfaceContainerLowest: "#FFFFFF",
    surfaceContainerLow: "#EFF5F6",
    surfaceContainer: "#E9EFF0",
    surfaceContainerHigh: "#E3E9EA",
    surfaceContainerHighest: "#DEE3E5",
    elevation: {
      ...DefaultTheme.colors.elevation,
      level0: "#FFFFFF", // surfaceContainerLowest
      level1: "#EFF5F6", // surfaceContainerLow
      level2: "#E9EFF0", // surfaceContainer
      level3: "#E3E9EA", // surfaceContainerHigh
      level4: "#DEE3E5", // surfaceContainerHighest
    },
    backdrop: "rgba(0, 0, 0, 0.32)",
  } as MD3ColorsExtended,
  lightHighContrast: {
    ...DefaultTheme.colors,
    primary: "#002819",
    surfaceTint: "#226A4C",
    onPrimary: "#FFFFFF",
    primaryContainer: "#004D33",
    onPrimaryContainer: "#FFFFFF",
    secondary: "#11261C",
    onSecondary: "#FFFFFF",
    secondaryContainer: "#32473C",
    onSecondaryContainer: "#FFFFFF",
    tertiary: "#002631",
    onTertiary: "#FFFFFF",
    tertiaryContainer: "#1F4856",
    onTertiaryContainer: "#FFFFFF",
    error: "#4E0002",
    onError: "#FFFFFF",
    errorContainer: "#8C0009",
    onErrorContainer: "#FFFFFF",
    background: "#F5FAFB",
    onBackground: "#171D19",
    surface: "#F5FAFB",
    onSurface: "#000000",
    surfaceVariant: "#DCE5DD",
    onSurfaceVariant: "#1D2621",
    outline: "#3C453F",
    outlineVariant: "#3C453F",
    shadow: "#000000",
    scrim: "#000000",
    inverseSurface: "#2B3133",
    inverseOnSurface: "#FFFFFF",
    inversePrimary: "#B3FCD5",
    primaryFixed: "#004D33",
    onPrimaryFixed: "#FFFFFF",
    primaryFixedDim: "#003421",
    onPrimaryFixedVariant: "#FFFFFF",
    secondaryFixed: "#32473C",
    onSecondaryFixed: "#FFFFFF",
    secondaryFixedDim: "#1C3126",
    onSecondaryFixedVariant: "#FFFFFF",
    tertiaryFixed: "#1F4856",
    onTertiaryFixed: "#FFFFFF",
    tertiaryFixedDim: "#01313F",
    onTertiaryFixedVariant: "#FFFFFF",
    surfaceDim: "#D5DBDC",
    surfaceBright: "#F5FAFB",
    surfaceContainerLowest: "#FFFFFF",
    surfaceContainerLow: "#EFF5F6",
    surfaceContainer: "#E9EFF0",
    surfaceContainerHigh: "#E3E9EA",
    surfaceContainerHighest: "#DEE3E5",
    elevation: {
      ...DefaultTheme.colors.elevation,
      level0: "#FFFFFF", // surfaceContainerLowest
      level1: "#EFF5F6", // surfaceContainerLow
      level2: "#E9EFF0", // surfaceContainer
      level3: "#E3E9EA", // surfaceContainerHigh
      level4: "#DEE3E5", // surfaceContainerHighest
    },
    backdrop: "rgba(0, 0, 0, 0.32)",
  } as MD3ColorsExtended,
  dark: {
    ...DarkTheme.colors,
    primary: "#8ED5B1",
    surfaceTint: "#8ED5B1",
    onPrimary: "#003824",
    primaryContainer: "#005236",
    onPrimaryContainer: "#AAF2CC",
    secondary: "#B4CCBD",
    onSecondary: "#20352A",
    secondaryContainer: "#364B40",
    onSecondaryContainer: "#D0E9D8",
    tertiary: "#A5CDDE",
    onTertiary: "#063543",
    tertiaryContainer: "#244C5A",
    onTertiaryContainer: "#C0E9FB",
    error: "#FFB4AB",
    onError: "#690005",
    errorContainer: "#93000A",
    onErrorContainer: "#FFDAD6",
    background: "#0E1415",
    onBackground: "#DEE4DE",
    surface: "#0E1415",
    onSurface: "#DEE3E5",
    surfaceVariant: "#404943",
    onSurfaceVariant: "#C0C9C1",
    outline: "#8A938C",
    outlineVariant: "#404943",
    shadow: "#000000",
    scrim: "#000000",
    inverseSurface: "#DEE3E5",
    inverseOnSurface: "#2B3133",
    inversePrimary: "#226A4C",
    primaryFixed: "#AAF2CC",
    onPrimaryFixed: "#002113",
    primaryFixedDim: "#8ED5B1",
    onPrimaryFixedVariant: "#005236",
    secondaryFixed: "#D0E9D8",
    onSecondaryFixed: "#0A1F16",
    secondaryFixedDim: "#B4CCBD",
    onSecondaryFixedVariant: "#364B40",
    tertiaryFixed: "#C0E9FB",
    onTertiaryFixed: "#001F29",
    tertiaryFixedDim: "#A5CDDE",
    onTertiaryFixedVariant: "#244C5A",
    surfaceDim: "#0E1415",
    surfaceBright: "#343A3B",
    surfaceContainerLowest: "#090F10",
    surfaceContainerLow: "#171D1E",
    surfaceContainer: "#1B2122",
    surfaceContainerHigh: "#252B2C",
    surfaceContainerHighest: "#303637",
    elevation: {
      ...DarkTheme.colors.elevation,
      level0: "#090F10", // surfaceContainerLowest
      level1: "#171D1E", // surfaceContainerLow
      level2: "#1B2122", // surfaceContainer
      level3: "#252B2C", // surfaceContainerHigh
      level4: "#303637", // surfaceContainerHighest
    },
    backdrop: "rgba(0, 0, 0, 0.32)",
  } as MD3ColorsExtended,
  darkHighContrast: {
    ...DarkTheme.colors,
    primary: "#EEFFF2",
    surfaceTint: "#8ED5B1",
    onPrimary: "#000000",
    primaryContainer: "#92DAB5",
    onPrimaryContainer: "#000000",
    secondary: "#EEFFF2",
    onSecondary: "#000000",
    secondaryContainer: "#B8D1C1",
    onSecondaryContainer: "#000000",
    tertiary: "#F6FBFF",
    onTertiary: "#000000",
    tertiaryContainer: "#A9D1E2",
    onTertiaryContainer: "#000000",
    error: "#FFF9F9",
    onError: "#000000",
    errorContainer: "#FFBAB1",
    onErrorContainer: "#000000",
    background: "#0E1415",
    onBackground: "#DEE4DE",
    surface: "#0E1415",
    onSurface: "#FFFFFF",
    surfaceVariant: "#404943",
    onSurfaceVariant: "#F4FDF5",
    outline: "#C4CDC5",
    outlineVariant: "#C4CDC5",
    shadow: "#000000",
    scrim: "#000000",
    inverseSurface: "#DEE3E5",
    inverseOnSurface: "#000000",
    inversePrimary: "#00311F",
    primaryFixed: "#AEF6D0",
    onPrimaryFixed: "#000000",
    primaryFixedDim: "#92DAB5",
    onPrimaryFixedVariant: "#001B0F",
    secondaryFixed: "#D4EDDC",
    onSecondaryFixed: "#000000",
    secondaryFixedDim: "#B8D1C1",
    onSecondaryFixedVariant: "#051A11",
    tertiaryFixed: "#C5EDFF",
    onTertiaryFixed: "#000000",
    tertiaryFixedDim: "#A9D1E2",
    onTertiaryFixedVariant: "#001922",
    surfaceDim: "#0E1415",
    surfaceBright: "#343A3B",
    surfaceContainerLowest: "#090F10",
    surfaceContainerLow: "#171D1E",
    surfaceContainer: "#1B2122",
    surfaceContainerHigh: "#252B2C",
    surfaceContainerHighest: "#303637",
    elevation: {
      ...DarkTheme.colors.elevation,
      level0: "#090F10", // surfaceContainerLowest
      level1: "#171D1E", // surfaceContainerLow
      level2: "#1B2122", // surfaceContainer
      level3: "#252B2C", // surfaceContainerHigh
      level4: "#303637", // surfaceContainerHighest
    },
    backdrop: "rgba(0, 0, 0, 0.32)",
  } as MD3ColorsExtended,
};
