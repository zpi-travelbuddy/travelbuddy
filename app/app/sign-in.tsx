import React, { useState } from "react";
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
import { validateEmail } from "@/utils/validations";

// It would be good if we could calculate this value dynamically, but I had some issues with that
const BOTTOM_VIEW_HEIGHT = 34;

export default function SignIn() {
  const { onLogin } = useAuth();
  const theme = useTheme();
  const insets = useSafeAreaInsets();
  const keyboard = useAnimatedKeyboard();

  const styles = makeStyles(theme);

  const [credentials, setCredentials] = useState<{
    email: string;
    password: string;
  }>({
    email: "",
    password: "",
  });
  const [errors, setErrors] = useState<{ email: string; password: string }>({
    email: "",
    password: "",
  });

  const animatedStyles = useAnimatedStyle(() => {
    return {
      marginBottom: Math.max(
        keyboard.height.value - BOTTOM_VIEW_HEIGHT - insets.bottom,
        0,
      ),
    };
  });

  const handleInputChange = (field: "email" | "password", value: string) => {
    setCredentials((prev) => ({ ...prev, [field]: value }));
    setErrors((prev) => ({
      ...prev,
      [field]: validateField(field, value),
    }));
  };

  const validateField = (field: "email" | "password", value: string) => {
    if (!value)
      return `${field === "email" ? "Email jest wymagany" : "Hasło jest wymagane"}`;
    if (field === "email" && !validateEmail(value))
      return "Niepoprawny format email";
    return "";
  };

  const validateForm = () => {
    const emailError = validateField("email", credentials.email);
    const passwordError = validateField("password", credentials.password);
    setErrors({ email: emailError, password: passwordError });
    return !emailError && !passwordError;
  };

  const login = async () => {
    if (!validateForm()) return;
    await onLogin!(credentials.email, credentials.password);
    router.replace("/");
  };

  return (
    <SafeAreaView style={styles.container}>
      <TouchableWithoutFeedback onPress={Keyboard.dismiss}>
        <View style={styles.innerContainer}>
          <Animated.View style={[animatedStyles]}>
            <Text style={styles.headline} variant="headlineLarge">
              Logowanie
            </Text>
            <EmailTextInput
              value={credentials.email}
              onChangeText={(text) => handleInputChange("email", text)}
              error={!!errors.email}
              style={styles.inputText}
            />
            <Text style={styles.textError}>{errors.email || " "}</Text>
            <View style={{ height: 10 }} />
            <PasswordTextInput
              value={credentials.password}
              onChangeText={(text) => handleInputChange("password", text)}
              error={!!errors.password}
              style={styles.inputText}
            />
            <Text style={styles.textError}>{errors.password || " "}</Text>
            <Text style={styles.forgotPassword} variant="labelLarge">
              Nie pamiętam hasła
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
            <Link href="/" style={styles.textBold}>
              Zarejestruj się
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
    },
    forgotPassword: {
      marginHorizontal: 40,
      marginBottom: 90,
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
      marginBottom: 10,
    },
  });
