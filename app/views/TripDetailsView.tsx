import { StyleSheet, View, Image, Dimensions, ScrollView } from "react-native";
import React, {
  useMemo,
  useState,
  useCallback,
  useEffect,
  useLayoutEffect,
} from "react";
import TripDetailLabel from "@/components/TripDetailLabel";
import { FAB, Text, useTheme } from "react-native-paper";
import { CALENDAR_ICON, DELETE_ICON } from "@/constants/Icons";
import { router, useLocalSearchParams, useNavigation } from "expo-router";
import SingleDatePickerModal from "@/components/SingleDatePickerModal";
import { CalendarDate } from "react-native-paper-dates/lib/typescript/Date/Calendar";
import useTripDetails from "@/composables/useTripDetails";
import { TripDay, TripViewModel } from "@/types/Trip";
import { useSnackbar } from "@/context/SnackbarContext";
import { convertTripDetailsToViewModel } from "@/converters/tripConverters";
import usePlaceDetails from "@/composables/usePlace";
import LoadingView from "./LoadingView";
import { MD3ThemeExtended } from "@/constants/Themes";
import CustomModal from "@/components/CustomModal";
import ActionTextButtons from "@/components/ActionTextButtons";
import { useAuth } from "@/app/ctx";

const { height, width } = Dimensions.get("window");

const TripDetailsView = () => {
  const { api } = useAuth();

  const theme = useTheme();
  const styles = useMemo(
    () => createStyles(theme as MD3ThemeExtended),
    [theme],
  );
  const [dateModalVisible, setDateModalVisible] = useState(false);
  const [tripViewModel, setTripViewModel] = useState<TripViewModel | undefined>(
    undefined,
  );

  // Removal modal
  const [isModalVisible, setIsModalVisible] = useState(false);

  const hideModal = () => setIsModalVisible(false);

  const showRemovalModal = () => setIsModalVisible(true);

  const deleteTrip = async (tripId: string | undefined) => {
    if (!tripId) return;

    hideModal();
    try {
      await api!.delete(`/trips/${tripId}`);
      router.navigate({ pathname: "/trips", params: { refresh: "true" } });
      showSnackbar("Usunięto wycieczkę!");
    } catch (error: any) {
      showSnackbar("Wystąpił błąd podczas usuwania wycieczki", "error");
    }
  };
  // ---

  const navigation = useNavigation();

  const { trip_id } = useLocalSearchParams();

  const {
    tripDetails,
    tripSummary,
    loading: tripLoading,
    error: tripError,
    refetch: refetchTrip,
  } = useTripDetails(trip_id as string);

  const {
    placeDetails: destinationDetails,
    loading: destinationLoading,
    error: destinationError,
    refetch: refetchDestination,
  } = usePlaceDetails(tripDetails?.destinationId);

  const loading = useMemo(() => {
    return tripLoading || destinationLoading;
  }, [tripLoading, destinationLoading]);

  const error = useMemo(() => {
    return tripError || destinationError || null;
  }, [tripError, destinationError]);

  const { showSnackbar } = useSnackbar();

  useLayoutEffect(() => {
    navigation.setOptions({
      actions: [
        {
          hasMenu: true,
          menuActions: [
            {
              title: "Usuń",
              icon: DELETE_ICON,
              color: theme.colors.error,
              onPress: () => {
                showRemovalModal();
              },
            },
          ],
        },
      ],
    });
  }, [navigation]);

  useEffect(() => {
    if (tripDetails) {
      setTripViewModel(
        convertTripDetailsToViewModel(
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
      const fixedDate = date as Date;
      const formattedDate = fixedDate.toISOString().split("T")[0];
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
    return <LoadingView transparent={false} />;
  }

  if (error) {
    router.back();
    showSnackbar(error?.toString() || "Unknown error", "error");
    return null;
  }
  return (
    <>
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
      <CustomModal visible={isModalVisible} onDismiss={hideModal}>
        <View>
          <Text style={styles.modalTitleText}>
            Czy na pewno chcesz usunąć tą wycieczkę?
          </Text>
          <View style={styles.modalContent}>
            <Text style={styles.boldText}>{tripViewModel?.name}</Text>
            <Text style={styles.modalSubtitle}>{tripViewModel?.dateRange}</Text>
          </View>
          <ActionTextButtons
            onAction1={hideModal}
            onAction2={() => deleteTrip(tripDetails?.id)}
            action1ButtonLabel="Anuluj"
            action2ButtonLabel="Usuń"
            action1Icon={undefined}
            action2Icon={undefined}
          />
        </View>
      </CustomModal>
    </>
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
    modalTitleText: {
      ...theme.fonts.titleLarge,
      color: theme.colors.onSurface,
    },
    modalContent: {
      marginVertical: 20,
    },
    boldText: {
      fontWeight: "bold",
      color: theme.colors.onSurface,
    },
    modalSubtitle: {
      color: theme.colors.onSurface,
    },
  });
