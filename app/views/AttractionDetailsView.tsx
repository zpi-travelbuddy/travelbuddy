/* eslint-disable @typescript-eslint/no-explicit-any */
import {
  StyleSheet,
  View,
  Image,
  Dimensions,
  ScrollView,
  Linking,
  FlatList,
} from "react-native";
import { useCallback, useEffect, useMemo, useState } from "react";
import { useTheme, Text } from "react-native-paper";
import { ADD_ICON, DEFAULT_ICON_SIZE, LOCATION_ICON } from "@/constants/Icons";
import ActionButtons from "@/components/ActionButtons";
import { MD3ThemeExtended } from "@/constants/Themes";
import {
  displayCost,
  displayTime,
  formatAddress,
  truncateText,
} from "@/utils/TextUtils";
import StarRatingDisplayComponent from "@/components/StarRatingDisplayComponent";
import IconComponent from "@/components/IconComponent";
import usePlaceDetails, { useAttractionDetails } from "@/composables/usePlace";
import LoadingView from "./LoadingView";
import { useFocusEffect, useLocalSearchParams, useRouter } from "expo-router";
import { useSnackbar } from "@/context/SnackbarContext";
import ConditionIcons from "@/components/ConditionIcons";
import { CategoryIcons, CategoryLabelsForTripCategory } from "@/types/Profile";
import { createLocationURL } from "@/utils/maps";
import { findAttractionCategory } from "@/utils/CategoryUtils";
import { formatMinutes, getTotalMinutesFromTimestamp } from "@/utils/TimeUtils";
import CustomModal from "@/components/CustomModal";
import { RenderItem } from "@/components/RenderItem";
import ActionTextButtons from "@/components/ActionTextButtons";
import { useTripDetails } from "@/composables/useTripDetails";
import { useAuth } from "@/app/ctx";
import SingleDatePickerModal from "@/components/SingleDatePickerModal";
import { CalendarDate } from "react-native-paper-dates/lib/typescript/Date/Calendar";
import { formatDateToISO } from "@/utils/TimeUtils";
import { TripDay } from "@/types/Trip";

const { height, width } = Dimensions.get("window");

