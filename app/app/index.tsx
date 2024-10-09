import { darkThemeHighContrast } from "@/constants/Colors";
import { Text, View } from "react-native";

export default function Index() {
  return (
    <View
      style={{
        flex: 1,
        justifyContent: "center",
        alignItems: "center",
        backgroundColor: darkThemeHighContrast.colors.background
      }}
    >
      <Text
       style={{
        color: darkThemeHighContrast.colors.onBackground
      }}>Edit app/index.tsx to edit this screen.</Text>
    </View>
  );
}
