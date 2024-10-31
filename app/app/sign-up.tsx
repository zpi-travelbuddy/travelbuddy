import { useState } from "react";
import {
  View,
  StyleSheet,
  SafeAreaView,
  TouchableWithoutFeedback,
  Keyboard,
} from "react-native";
import { router, Link } from "expo-router";
import { useTheme, Text, Button, Portal, Dialog } from "react-native-paper";
import Animated, {
  useAnimatedKeyboard,
  useAnimatedStyle,
} from "react-native-reanimated";
import { useSafeAreaInsets } from "react-native-safe-area-context";
import { EmailTextInput } from "@/components/auth/EmailTextInput";
import { PasswordTextInput } from "@/components/auth/PasswordTextInput";
import { validateField } from "@/utils/validations";
import { Credentials, AuthErrors } from "@/types/auth";
import { useAuth } from "./ctx";
import { MD3ThemeExtended } from "@/constants/Themes";

// It would be good if we could calculate this value dynamically, but I had some issues with that
const BOTTOM_VIEW_HEIGHT = 54;

export default function SignIn() {
  const { onRegister } = useAuth();
  const insets = useSafeAreaInsets();
  const keyboard = useAnimatedKeyboard();

  const theme = useTheme() as MD3ThemeExtended;
  const styles = makeStyles(theme);

  const [credentials, setCredentials] = useState<Credentials>({
    email: "",
    password: "",
  });
  const [errors, setErrors] = useState<AuthErrors>({
    email: "",
    password: "",
  });
  const [showDialog, setShowDialog] = useState(false);

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

  const handleDismissDialog = () => {
    setShowDialog(false);
    router.navigate("/confirmation");
  };

  const validateForm = () => {
    const emailError = validateField("email", credentials.email);
    const passwordError = validateField("password", credentials.password);
    setErrors({ email: emailError, password: passwordError });
    return !emailError && !passwordError;
  };

  const signup = async () => {
    if (!validateForm()) return;
    await onRegister!(credentials);
    Keyboard.dismiss();
    setShowDialog(true);
  };

  return (
    <SafeAreaView style={styles.container}>
      <TouchableWithoutFeedback onPress={Keyboard.dismiss}>
        <View style={styles.innerContainer}>
          <Animated.View style={[animatedStyles]}>
            <Text style={styles.headline} variant="headlineLarge">
              Rejestracja
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
            <Button
              style={styles.button}
              labelStyle={styles.buttonLabel}
              mode="contained"
              onPress={signup}
              contentStyle={styles.buttonContent}
            >
              Zarejestruj
            </Button>
          </Animated.View>
          <Text style={styles.signIn} variant="bodyLarge">
            Posiadasz już konto?{" "}
            <Link href="/sign-in" style={styles.textBold}>
              Zaloguj się
            </Link>
          </Text>
          <Portal>
            <Dialog visible={showDialog} onDismiss={handleDismissDialog}>
              <Dialog.Icon icon="check-circle-outline" />
              <Dialog.Title style={styles.dialogTitle}>
                Dziękujemy za rejestrację
              </Dialog.Title>
              <Dialog.Content>
                <Text variant="bodyLarge" style={styles.dialogContent}>
                  Wysłaliśmy wiadomość z kodem potwierdzającym założenie konta
                </Text>
              </Dialog.Content>
              <Dialog.Actions>
                <Button onPress={handleDismissDialog}>Dalej</Button>
              </Dialog.Actions>
            </Dialog>
          </Portal>
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
    button: {
      alignSelf: "stretch",
      marginHorizontal: 40,
      marginBottom: 30,
      marginTop: 90,
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
    dialogTitle: {
      textAlign: "center",
    },
    dialogContent: {
      textAlign: "center",
    },
  });
