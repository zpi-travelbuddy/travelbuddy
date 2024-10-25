import { View, StyleSheet } from "react-native";
import { Button } from "react-native-paper";
import { useAuth } from "./ctx";
import { router } from "expo-router";
import { useTheme } from "react-native-paper";

const EMAIL = "email";
const PASSWORD = "password";

export default function SignIn() {
  const { onLogin, authState } = useAuth();
  const theme = useTheme();
  const styles = makeStyles(theme);

  const login = async () => {
    await onLogin!(EMAIL, PASSWORD);

    router.replace("/");
  };

  return (
    <View style={styles.container}>
      <Button onPress={login}>Sign In</Button>
    </View>
  );
}

// TODO: Change later any to theme type
const makeStyles = (theme: any) =>
  StyleSheet.create({
    container: {
      flex: 1,
      justifyContent: "center",
      alignItems: "center",
      backgroundColor: theme.colors.background,
    },
  });
