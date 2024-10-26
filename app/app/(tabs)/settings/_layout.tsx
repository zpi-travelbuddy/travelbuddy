import { Stack } from "expo-router";
import { AppBar } from "@/components/AppBar";
import SelectCurrencyView from "@/views/SelectCurrencyView";

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
    </Stack>
  );
}
