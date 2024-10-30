import { Redirect, Stack } from "expo-router";
import { useAuth } from "../ctx";

export default function RootLayout() {
  const { authState } = useAuth();

  if (!authState?.authenticated) {
    return <Redirect href="/sign-in" />;
  }

  return (
    <Stack screenOptions={{ headerShown: false }}>
      <Stack.Screen name="(tabs)" />
    </Stack>
  );
}
