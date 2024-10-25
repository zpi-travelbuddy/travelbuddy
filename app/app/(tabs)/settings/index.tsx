import AppErrorView from "@/views/AppErrorView";
import { View } from "react-native";
import { Text } from "react-native-paper";
import { useTheme } from "react-native-paper";

export default function Explore() {
  const theme = useTheme();

  return <AppErrorView />;
}
