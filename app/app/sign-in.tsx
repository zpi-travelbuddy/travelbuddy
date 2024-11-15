import { useState } from "react";
import {
  View,
  StyleSheet,
  SafeAreaView,
  TouchableWithoutFeedback,
  Keyboard,
} from "react-native";
import { useAuth } from "./ctx";
import { router, Link } from "expo-router";
import { useTheme, Text, Button } from "react-native-paper";
import Animated, {
  useAnimatedKeyboard,
  useAnimatedStyle,
} from "react-native-reanimated";
import { useSafeAreaInsets } from "react-native-safe-area-context";
import { EmailTextInput } from "@/components/auth/EmailTextInput";
import { PasswordTextInput } from "@/components/auth/PasswordTextInput";
import { validateEmail, validatePassword } from "@/utils/validations";
import { Credentials, AuthErrors } from "@/types/auth";
import { MD3ThemeExtended } from "@/constants/Themes";
import LoadingView from "@/views/LoadingView";

// It would be good if we could calculate this value dynamically, but I had some issues with that
const BOTTOM_VIEW_HEIGHT = 54;

const signInErrors: Record<string, string> = {
  NotAuthorizedException: "Nieprawidłowy email lub hasło",
  UserNotConfirmedException: "Konto nie zostało jeszcze aktywowane",
};

export default function SignIn() {
  const { signIn } = useAuth();

  const insets = useSafeAreaInsets();
  const keyboard = useAnimatedKeyboard();

  const theme = useTheme();
  const styles = makeStyles(theme as MD3ThemeExtended);

  const [credentials, setCredentials] = useState<Credentials>({
    email: "",
    password: "",
  });
  const [errors, setErrors] = useState<AuthErrors>({
    email: "",
    password: "",
  });
  const [isLoading, setIsLoading] = useState<boolean>(false);

  const animatedStyles = useAnimatedStyle(() => {
    return {
      marginBottom: Math.max(
        keyboard.height.value - BOTTOM_VIEW_HEIGHT - insets.bottom,
        0,
      ),
    };
  });

  const handleEmailChange = (email: string) => {
    setCredentials((prev) => ({ ...prev, email }));
    setErrors((prev) => ({ ...prev, email: validateEmail(email) }));
  };

  const handlePasswordChange = (password: string) => {
    setCredentials((prev) => ({ ...prev, password }));
    setErrors((prev) => ({ ...prev, password: validatePassword(password) }));
  };

  const validateForm = () => {
    const emailError = validateEmail(credentials.email);
    const passwordError = validatePassword(credentials.password);
    setErrors({ email: emailError, password: passwordError });
    return !emailError && !passwordError;
  };

  const login = async () => {
    if (!validateForm()) return;
    Keyboard.dismiss();
    setIsLoading(true);

    try {
      await signIn!(credentials);
      router.replace("/");
    } catch (error: any) {
      const errorMessage = signInErrors[error.code] || "Błąd logowania";
      setErrors({
        email: errorMessage,
        password: errorMessage,
      });
    }

    setIsLoading(false);
  };

  return (
    <>
      <SafeAreaView style={styles.container}>
        <TouchableWithoutFeedback onPress={Keyboard.dismiss}>
          <View style={styles.innerContainer}>
            <Animated.View style={[animatedStyles]}>
              <Text style={styles.headline} variant="headlineLarge">
                Logowanie
              </Text>
              <EmailTextInput
                value={credentials.email}
                onChangeText={handleEmailChange}
                error={!!errors.email}
                style={styles.inputText}
              />
              <Text style={styles.textError}>{errors.email || " "}</Text>
              <View style={{ height: 10 }} />
              <PasswordTextInput
                value={credentials.password}
                onChangeText={handlePasswordChange}
                error={!!errors.password}
                style={styles.inputText}
              />
              <Text style={styles.textError}>{errors.password || " "}</Text>
              <Text style={styles.forgotPassword} variant="labelLarge">
                <Link href="/forgot-password">Nie pamiętam hasła</Link>
              </Text>
              <Button
                style={styles.button}
                labelStyle={styles.buttonLabel}
                mode="contained"
                onPress={login}
                contentStyle={styles.buttonContent}
              >
                Zaloguj
              </Button>
            </Animated.View>
            <Text style={styles.signUp} variant="bodyLarge">
              Nie posiadasz konta?{" "}
              <Link href="/sign-up" style={styles.textBold}>
                Zarejestruj się
              </Link>
            </Text>
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
      marginBottom: 30,
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
    signUp: {
      alignSelf: "center",
      marginBottom: 30,
    },
  });
