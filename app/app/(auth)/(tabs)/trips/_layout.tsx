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
      <Stack.Screen
        name="details/[trip_id]/day/[day_id]/tripPoints/create/index"
        options={{ title: "Dodanie punktu wycieczki" }}
      />
      <Stack.Screen
        name="details/[trip_id]/day/[day_id]/explore/index"
        options={{ title: "Wyszukaj atrakcję" }}
      />
      <Stack.Screen
        name="details/[trip_id]/day/[day_id]/recommendations/index"
        options={{ title: "Rekomendacje" }}
      />
      <Stack.Screen
        name="details/[trip_id]/day/[day_id]/index"
        options={{ title: "Szczegóły dnia wycieczki" }}
      />
      <Stack.Screen
        name="details/[trip_id]/day/[day_id]/tripPoints/details/[trip_point_id]/index"
        options={{ title: "Szczegóły punktu wycieczki" }}
      />
      <Stack.Screen
        name="edit/[trip_id]"
        options={{ title: "Edytowanie wycieczki" }}
      />
      <Stack.Screen
        name="add/index"
        options={{ title: "Dodawanie wycieczki" }}
      />
      <Stack.Screen
        name="add/destination"
        options={{ title: "Wybór celu wycieczki" }}
      />
      <Stack.Screen name="add/currency" options={{ title: "Wybór waluty" }} />
      <Stack.Screen
        name="place/[place_id]"
        options={{ title: "Szczegóły atrakcji" }}
      />
    </Stack>
  );
}
