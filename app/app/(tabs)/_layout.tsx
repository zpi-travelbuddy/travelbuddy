//@ts-nocheck
import { Tabs } from "expo-router";
import { BottomNavBar } from "@/components/BottomNavBar";
import { useTheme } from "react-native-paper";

export default function TabLayout() {
  const theme = useTheme();

  return (
    <Tabs tabBar={(props) => <BottomNavBar {...props} theme={theme} />}>
      <Tabs.Screen
        name="trips"
        options={{
          title: "Wycieczki",
        }}
      />
      <Tabs.Screen
        name="explore"
        options={{
          title: "Eksploruj",
        }}
      />
      <Tabs.Screen
        name="settings"
        options={{
          title: "Ustawienia",
        }}
      />
    </Tabs>
  );
}
