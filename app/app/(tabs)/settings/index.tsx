import SettingsView from "@/views/SettingsView";
import { View } from "react-native";
import { ScrollView } from "react-native-gesture-handler";
import { PaperProvider, Text } from "react-native-paper";
import { useTheme } from "react-native-paper";

export default function Explore() {
  const theme = useTheme();

  return (
    // <View
    //   style={{
    //     flex: 1,
    //     justifyContent: "center",
    //     alignItems: "center",
    //     backgroundColor: theme.colors.background,
    //   }}
    // >
    //   <Text>Settings</Text>
    // </View>
    <SettingsView />
  );
}
