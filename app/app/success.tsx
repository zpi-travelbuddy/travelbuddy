import {
  View,
  StyleSheet,
  SafeAreaView,
  TouchableWithoutFeedback,
  Keyboard,
} from "react-native";
import { Link } from "expo-router";
import { useTheme, Text } from "react-native-paper";
import Animated, {
  useAnimatedKeyboard,
  useAnimatedStyle,
} from "react-native-reanimated";
import { useSafeAreaInsets } from "react-native-safe-area-context";
import { MD3ThemeExtended } from "@/constants/Themes";

// It would be good if we could calculate this value dynamically, but I had some issues with that
const BOTTOM_VIEW_HEIGHT = 54;

export default function Confirmation() {
  const theme = useTheme() as MD3ThemeExtended;
  const insets = useSafeAreaInsets();
  const keyboard = useAnimatedKeyboard();

  const styles = makeStyles(theme);

  const animatedStyles = useAnimatedStyle(() => {
    return {
      marginBottom: Math.max(
        keyboard.height.value - BOTTOM_VIEW_HEIGHT - insets.bottom,
        0,
      ),
    };
  });

  return (
    <SafeAreaView style={styles.container}>
      <TouchableWithoutFeedback onPress={Keyboard.dismiss}>
        <View style={styles.innerContainer}>
          <Animated.View style={[animatedStyles]}>
            <Text style={styles.headline} variant="headlineLarge">
              Udało się!
            </Text>
            <Text variant="bodyLarge" style={styles.paragraph}>
              Potwierdzono założenie konta.{" \n"}
              <Link href="/sign-in">
                Wróć do{" "}
                <Text style={{ fontFamily: "Manrope_700Bold" }}>logowania</Text>
              </Link>
            </Text>
          </Animated.View>
        </View>
      </TouchableWithoutFeedback>
    </SafeAreaView>
  );
}

const makeStyles = (theme: MD3ThemeExtended) =>
  StyleSheet.create({
    container: {
      flex: 1,
      backgroundColor: theme.colors.background,
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
      marginBottom: 240,
    },
  });
