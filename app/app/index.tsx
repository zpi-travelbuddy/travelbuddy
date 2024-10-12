import { darkThemeHighContrast } from "@/constants/Colors";
import useFontStyles from "@/hooks/useFontStyles";
import { Text, View } from "react-native";
import { useTheme } from "react-native-paper";

export default function Index() {
  const theme = useTheme();
  const fontStyles = useFontStyles();

  return (
    <View
      style={{
        flex: 1,
        justifyContent: "center",
        alignItems: "center",
        backgroundColor: theme.colors.background,
      }}
    >
      <Text
        style={{
          ...fontStyles.x_large,
          color: theme.colors.onBackground,
        }}
      >
        Edit app/index.tsx to edit this screen.
      </Text>
    </View>
  );
}
