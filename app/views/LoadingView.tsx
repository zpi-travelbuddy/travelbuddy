import { MD3ThemeExtended } from "@/constants/Themes";
import { View } from "react-native";
import { StyleSheet } from "react-native";
import { ActivityIndicator, useTheme } from "react-native-paper";

const LoadingView = () => {
  const theme = useTheme();
  const styles = createStyles(theme as MD3ThemeExtended);

  return (
    <View style={styles.container}>
      <ActivityIndicator
        size="large"
        animating={true}
        accessible={true}
        accessibilityLabel="Loading..."
      />
    </View>
  );
};

const createStyles = (theme: MD3ThemeExtended) =>
  StyleSheet.create({
    container: {
      flex: 1,
      justifyContent: "center",
      alignItems: "center",
      backgroundColor: theme.colors.surface,
    },
  });

export default LoadingView;