const AttractionDetailsView = () => {
  const theme = useTheme() as MD3ThemeExtended;
  const styles = useMemo(() => createStyles(theme), [theme]);
  const router = useRouter();

  const { showSnackbar } = useSnackbar();

  const { api } = useAuth();

  const params = useLocalSearchParams();
  const { place_id, trip_id, day_id, date, custom_place_id } = params;

  // Trip and day selection
  const [selectedTripId, setSelectedTripId] = useState<string | null>(null);

  const [currentTrips, setCurrentTrips] = useState<any[]>([]);

  const [isTripSelectorVisible, setIsTripSelectorVisible] = useState(false);
  const [isDaySelectorVisible, setIsDaySelectorVisible] = useState(false);

  const {
    tripDetails,
    loading: tripLoading,
    error: tripError,
    refetch: tripFetch,
  } = useTripDetails(selectedTripId as string, { immediate: false });

  const fetchCurrentTrips = async () => {
    try {
      const response = await api!.get("/trips/current");
      setCurrentTrips(response.data);
    } catch (error: any) {
      console.log(error.response.data);
    }
  };

  useFocusEffect(
    useCallback(() => {
      if (!trip_id) {
        fetchCurrentTrips();
      }
    }, [trip_id]),
  );

  const handleDismissTripModal = () => {
    setIsTripSelectorVisible(false);
    setSelectedTripId(null);
  };

  const handleTripSelection = (item: any) => {
    setSelectedTripId(item.id);
  };

  const handleConfirmTrip = () => {
    if (selectedTripId) {
      tripFetch();
      setIsTripSelectorVisible(false);
      setIsDaySelectorVisible(true);
    }
  };

  const handleDismissDatePicker = useCallback(() => {
    setIsDaySelectorVisible(false);
    setSelectedTripId(null);
  }, [setIsDaySelectorVisible]);

  const dateToIdMap = useMemo(() => {
    return new Map(
      tripDetails?.tripDays.map((day: TripDay) => [day.date, day.id]) || [],
    );
  }, [tripDetails]);

  const handleConfirmDatePicker = useCallback(
    ({ date }: { date: CalendarDate }) => {
      const fixedDate = date as Date;
      const formattedDate = formatDateToISO(fixedDate);
      const tripDayId = dateToIdMap.get(formattedDate);
      if (tripDetails?.id && tripDayId) {
        setIsDaySelectorVisible(false);
        router.navigate({
          // @ts-ignore
          pathname: `/explore/create`,
          params: {
            trip_id: tripDetails?.id,
            day_id: tripDayId,
            date: fixedDate.toLocaleDateString(),
            attractionProviderId: place_id,
          },
        });
      } else {
        console.error("Day not found");
      }
    },
    [setIsDaySelectorVisible, place_id, tripDetails, dateToIdMap],
  );

  // ---

  const { placeDetails, loading, error } = custom_place_id
    ? usePlaceDetails(custom_place_id as string)
    : useAttractionDetails(place_id as string);

  if (error) {
    router.back();
    showSnackbar(error?.toString() || "Unknown error", "error");
    return null;
  }

  const onLocationButtonPress = async () => {
    if (!placeDetails) {
      console.error("Place details not available");
      return;
    }

    const name = placeDetails.name;
    const [latitude, longitude] = [
      placeDetails.latitude,
      placeDetails.longitude,
    ];

    const url = createLocationURL(latitude, longitude, name);

    try {
      await Linking.openURL(url);
    } catch (error: any) {
      console.error(error);
    }
  };

  const onAddButtonPress = () => {
    if (trip_id && day_id && date && place_id) {
      router.navigate({
        // @ts-ignore
        pathname: `/trips/details/${trip_id}/day/${day_id}/tripPoints/create`,
        params: {
          attractionProviderId: place_id,
          date: date,
        },
      });
    } else {
      setIsTripSelectorVisible(true);
    }
  };
  if (!placeDetails) {
    return <LoadingView transparent={false} />;
  }
  return (
    <>
      <View style={styles.container}>
        <ScrollView contentContainerStyle={styles.scrollContent}>
          <View style={styles.labelContainer}>
            <Text variant="headlineSmall">{placeDetails.name}</Text>
            <Text style={styles.label}>{formatAddress(placeDetails)}</Text>

            <StarRatingDisplayComponent
              style={styles.starRatingPadding}
              rating={placeDetails?.averageRating || 0.0}
              editable={false}
            />

            <Text style={styles.title}>Rodzaj</Text>
            <View style={styles.rowContainer}>
              <IconComponent
                source={CategoryIcons[findAttractionCategory(placeDetails)]}
                iconSize={DEFAULT_ICON_SIZE}
                color={theme.colors.onSurface}
                backgroundColor={theme.colors.primaryContainer}
              />
              <Text style={styles.categoryLabel}>
                {
                  CategoryLabelsForTripCategory[
                    findAttractionCategory(placeDetails)
                  ]
                }
              </Text>
            </View>

            <Text style={styles.title}>Udogodnienia</Text>

            <ConditionIcons
              placeConditions={placeDetails.conditions}
              style={styles.space}
              iconColor={theme.colors.onSurface}
            />

            <Text style={styles.title}>Średni koszt na osobę</Text>
            <Text style={styles.label}>
              {`${displayCost(placeDetails.averageCostPerPerson)} ${placeDetails.averageCostPerPerson > 0 ? "PLN" : ""}`}
            </Text>

            <Text style={styles.title}>Średni czas pobytu</Text>
            <Text style={styles.label}>
              {placeDetails.averageTimeSpent
                ? formatMinutes(
                    getTotalMinutesFromTimestamp(placeDetails.averageTimeSpent),
                  )
                : "Brak informacji"}
            </Text>
          </View>
        </ScrollView>

        <ActionButtons
          onAction1={onLocationButtonPress}
          action1ButtonLabel={"Mapa"}
          onAction2={onAddButtonPress}
          action2ButtonLabel={"Dodaj"}
          action1Icon={LOCATION_ICON}
          action2Icon={ADD_ICON}
        />
      </View>
      <LoadingView show={loading} transparent={false} />
      <CustomModal
        visible={isTripSelectorVisible}
        onDismiss={handleDismissTripModal}
      >
        <Text style={styles.modalHeadline} variant="headlineSmall">
          Wybierz wycieczkę
        </Text>
        <FlatList
          style={styles.tripList}
          data={currentTrips}
          renderItem={({ item }) => (
            <RenderItem
              item={item}
              isSelected={selectedTripId === item.id}
              onSelect={handleTripSelection}
              renderContent={(item: any) => truncateText(item.name, 25)}
            />
          )}
          keyExtractor={(item) => item.id}
          ItemSeparatorComponent={() => <View />}
          ListEmptyComponent={<Text>Brak dostępnych wycieczek</Text>}
        />
        <ActionTextButtons
          onAction1={handleDismissTripModal}
          onAction2={handleConfirmTrip}
          action1ButtonLabel="Anuluj"
          action2ButtonLabel="OK"
          action1Icon={undefined}
          action2Icon={undefined}
        />
      </CustomModal>
      {tripDetails && (
        <SingleDatePickerModal
          visible={isDaySelectorVisible}
          startDate={tripDetails?.startDate}
          endDate={tripDetails?.endDate}
          onDismiss={handleDismissDatePicker}
          onConfirm={handleConfirmDatePicker}
        />
      )}
    </>
  );
};

export default AttractionDetailsView;

const createStyles = (theme: MD3ThemeExtended) =>
  StyleSheet.create({
    space: {
      paddingTop: 10,
    },
    doubleSpace: {
      paddingTop: 20,
    },
    rowContainer: {
      flexDirection: "row",
      alignItems: "center",
      flex: 3,
      paddingTop: 10,
    },
    container: {
      flex: 1,
      backgroundColor: theme.colors.background,
    },
    labelContainer: {
      paddingHorizontal: 20,
    },
    scrollContent: {},
    fab: {
      backgroundColor: theme.colors.primary,
      position: "absolute",
      bottom: width * 0.85,
      right: 16,
      borderRadius: 10000,
    },
    image: {
      marginVertical: 25,
      width: "100%",
      height: height * 0.2,
    },
    label: {
      ...theme.fonts.titleMedium,
      color: theme.colors.onBackground,
    },
    categoryLabel: {
      ...theme.fonts.bodyLarge,
      color: theme.colors.onBackground,
      marginLeft: 10,
    },
    title: {
      ...theme.fonts.bodyMedium,
      marginBottom: 4,
      marginTop: 10,
    },
    starRatingPadding: {
      paddingVertical: 10,
    },
    modalHeadline: {
      alignSelf: "flex-start",
      marginBottom: 20,
    },
    tripList: {
      maxHeight: 200,
      marginBottom: 20,
    },
  });
