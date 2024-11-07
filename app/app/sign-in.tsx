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
import {
  useTheme,
  Text,
  Button,
  ActivityIndicator,
  Modal,
} from "react-native-paper";
import Animated, {
  useAnimatedKeyboard,
  useAnimatedStyle,
} from "react-native-reanimated";
import { useSafeAreaInsets } from "react-native-safe-area-context";
import { EmailTextInput } from "@/components/auth/EmailTextInput";
import { PasswordTextInput } from "@/components/auth/PasswordTextInput";
import { validateField } from "@/utils/validations";
import { Credentials, AuthErrors, FieldType } from "@/types/auth";
import { MD3ThemeExtended } from "@/constants/Themes";
import LoadingView from "@/views/LoadingView";

// It would be good if we could calculate this value dynamically, but I had some issues with that
const BOTTOM_VIEW_HEIGHT = 54;

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

  const handleInputChange = (field: FieldType, value: string) => {
    setCredentials((prev) => ({ ...prev, [field]: value }));
    setErrors((prev) => ({
      ...prev,
      [field]: validateField(field, value),
    }));
  };

  const validateForm = () => {
    const emailError = validateField(FieldType.EMAIL, credentials.email);
    const passwordError = validateField(
      FieldType.PASSWORD,
      credentials.password,
    );
    setErrors({ email: emailError, password: passwordError });
    return !emailError && !passwordError;
  };

  const login = async () => {
    Keyboard.dismiss();
    setIsLoading(true);

    if (validateForm()) {
      try {
        await signIn!(credentials);
        router.replace("/");
      } catch (error: any) {
        // TODO: Better error handling
        if (error.code === "NotAuthorizedException") {
          setErrors({
            email: "Nieprawidłowy email lub hasło",
            password: "Nieprawidłowy email lub hasło",
          });
        } else {
          console.error("Error signing in:", error);
        }
      }
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
                onChangeText={(text) =>
                  handleInputChange(FieldType.EMAIL, text)
                }
                error={!!errors.email}
                style={styles.inputText}
              />
              <Text style={styles.textError}>{errors.email || " "}</Text>
              <View style={{ height: 10 }} />
              <PasswordTextInput
                value={credentials.password}
                onChangeText={(text) =>
                  handleInputChange(FieldType.PASSWORD, text)
                }
                error={!!errors.password}
                style={styles.inputText}
              />
              <Text style={styles.textError}>{errors.password || " "}</Text>
              <Text style={styles.forgotPassword} variant="labelLarge">
                <Link href="/forgot-password/email">Nie pamiętam hasła</Link>
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
