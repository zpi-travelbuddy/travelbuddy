import React, { useState } from "react";
import {
  View,
  StyleSheet,
  SafeAreaView,
  TouchableWithoutFeedback,
  Keyboard,
} from "react-native";
import { Link, router } from "expo-router";
import { useTheme, Text, Button } from "react-native-paper";
import Animated, {
  useAnimatedKeyboard,
  useAnimatedStyle,
} from "react-native-reanimated";
import { useSafeAreaInsets } from "react-native-safe-area-context";
import { EmailTextInput } from "@/components/auth/EmailTextInput";
import { validateEmail } from "@/utils/validations";
import { MD3ThemeExtended } from "@/constants/Themes";

// It would be good if we could calculate this value dynamically, but I had some issues with that
const BOTTOM_VIEW_HEIGHT = 54;

export default function ForgotPasswordEmail() {
  const theme = useTheme();
  const insets = useSafeAreaInsets();
  const keyboard = useAnimatedKeyboard();

  const styles = makeStyles(theme as MD3ThemeExtended);

  const [email, setEmail] = useState<string>("");
  const [error, setError] = useState<string>("");

  const animatedStyles = useAnimatedStyle(() => {
    return {
      marginBottom: Math.max(
        keyboard.height.value - BOTTOM_VIEW_HEIGHT - insets.bottom,
        0,
      ),
    };
  });

  const handleEmailChange = (value: string) => {
    setEmail(value);
    setError(validateEmail(value));
  };

  const validateForm = () => {
    const emailError = validateEmail(email);
    setError(emailError);
    return !emailError;
  };

  const handlePress = async () => {
    if (validateForm()) {
      // TODO: Add password reset request
      router.navigate({
        pathname: "/forgot-password/confirm",
        params: { email },
      });
    }
  };

  return (
    <SafeAreaView style={styles.container}>
      <TouchableWithoutFeedback onPress={Keyboard.dismiss}>
        <View style={styles.innerContainer}>
          <Animated.View style={[animatedStyles]}>
            <Text style={styles.headline} variant="headlineMedium">
              Nie pamiętam hasła
            </Text>
            <Text style={styles.description} variant="bodyLarge">
              Wprowadź adres email, który został użyty przy rejestracji.
            </Text>
            <EmailTextInput
              value={email}
              onChangeText={handleEmailChange}
              error={!!error}
              style={styles.inputText}
            />
            <Text style={styles.textError}>{error || " "}</Text>
            <Button
              style={styles.button}
              labelStyle={styles.buttonLabel}
              mode="contained"
              onPress={handlePress}
              contentStyle={styles.buttonContent}
            >
              Kontynuuj
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
