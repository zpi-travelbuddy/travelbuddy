import { StyleSheet, View, Image, Dimensions, ScrollView } from "react-native";
import React, { useMemo, useState, useCallback } from "react";
import TripDetailLabel from "@/components/TripDetailLabel";
import { FAB, MD3Theme, useTheme } from "react-native-paper";
import { CALENDAR_ICON } from "@/constants/Icons";
import { router, useLocalSearchParams } from "expo-router";
import SingleDatePickerModal from "@/components/SingleDatePickerModal";
import { CalendarDate } from "react-native-paper-dates/lib/typescript/Date/Calendar";

const { height, width } = Dimensions.get("window");

const TripDetailsView = () => {
  const theme = useTheme();
  const styles = useMemo(() => createStyles(theme), [theme]);
  const [dateModalVisible, setDateModalVisible] = useState(false);

  const params = useLocalSearchParams();
  const { id } = params;

  const trip = {
    tripName: "Wycieczka do Londynu",
    tripDate: "10.06.2024 - 15.06.2024",
    destination: "London, UK",
    numberOfTripPoints: "2",
    numberOfPeople: "3",
    cost: "4 700,00 PLN",
    budget: "6 000,00 PLN",
    preferenceProfileName: "Zwiedzanie i jedzenie",
    convenienceProfileName: "Potrzebuję internetu",
  };

  // This will be fetched from the API
  const startDate = "2024-06-10";
  const endDate = "2024-06-15";

  const tripDays = [
    {
      id: "1",
      tripId: "1",
      date: "2024-06-10",
    },
    {
      id: "2",
      tripId: "1",
      date: "2024-06-11",
    },
    {
      id: "3",
      tripId: "1",
      date: "2024-06-12",
    },
  ];

  const labels: Record<string, string> = {
    tripName: "Nazwa wycieczki",
    tripDate: "Termin wycieczki",
    destination: "Cel wycieczki",
    numberOfTripPoints: "Liczba punktów wycieczki",
    numberOfPeople: "Liczba osób",
    cost: "Całkowity koszt wycieczki",
    budget: "Budżet wycieczki",
    preferenceProfileName: "Profil preferencji",
    convenienceProfileName: "Profil udogodnień",
  };

  const dateToIdMap = useMemo(() => {
    return new Map(tripDays.map((day) => [day.date, day.id]));
  }, [tripDays]);

  const handlePress = () => {
    setDateModalVisible(true);
  };

  const handleDismiss = useCallback(() => {
    setDateModalVisible(false);
  }, [setDateModalVisible]);

  const handleConfirm = useCallback(
    ({ date }: { date: CalendarDate }) => {
      const formattedDate = (date as Date).toISOString().split("T")[0];
      const tripDayId = dateToIdMap.get(formattedDate);
      if (tripDayId) {
        console.log("Redirecting to day with id " + tripDayId);
        setDateModalVisible(false);
        router.navigate(`/trips/details/id/day/${tripDayId}`);
      } else {
        console.error("Day not found");
      }
    },
    [setDateModalVisible],
  );

  return (
    <View style={styles.container}>
      <ScrollView contentContainerStyle={styles.scrollContent}>
        <Image
          source={{
            uri: "https://upload.wikimedia.org/wikipedia/commons/1/1a/Big_Ben..JPG",
          }}
          style={styles.image}
          resizeMode="cover"
        />

        {Object.entries(trip).map(([key, value]) => (
          <TripDetailLabel key={key} title={labels[key] || key} value={value} />
        ))}
      </ScrollView>
      <SingleDatePickerModal
        visible={dateModalVisible}
        startDate={startDate}
        endDate={endDate}
        onDismiss={handleDismiss}
        onConfirm={handleConfirm}
      />
      <FAB
        color={theme.colors.onPrimary}
        style={styles.fab}
        icon={CALENDAR_ICON}
        customSize={width * 0.25}
        onPress={handlePress}
      />
    </View>
  );
};

export default TripDetailsView;

const createStyles = (theme: MD3Theme) =>
  StyleSheet.create({
    container: {
      flex: 1,
      backgroundColor: theme.colors.background,
    },
    scrollContent: {
      alignItems: "center",
      paddingBottom: 25,
    },
    fab: {
      backgroundColor: theme.colors.primary,
      position: "absolute",
      bottom: width * 0.85,
      right: 16,
      borderRadius: 10000,
    },
    image: {
      marginBottom: 25,
      width: "100%",
      height: height * 0.2,
    },
  });
