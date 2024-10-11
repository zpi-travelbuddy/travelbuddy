import { Stack } from "expo-router";
import { PaperProvider } from "react-native-paper";
import {
  lightThemeHighContrast,
  darkThemeHighContrast,
} from "@/constants/Colors";

export default function RootLayout() {
  return (
    <PaperProvider theme={lightThemeHighContrast}>
      <Stack>
        <Stack.Screen name="index" />
      </Stack>
    </PaperProvider>
  );
}
