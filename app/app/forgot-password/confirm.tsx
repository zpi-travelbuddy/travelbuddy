import { useState } from "react";
import {
  View,
  StyleSheet,
  SafeAreaView,
  TouchableWithoutFeedback,
  Keyboard,
} from "react-native";
import { router, Link, useLocalSearchParams } from "expo-router";
import { useTheme, Text, Button } from "react-native-paper";
import Animated, {
  useAnimatedKeyboard,
  useAnimatedStyle,
} from "react-native-reanimated";
import { useSafeAreaInsets } from "react-native-safe-area-context";
import { PasswordTextInput } from "@/components/auth/PasswordTextInput";
import { CodeTextInput } from "@/components/auth/CodeTextInput";
import { Auth } from "aws-amplify";
import {
  validateCode,
  validatePassword,
  validateNewPassword,
} from "@/utils/validations";
import LoadingView from "@/views/LoadingView";

// It would be good if we could calculate this value dynamically, but I had some issues with that
const BOTTOM_VIEW_HEIGHT = 54;

export default function ForgotPasswordConfirm() {
  const { email } = useLocalSearchParams<{ email: string }>();

  const theme = useTheme();
  const insets = useSafeAreaInsets();
  const keyboard = useAnimatedKeyboard();

  const styles = makeStyles(theme);

  const [confirmationCode, setConfirmationCode] = useState<string>("");
  const [newPassword, setNewPassword] = useState<string>("");

  const [confirmationCodeError, setConfirmationCodeError] =
    useState<string>("");
  const [newPasswordError, setNewPasswordError] = useState<string>("");

  const [isLoading, setIsLoading] = useState<boolean>(false);

  const animatedStyles = useAnimatedStyle(() => {
    return {
      marginBottom: Math.max(
        keyboard.height.value - BOTTOM_VIEW_HEIGHT - insets.bottom,
        0,
      ),
    };
  });

  const handleCodeInputChange = (value: string) => {
    setConfirmationCode(value);
    setConfirmationCodeError(validateCode(value));
  };

  const handleNewPasswordInputChange = (value: string) => {
    setNewPassword(value);
    setNewPasswordError(validatePassword(value));
  };

  const validateForm = () => {
    const codeError = validateCode(confirmationCode);
    const passwordError = validateNewPassword(newPassword);
    setConfirmationCodeError(codeError);
    setNewPasswordError(passwordError);
    return !codeError && !passwordError;
  };

  const resetPassword = async () => {
    if (!validateForm()) return;

    try {
      Keyboard.dismiss();
      setIsLoading(true);
      await Auth.forgotPasswordSubmit(email, confirmationCode, newPassword);
      router.navigate("/forgot-password/success");
    } catch (error: any) {
      if (error.code === "CodeMismatchException") {
        setConfirmationCodeError("Nieprawidłowy kod weryfikacyjny");
      }
      if (error.code === "LimitExceededException") {
        setConfirmationCodeError("Przekroczono limit prób, spróbuj później");
      }
      console.log(error);
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
                Utwórz nowe hasło
              </Text>
              <Text style={styles.description} variant="bodyLarge">
                Jeśli posiadasz konto, otrzymasz kod weryfikacyjny na adres
                email. Wprowadź go wraz z nowym hasłem.
              </Text>
              <CodeTextInput
                value={confirmationCode}
                style={styles.inputText}
                error={!!confirmationCodeError}
                onChangeText={handleCodeInputChange}
              />
              <Text style={styles.textError}>
                {confirmationCodeError || " "}
              </Text>
              <View style={{ height: 10 }} />
              <PasswordTextInput
                value={newPassword}
                onChangeText={handleNewPasswordInputChange}
                error={!!newPasswordError}
                style={styles.inputText}
                placeholder="Nowe hasło"
              />
              <Text style={styles.textError}>{newPasswordError || " "}</Text>
              <Button
                style={styles.button}
                labelStyle={styles.buttonLabel}
                mode="contained"
                onPress={resetPassword}
                contentStyle={styles.buttonContent}
              >
                Zmień hasło
              </Button>
            </Animated.View>
            <Text style={styles.signIn} variant="bodyLarge">
              Wróć do{" "}
              <Link href="/sign-in" style={styles.textBold}>
                Logowania
              </Link>
            </Text>
          </View>
        </TouchableWithoutFeedback>
      </SafeAreaView>
      <LoadingView show={isLoading} />
    </>
  );
}

// TODO: Change later any to theme type
const makeStyles = (theme: any) =>
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
      marginBottom: 20,
    },
    description: {
      marginHorizontal: 40,
      marginBottom: 40,
    },
    button: {
      alignSelf: "stretch",
      marginHorizontal: 40,
      marginBottom: 30,
      marginTop: 60,
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
    forgotPassword: {
      marginHorizontal: 40,
      marginBottom: 70,
      textAlign: "right",
      fontFamily: "Manrope_700Bold",
    },
    textBold: {
      fontFamily: "Manrope_700Bold",
    },
    textError: {
      marginHorizontal: 40,
      color: theme.colors.error,
    },
    signIn: {
      alignSelf: "center",
      marginBottom: 30,
    },
  });
