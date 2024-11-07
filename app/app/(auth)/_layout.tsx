import { Redirect, Stack } from "expo-router";
import LoadingView from "@/views/LoadingView";
import { useAuth } from "../ctx";

export default function RootLayout() {
  const { isLoading, isAuthenticated } = useAuth();

  if (isLoading) {
    return <LoadingView transparent={false} />;
  }

  if (!isAuthenticated) {
    return <Redirect href="/sign-in" />;
  }

  return (
    <Stack screenOptions={{ headerShown: false }}>
      <Stack.Screen name="(tabs)" />
    </Stack>
  );
}
