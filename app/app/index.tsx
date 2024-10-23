import { BottomNavigationTabs } from "@/components/BottomNavigationTabs";
import React from "react";
import { Provider, useTheme } from "react-native-paper";
import { createStackNavigator } from "@react-navigation/stack";
import TripDetails from "@/views/TripDetails";

const Stack = createStackNavigator();

export default function Index() {
  const theme = useTheme();

  return (
    <Provider theme={theme}>
      <Stack.Navigator initialRouteName="TripBrowse">
        <Stack.Screen
          name="Home"
          component={BottomNavigationTabs}
          options={{ title: "Wycieczki" }}
        />
        <Stack.Screen
          name="TripDetails"
          component={TripDetails}
          options={{ title: "Szczegóły wycieczki" }}
        />
      </Stack.Navigator>
    </Provider>
  );
}
