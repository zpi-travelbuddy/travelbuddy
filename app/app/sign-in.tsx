import {
  View,
  StyleSheet,
  SafeAreaView,
  KeyboardAvoidingView,
  Platform,
  TouchableWithoutFeedback,
  Keyboard,
  Animated,
} from "react-native";
import { useAuth } from "./ctx";
import { router, Link } from "expo-router";
import { useTheme, Text, Button, TextInput } from "react-native-paper";
import { useState } from "react";
import { validateEmail } from "@/utils/validations";

const EMAIL = "email";
const PASSWORD = "password";

export default function SignIn() {
  const { onLogin, authState } = useAuth();
  const theme = useTheme();
  const styles = makeStyles(theme);
  const [credentials, setCredentials] = useState<{
    email: string;
    password: string;
  }>({
    email: "",
    password: "",
  });
  const [emailError, setEmailError] = useState("");
  const [keyboardOffset] = useState(new Animated.Value(0));

  const handleInputChange = (name: "email" | "password", value: string) => {
    setCredentials((prev) => ({ ...prev, [name]: value }));

    // If the email is being updated, validate it
    if (name === "email") {
      if (!validateEmail(value)) {
        setEmailError("Niepoprawny format email");
      } else {
        setEmailError("");
      }
    }
  };

  const login = async () => {
    await onLogin!(EMAIL, PASSWORD);

    router.replace("/");
  };

  return (
    <SafeAreaView style={styles.container}>
      <TouchableWithoutFeedback onPress={Keyboard.dismiss}>
        <View style={{ flex: 1, justifyContent: "flex-end" }}>
          <KeyboardAvoidingView
            behavior={Platform.OS === "ios" ? "padding" : "height"}
          >
            <Text style={styles.headline} variant="headlineLarge">
              Logowanie
            </Text>
            <TextInput
              style={styles.inputText}
              mode="outlined"
              placeholder="Email"
              keyboardType="email-address"
              inputMode="email"
              value={credentials.email}
              onChangeText={(text) => handleInputChange("email", text)}
              error={!!emailError}
              left={<TextInput.Icon icon="at" />}
            />
            <View style={styles.inputSpace} />
            <TextInput
              style={styles.inputText}
              mode="outlined"
              placeholder="Hasło"
              value={credentials.password}
              onChangeText={(text) => handleInputChange("password", text)}
              left={<TextInput.Icon icon="lock-outline" />}
              // secureTextEntry={true}
            />
            <Text style={styles.forgotPassword} variant="labelMedium">
              Nie pamiętam hasła
            </Text>
          </KeyboardAvoidingView>
          <Button style={styles.button} mode="contained" onPress={login}>
            Zaloguj
          </Button>
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
    headline: {
      alignSelf: "stretch",
      marginHorizontal: 40,
      marginBottom: 40,
    },
    button: {
      alignSelf: "stretch",
      marginHorizontal: 80,
      marginBottom: 40,
    },
    inputText: {
      // alignSelf: "stretch",
      marginHorizontal: 40,
      height: 56, // hack to disable multiline
    },
    inputSpace: {
      marginVertical: 10,
    },
    forgotPassword: {
      marginHorizontal: 40,
      marginTop: 10,
      marginBottom: 90,
      alignSelf: "stretch",
      textAlign: "right",
    },
    textBold: {
      fontFamily: "Manrope_700Bold",
    },
    signUp: {
      alignSelf: "center",
    },
  });
