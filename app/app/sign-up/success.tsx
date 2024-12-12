import {
  View,
  StyleSheet,
  SafeAreaView,
  TouchableWithoutFeedback,
  Keyboard,
} from "react-native";
import { router } from "expo-router";
import { useTheme, Text, Button } from "react-native-paper";
import { MD3ThemeExtended } from "@/constants/Themes";

export default function Confirmation() {
  const theme = useTheme() as MD3ThemeExtended;

  const styles = makeStyles(theme);

  const handlePress = () => {
    router.navigate("/sign-in");
  };

  return (
    <SafeAreaView style={styles.container}>
      <TouchableWithoutFeedback onPress={Keyboard.dismiss}>
        <View style={styles.innerContainer}>
          <Text style={styles.headline} variant="headlineLarge">
            Udało się!
          </Text>
          <Text variant="bodyLarge" style={styles.paragraph}>
            Potwierdzono założenie konta.
          </Text>
          <Button
            style={styles.button}
            labelStyle={styles.buttonLabel}
            mode="contained"
            onPress={handlePress}
            contentStyle={styles.buttonContent}
          >
            Wróć do logowania
          </Button>
        </View>
      </TouchableWithoutFeedback>
    </SafeAreaView>
  );
}

const makeStyles = (theme: MD3ThemeExtended) =>
  StyleSheet.create({
    container: {
      flex: 1,
      backgroundColor: theme.colors.surface,
    },
    innerContainer: {
      flex: 1,
      justifyContent: "flex-end",
    },
    headline: {
      fontFamily: "Manrope_700Bold",
      marginHorizontal: 40,
      marginBottom: 40,
    },
    paragraph: {
      marginHorizontal: 40,
      marginBottom: 140,
    },
    button: {
      alignSelf: "stretch",
      marginHorizontal: 40,
      marginBottom: 84,
      marginTop: 40,
    },
    buttonLabel: {
      fontSize: 16,
    },
    buttonContent: {
      paddingVertical: 0,
    },
  });
