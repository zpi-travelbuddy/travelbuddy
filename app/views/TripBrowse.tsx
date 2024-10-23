import { SafeAreaView, StyleSheet, Text, View } from "react-native";
import React from "react";
import { TripCard } from "@/components/TripCard";
import { TripTabs } from "@/components/TripTabs";
import { useTheme } from "react-native-paper";

const TripBrowse = () => {
  const theme = useTheme();
  return (
    <SafeAreaView>
      <View
        style={{
          flex: 1,
          justifyContent: "center",
          alignItems: "center",
        }}
      >
        <TripTabs />
        <TripCard
          title="Wycieczka do Milicza"
          subtitle="10.06.2024 - 15.06.2024"
          imageUri="https://picsum.photos/888"
        />
      </View>
    </SafeAreaView>
  );
};

export default TripBrowse;

const styles = StyleSheet.create({});
