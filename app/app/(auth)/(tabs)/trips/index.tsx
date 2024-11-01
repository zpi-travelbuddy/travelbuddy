import TripDetailsView from "@/views/trips/TripDetailsView";
import { View } from "react-native";
import { Text, useTheme } from "react-native-paper";

export default function Trips() {
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
    //   <Text>Trips</Text>
    // </View>
    <TripDetailsView />
  );
}
