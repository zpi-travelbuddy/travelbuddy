import { StyleSheet, Text, View } from "react-native";
import React from "react";
import AddingTripPointView from "@/views/AddingTripPointView";
import { useLocalSearchParams } from "expo-router";

export default function Create() {
  const params = useLocalSearchParams();
  const { id, day_id } = params;
  console.log(`ID: ${id}`);
  console.log(`Day ID: ${day_id}`);
  return <AddingTripPointView />;
}
