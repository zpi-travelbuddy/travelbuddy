import TripDetailsView from "@/views/TripDetailsView";
import { View } from "react-native";
import { Text } from "react-native-paper";
import { useTheme } from "react-native-paper";

export default function Index() {
  const theme = useTheme();

  return <TripDetailsView />;
}
