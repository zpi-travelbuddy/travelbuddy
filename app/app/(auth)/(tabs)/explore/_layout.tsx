import { Stack } from "expo-router";
import { AppBar } from "@/components/AppBar";

export default function StackLayout() {
  return (
    <Stack
      screenOptions={{
        header: ({ options, route, navigation }) => (
          <AppBar options={options} route={route} navigation={navigation} />
        ),
      }}
    >
      <Stack.Screen name="index" options={{ title: "Eksploruj" }} />
      <Stack.Screen
        name="place/[place_id]"
        options={{ title: "Szczegóły atrakcji" }}
      />
      <Stack.Screen
        name="create/index"
        options={{ title: "Dodanie punktu wycieczki" }}
      />
    </Stack>
  );
}
