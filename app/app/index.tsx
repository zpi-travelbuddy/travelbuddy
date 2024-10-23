import { View } from "react-native";
import { Text } from "react-native-paper";
import { useTheme } from "react-native-paper";
import SettingsView from "@/views/SettingsView";

export default function Index() {
  const theme = useTheme();

  return <SettingsView />;
}
