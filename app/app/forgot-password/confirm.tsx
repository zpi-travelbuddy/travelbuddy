import { useState } from "react";
import {
  View,
  StyleSheet,
  SafeAreaView,
  TouchableWithoutFeedback,
  Keyboard,
} from "react-native";
import { router, Link } from "expo-router";
import { useTheme, Text, Button } from "react-native-paper";
import Animated, {
  useAnimatedKeyboard,
  useAnimatedStyle,
} from "react-native-reanimated";
import { useSafeAreaInsets } from "react-native-safe-area-context";
import { PasswordTextInput } from "@/components/auth/PasswordTextInput";
import { CodeTextInput } from "@/components/auth/CodeTextInput";

// It would be good if we could calculate this value dynamically, but I had some issues with that
const BOTTOM_VIEW_HEIGHT = 54;

const hasNumber = /\d/; // At least 1 number
const hasUppercase = /[A-Z]/; // At least 1 uppercase letter
const hasLowercase = /[a-z]/; // At least 1 lowercase letter
const hasSpecialChar = /[!@#$%^&*(),.?":{}|<>]/; // At least 1 special character

export default function ForgotPasswordConfirm() {
  const theme = useTheme();
  const insets = useSafeAreaInsets();
  const keyboard = useAnimatedKeyboard();

  const styles = makeStyles(theme);

  const [confirmationCode, setConfirmationCode] = useState<string>("");
  const [newPassword, setNewPassword] = useState<string>("");

  // TODO: This may need some refactoring
  const [confirmationCodeError, setConfirmationCodeError] =
    useState<string>("");
  const [newPasswordError, setNewPasswordError] = useState<string>("");

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
  };

  const handleNewPasswordInputChange = (value: string) => {
    setNewPassword(value);
  };

  const validateCode = (value: string) => {
    if (!value) return "Kod jest wymagany";
    return "";
  };

  const validateNewPassword = (value: string) => {
    if (!value) return "Hasło jest wymagane";
    if (value.length < 8) return "Hasło musi mieć co najmniej 8 znaków";
    if (!hasLowercase.test(value))
      return "Hasło musi zawierać co najmniej jedną małą literę";
    if (!hasUppercase.test(value))
      return "Hasło musi zawierać co najmniej jedną dużą literę";
    if (!hasNumber.test(value))
      return "Hasło musi zawierać co najmniej jedną cyfrę";
    if (!hasSpecialChar.test(value))
      return "Hasło musi zawierać co najmniej jeden znak specjalny";
    if (value.includes(" ")) return "Hasło nie może zawierać spacji";
    return "";
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
    router.navigate("/forgot-password/success");
  };

  return (
    <SafeAreaView style={styles.container}>
      <TouchableWithoutFeedback onPress={Keyboard.dismiss}>
        <View style={styles.innerContainer}>
          <Animated.View style={[animatedStyles]}>
            <Text style={styles.headline} variant="headlineLarge">
              Utwórz nowe hasło
            </Text>
            <Text style={styles.description} variant="bodyLarge">
              Wprowadź kod wysłany na twój adres email i nowe hasło.
            </Text>
            <CodeTextInput
              value={confirmationCode}
              style={styles.inputText}
              error={!!confirmationCodeError}
              onChangeText={handleCodeInputChange}
            />
            <Text style={styles.textError}>{confirmationCodeError || " "}</Text>
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
