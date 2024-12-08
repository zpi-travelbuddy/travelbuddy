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
      <Stack.Screen name="index" options={{ title: "Ustawienia" }} />
      <Stack.Screen
        name="conditionProfiles/index"
        options={{ title: "Profile udogodnień" }}
      />
      <Stack.Screen
        name="conditionProfiles/manage/[profile_id]"
        options={{ title: "Szczegóły profilu" }}
      />
      <Stack.Screen
        name="categoryProfiles/index"
        options={{ title: "Profile preferencji" }}
      />
      <Stack.Screen
        name="categoryProfiles/manage/[profile_id]"
        options={{ title: "Szczegóły profilu" }}
      />
    </Stack>
  );
}
