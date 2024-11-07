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
      <Stack.Screen name="index" options={{ title: "Wycieczki" }} />
      <Stack.Screen
        name="details/[trip_id]/index"
        options={{ title: "Szczegóły wycieczki" }}
      />
    </Stack>
  );
}
