import {
  StyleSheet,
  View,
  Image,
  Dimensions,
  ScrollView,
  ActivityIndicator,
} from "react-native";
import React, { useMemo, useState, useCallback } from "react";
import TripDetailLabel from "@/components/TripDetailLabel";
import { FAB, MD3Theme, useTheme } from "react-native-paper";
import { CALENDAR_ICON } from "@/constants/Icons";
import { router, useLocalSearchParams } from "expo-router";
import SingleDatePickerModal from "@/components/SingleDatePickerModal";
import { CalendarDate } from "react-native-paper-dates/lib/typescript/Date/Calendar";
import useTripDetails from "@/composables/useTripDetails";
import { TripDay } from "@/types/Trip";
import { useSnackbar } from "@/context/SnackbarContext";

const { height, width } = Dimensions.get("window");

const TripDetailsView = () => {
  const theme = useTheme();
  const styles = useMemo(() => createStyles(theme), [theme]);
  const [dateModalVisible, setDateModalVisible] = useState(false);

  const params = useLocalSearchParams();
  const id = "234455";

  const { tripDetails, loading, error } = useTripDetails(id as string);

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
    return new Map(
      tripDetails?.tripDays.map((day: TripDay) => [day.date, day.id]) || [],
    );
  }, [tripDetails]);

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
    [setDateModalVisible, dateToIdMap],
  );

  const { showSnackbar } = useSnackbar();

  if (loading) {
    return (
      <View style={styles.loadingContainer}>
        <ActivityIndicator size="large" color={theme.colors.primary} />
      </View>
    );
  }

  if (error) {
    showSnackbar(error?.toString() || "Unknown error", "error");
    router.back();
    return null; // Zapewnia, że renderowanie nie jest przerywane w tym momencie.
  }
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

        {tripDetails &&
          Object.entries(tripDetails).map(([key, value]) => (
            <TripDetailLabel
              key={key}
              title={labels[key] || key}
              value={value.toString()}
            />
          ))}
      </ScrollView>
      {tripDetails && (
        <SingleDatePickerModal
          visible={dateModalVisible}
          startDate={tripDetails?.startDate}
          endDate={tripDetails?.endDate}
          onDismiss={handleDismiss}
          onConfirm={handleConfirm}
        />
      )}
      ;
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
    loadingContainer: {
      flex: 1,
      justifyContent: "center",
      alignItems: "center",
      backgroundColor: theme.colors.background,
    },
    errorContainer: {
      flex: 1,
      justifyContent: "center",
      alignItems: "center",
      backgroundColor: theme.colors.background,
    },
    errorText: {
      color: theme.colors.error,
      fontSize: 16,
    },
  });
