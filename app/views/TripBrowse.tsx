import { SafeAreaView, StyleSheet, TextInput, View } from "react-native";
import React, { useState } from "react";
import { TripCard } from "@/components/TripCard";
// import { TripTabs } from "@/components/TripTabs";
import { useTheme, FAB } from "react-native-paper";
import { ScrollView } from "react-native";

const TripBrowse = () => {
  const theme = useTheme();
  const [searchQuery, setSearchQuery] = useState("");

  const trips = [
    {
      title: "Wycieczka do Milicza",
      subtitle: "10.06.2024 - 15.06.2024",
      imageUri: "https://picsum.photos/888",
    },
    {
      title: "Wycieczka do Wrocławia",
      subtitle: "20.06.2024 - 25.06.2024",
      imageUri: "https://picsum.photos/889",
    },
    {
      title: "Wycieczka do Krakowa",
      subtitle: "15.07.2024 - 20.07.2024",
      imageUri: "https://picsum.photos/890",
    },
    {
      title: "Wycieczka do Zakopanego",
      subtitle: "01.08.2024 - 07.08.2024",
      imageUri: "https://picsum.photos/891",
    },
  ];

  const filteredTrips = trips.filter((trip) =>
    trip.title.toLowerCase().includes(searchQuery.toLowerCase()),
  );

  const styles = StyleSheet.create({
    inputView: {
      width: "100%",
      alignItems: "center",
      padding: 5,
      borderRadius: 20,
    },
    safeArea: {
      flex: 1,
      justifyContent: "center",
      alignItems: "center",
      backgroundColor: theme.colors.surface,
    },
    scrollContainer: {
      flexGrow: 1,
      alignItems: "center",
    },
    input: {
      height: 40,
      width: "90%",
      backgroundColor: theme.colors.elevation.level2,
      borderRadius: 8,
      marginVertical: 10,
      marginLeft: 10,
      marginHorizontal: 10,
      padding: 10,
      borderTopLeftRadius: 20,
      borderTopRightRadius: 20,
      borderBottomLeftRadius: 20,
      borderBottomRightRadius: 20,
    },
    fab: {
      position: "absolute",
      margin: 16,
      right: 0,
      bottom: 0,
      backgroundColor: theme.colors.primary,
    },
  });

  return (
    <SafeAreaView style={styles.safeArea}>
      <View style={styles.inputView}>
        <TextInput
          style={styles.input}
          placeholder="Wyszukaj wycieczki..."
          value={searchQuery}
          onChangeText={(text) => setSearchQuery(text)}
        />
      </View>
      <ScrollView contentContainerStyle={styles.scrollContainer}>
        {filteredTrips.map((trip, index) => (
          <TripCard
            key={index}
            title={trip.title}
            subtitle={trip.subtitle}
            imageUri={trip.imageUri}
          />
        ))}
      </ScrollView>
      <FAB
        style={styles.fab}
        icon="plus"
        color={theme.colors.onPrimary}
        label="Dodaj"
        onPress={() => {
          console.log("FAB Clicked");
        }}
      />
    </SafeAreaView>
  );
};

export default TripBrowse;
