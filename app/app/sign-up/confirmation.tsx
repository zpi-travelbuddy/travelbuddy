import { useState } from "react";
import {
  View,
  StyleSheet,
  SafeAreaView,
  TouchableWithoutFeedback,
  Keyboard,
} from "react-native";
import { router, useLocalSearchParams } from "expo-router";
import { useTheme, Text, Button } from "react-native-paper";
import Animated, {
  useAnimatedKeyboard,
  useAnimatedStyle,
} from "react-native-reanimated";
import { useSafeAreaInsets } from "react-native-safe-area-context";
import { CodeTextInput } from "@/components/auth/CodeTextInput";
import { MD3ThemeExtended } from "@/constants/Themes";
import { validateCode } from "@/utils/validations";
import { useAuth } from "../ctx";
import LoadingView from "@/views/LoadingView";

// It would be good if we could calculate this value dynamically, but I had some issues with that
const BOTTOM_VIEW_HEIGHT = 54;

export default function Confirmation() {
  const { email } = useLocalSearchParams<{ email: string }>();

  const { confirmSignUp } = useAuth();

  const theme = useTheme() as MD3ThemeExtended;
  const insets = useSafeAreaInsets();
  const keyboard = useAnimatedKeyboard();

  const styles = makeStyles(theme);

  const [confirmationCode, setConfirmationCode] = useState<string>("");
  const [confirmationCodeError, setConfirmationCodeError] =
    useState<string>("");
  const [isLoading, setIsLoading] = useState<boolean>(false);

  const animatedStyles = useAnimatedStyle(() => {
    return {
      marginBottom: Math.max(
        keyboard.height.value - BOTTOM_VIEW_HEIGHT - insets.bottom,
        0,
      ),
    };
  });

  const handleInputChange = (value: string) => {
    setConfirmationCode(value);
    setConfirmationCodeError(validateCode(value));
  };

  const validateForm = () => {
    return !validateCode(confirmationCode);
  };

  const confirm = async () => {
    if (!validateForm()) return;
    Keyboard.dismiss();
    setIsLoading(true);

    try {
      await confirmSignUp!(email, confirmationCode);
      router.navigate("/sign-up/success");
    } catch (error: any) {
      if (error.code === "CodeMismatchException") {
        setConfirmationCodeError("Nieprawidłowy kod weryfikacyjny");
      } else {
        setConfirmationCodeError("Wystąpił błąd, spróbuj ponownie");
      }
      console.error("Confirm sign up error:", error);
    } finally {
      setIsLoading(false);
    }
  };

  return (
    <>
      <SafeAreaView style={styles.container}>
        <TouchableWithoutFeedback onPress={Keyboard.dismiss}>
          <View style={styles.innerContainer}>
            <Animated.View style={[animatedStyles]}>
              <Text style={styles.headline} variant="headlineLarge">
                Potwierdź założenie konta
              </Text>
              <CodeTextInput
                value={confirmationCode}
                onChangeText={handleInputChange}
                style={styles.inputText}
                error={!!confirmationCodeError}
              />
              <Text style={styles.textError}>
                {confirmationCodeError || " "}
              </Text>
              <Button
                style={styles.button}
                labelStyle={styles.buttonLabel}
                mode="contained"
                onPress={confirm}
                contentStyle={styles.buttonContent}
              >
                Potwierdź
              </Button>
            </Animated.View>
          </View>
        </TouchableWithoutFeedback>
      </SafeAreaView>
      <LoadingView show={isLoading} />
    </>
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
    button: {
      alignSelf: "stretch",
      marginHorizontal: 40,
      marginBottom: 84,
      marginTop: 110,
    },
    buttonLabel: {
      fontSize: 16,
    },
    buttonContent: {
      paddingVertical: 0,
    },
    inputText: {
      marginHorizontal: 40,
      height: 56,
      lineHeight: 20,
    },
    textError: {
      marginHorizontal: 40,
      color: theme.colors.error,
    },
  });
