import { StyleSheet, View, Image, Dimensions, ScrollView } from "react-native";
import React, { useMemo, useState, useCallback, useEffect } from "react";
import TripDetailLabel from "@/components/TripDetailLabel";
import { FAB, useTheme } from "react-native-paper";
import { CALENDAR_ICON } from "@/constants/Icons";
import { router } from "expo-router";
import SingleDatePickerModal from "@/components/SingleDatePickerModal";
import { CalendarDate } from "react-native-paper-dates/lib/typescript/Date/Calendar";
import useTripDetails from "@/composables/useTripDetails";
import { TripDay, TripViewModel } from "@/types/Trip";
import { useSnackbar } from "@/context/SnackbarContext";
import { convertTripResponseToViewModel } from "@/converters/tripConverters";
import usePlaceDetails from "@/composables/usePlace";
import LoadingView from "./LoadingView";
import { MD3ThemeExtended } from "@/constants/Themes";

const { height, width } = Dimensions.get("window");

const TripDetailsView = () => {
  const theme = useTheme();
  const styles = useMemo(
    () => createStyles(theme as MD3ThemeExtended),
    [theme],
  );
  const [dateModalVisible, setDateModalVisible] = useState(false);
  const [tripViewModel, setTripViewModel] = useState<TripViewModel | undefined>(
    undefined,
  );

  // const params = useLocalSearchParams();
  // const { trip_id } = params;
  const trip_id: string = "77b6b9bd-99d8-4b56-b74d-ed69c3a1238a"; // Temporary solution

  const {
    tripDetails,
    tripSummary,
    loading: tripLoading,
    error: tripError,
    refetch: tripRefetch,
  } = useTripDetails(trip_id as string);

  const {
    placeDetails: destinationDetails,
    loading: destinationLoading,
    error: destinationError,
    refetch: destinationRefetch,
  } = usePlaceDetails(tripDetails?.destinationId);

  const loading = useMemo(() => {
    return tripLoading || destinationLoading;
  }, [tripLoading, destinationLoading]);

  const error = useMemo(() => {
    return tripError || destinationError || null;
  }, [tripError, destinationError]);

  const { showSnackbar } = useSnackbar();

  useEffect(() => {
    if (tripDetails) {
      setTripViewModel(
        convertTripResponseToViewModel(
          tripDetails,
          tripSummary,
          destinationDetails,
        ),
      );
    }
  }, [tripDetails, tripSummary, destinationDetails]);

  const labels: Record<string, string> = {
    name: "Nazwa wycieczki",
    dateRange: "Termin wycieczki",
    destination: "Cel wycieczki",
    numberOfTripPoints: "Liczba punktów wycieczki",
    numberOfTravelers: "Liczba osób",
    predictedCost: "Przewidywany koszt wycieczki",
    budget: "Budżet wycieczki",
    categoryProfileName: "Profil preferencji",
    conditionProfileName: "Profil udogodnień",
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
        router.navigate(`/trips/details/${trip_id}/day/${tripDayId}`);
      } else {
        console.error("Day not found");
      }
    },
    [setDateModalVisible, dateToIdMap],
  );

  if (loading) {
    return <LoadingView />;
  }

  if (error) {
    router.back();
    showSnackbar(error?.toString() || "Unknown error", "error");
    return null;
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

        <View style={styles.detailsContainer}>
          <View style={styles.entriesContainer}>
            {tripViewModel &&
              Object.entries(tripViewModel)
                .filter(([key]) => key in labels)
                .map(([key, value]) => (
                  <TripDetailLabel
                    key={key}
                    title={labels[key]}
                    value={value ? value.toString() : ""}
                  />
                ))}
          </View>

          <FAB
            color={theme.colors.onPrimary}
            style={styles.fab}
            icon={CALENDAR_ICON}
            customSize={width * 0.25}
            onPress={handlePress}
          />
        </View>
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
    </View>
  );
};

export default TripDetailsView;

const createStyles = (theme: MD3ThemeExtended) =>
  StyleSheet.create({
    container: {
      flex: 1,
      backgroundColor: theme.colors.background,
    },
    scrollContent: {
      alignItems: "center",
      paddingBottom: 25,
    },
    detailsContainer: {
      width: "100%",
      flexDirection: "row",
      justifyContent: "space-between",
      alignItems: "center",
      position: "relative",
    },
    entriesContainer: {
      flex: 1,
      paddingRight: 16,
    },
    fab: {
      backgroundColor: theme.colors.primary,
      position: "absolute",
      top: 16,
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
