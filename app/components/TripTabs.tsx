import * as React from "react";
import { Text } from "react-native";
import { createMaterialTopTabNavigator } from "@react-navigation/material-top-tabs";

const TopTabNavigator = createMaterialTopTabNavigator();

function CurrentTrips() {
  return <Text style={{ color: "#ffffff" }}>CurrentTrips</Text>;
}

function ArchiveTrips() {
  return <Text style={{ color: "#ffffff" }}>ArchiveTrips</Text>;
}
export function TripTabs() {
  return (
    <TopTabNavigator.Navigator>
      <TopTabNavigator.Screen name="currentTrips" component={CurrentTrips} />
      <TopTabNavigator.Screen name="archive" component={ArchiveTrips} />
    </TopTabNavigator.Navigator>
  );
}
