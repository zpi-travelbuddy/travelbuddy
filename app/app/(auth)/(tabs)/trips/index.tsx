import React from "react";
import TripBrowse from "@/views/TripBrowseView";
import { View } from "react-native";
import { Text, useTheme } from "react-native-paper";

export default function Trips() {
  const theme = useTheme();
  return <TripBrowse />;
}
