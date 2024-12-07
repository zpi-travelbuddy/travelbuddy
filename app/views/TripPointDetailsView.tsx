import { MD3ThemeExtended } from "@/constants/Themes";
import { ScrollView, StyleSheet, View } from "react-native";
import { Text, useTheme } from "react-native-paper";
import { TripPointDetails, TripPointViewModel } from "@/types/TripDayData";
import { TripPointDetailsLabel } from "@/components/TripPointDetailLabel";
import { SimplePlaceCard } from "@/components/TripPointDetailsView/SimplePlaceCard";
import { getMoneyWithCurrency } from "@/utils/CurrencyUtils";
import { useEffect, useLayoutEffect, useMemo, useState } from "react";
import { Place, PlaceViewModel } from "@/types/Place";
import { router, useLocalSearchParams, useNavigation } from "expo-router";
import {
  ADD_NOTIFICATION_ICON_MATERIAL,
  CALENDAR_ADD_ICON_MATERIAL,
  DELETE_ICON,
  EDIT_ICON_MATERIAL,
  REMOVE_NOTIFICATION_ICON_MATERIAL,
} from "@/constants/Icons";
import CustomModal from "@/components/CustomModal";
import {
  formatMinutes,
  formatTimeRange,
  getTimeWithoutSeconds,
} from "@/utils/TimeUtils";
import ActionTextButtons from "@/components/ActionTextButtons";
import { useDeleteTripPoint } from "@/composables/useTripPoint";
import { formatAddress } from "@/utils/TextUtils";
import LoadingView from "./LoadingView";
import { TripDetails } from "@/types/Trip";
import { addEventToMainCalendar } from "@/utils/calendar";
import useTripDayDetails from "@/composables/useTripDay";
import { conditionalItem } from "@/utils/ArrayUtils";
import {
  cancelNotification,
  schedulePushNotification,
} from "@/utils/notifications";
import { useSnackbar } from "@/context/SnackbarContext";
import { useTripNotificationManager } from "@/hooks/useTripNotificationManager";
import { GestureHandlerRootView } from "react-native-gesture-handler";
import NotificationFormBottomSheet from "@/components/NotificationFormBottomSheet";

interface TripPointDetailsViewProps {
  tripPoint: TripPointDetails | null;
  trip: TripDetails | null;
}

const LABELS: Record<string, string> = {
  name: "Nazwa punktu",
  address: "Adres punktu",
  category: "Rodzaj",
  predictedCost: "Przewidywany koszt łączny",
  predictedCostPerPerson: "Przewidywany koszt na osobę",
  startTime: "Godzina rozpoczęcia",
  endTime: "Godzina zakończenia",
  comment: "Komentarz",
};

const convertPlace = (place: Place): PlaceViewModel => {
  const subtitle = [place.city, place.state, place.country]
    .filter(Boolean)
    .join(", ");

  return {
    id: place.id,
    providerId: place.providerId || "",
    title: place.name,
    subtitle: subtitle,
  };
};

const parseTripPoint = (
  tripPoint: TripPointDetails | null,
  trip: TripDetails | null,
): TripPointViewModel => {
  if (!tripPoint) {
    return {};
  }

  const category = tripPoint.category?.name || "Brak danych";

  const address = tripPoint.place
    ? formatAddress(tripPoint.place, false)
    : "Brak danych";

  const predictedCost =
    tripPoint.predictedCost != null
      ? getMoneyWithCurrency(
          tripPoint.predictedCost || 0,
          tripPoint.currencyCode,
        )
      : "Brak danych";

  const predictedCostPerPerson =
    tripPoint.predictedCost != null && trip?.numberOfTravelers
      ? getMoneyWithCurrency(
          tripPoint.predictedCost / trip.numberOfTravelers || 0,
          tripPoint.currencyCode,
        )
      : "Brak danych";

  const startTime = tripPoint.startTime
    ? getTimeWithoutSeconds(tripPoint.startTime)
    : "Brak danych";

  const endTime = tripPoint.endTime
    ? getTimeWithoutSeconds(tripPoint.endTime)
    : "Brak danych";

  const comment = tripPoint.comment || "Brak danych";

  return {
    name: tripPoint.name,
    address,
    category,
    predictedCost,
    predictedCostPerPerson,
    startTime,
    endTime,
    comment,
  };
};

const TripPointDetailsView = ({
  tripPoint,
  trip,
}: TripPointDetailsViewProps) => {
  const theme = useTheme();
  const styles = createStyles(theme as MD3ThemeExtended);
  const { trip_id, day_id } = useLocalSearchParams();
  const navigation = useNavigation();
  const { showSnackbar } = useSnackbar();

  const {
    tripDay,
    loading: tripDayLoading,
    error: tripDayError,
    refetch,
  } = useTripDayDetails(tripPoint?.tripDayId ?? null);

  const {
    isRegistered,
    registerNotification,
    unregisterNotification,
    getNotificationId,
  } = useTripNotificationManager();

  const {
    deleteTripPoint,
    loading: deleteLoading,
    error: deleteError,
  } = useDeleteTripPoint();

  const [loading, setLoading] = useState<boolean>(false);
  const [error, setError] = useState<string>("");
  const [isModalVisible, setIsModalVisible] = useState<boolean>(false);
  const [isNotificationFormVisible, setIsNotificationFormVisible] =
    useState<boolean>(false);

  const parsedTripPoint: TripPointViewModel = useMemo(
    () => parseTripPoint(tripPoint, trip),
    [tripPoint, trip],
  );

  const notificationId = getNotificationId(tripPoint?.id || "");

  const hideModal = () => setIsModalVisible(false);
  const showRemovalModal = () => setIsModalVisible(true);

  const onDeleteTripPoint = async () => {
    await deleteTripPoint(tripPoint?.id);
    router.navigate({
      pathname: `/trips/details/${trip_id}/day/${day_id}`,
      params: { refresh: "true" },
    });
  };

  useEffect(() => {
    setLoading(deleteLoading || tripDayLoading || false);
  }, [deleteLoading, tripDayLoading]);

  useEffect(() => {
    setError(deleteError || tripDayError || "");
  }, [deleteError, tripDayError]);

  useLayoutEffect(() => {
    navigation.setOptions({
      actions: [
        {
          hasMenu: true,
          menuActions: [
            {
              title: "Edytuj",
              icon: EDIT_ICON_MATERIAL,
              color: theme.colors.onSurface,
              onPress: () => {
                console.log("Edit");
                // router.push(`/trips/details/${trip_id}/day/${day_id}/tripPoints/details/${selectedTripPoint.id}`,);
              },
            },
            {
              title: "Dodaj do kalendarza",
              icon: CALENDAR_ADD_ICON_MATERIAL,
              color: theme.colors.onSurface,
              onPress: () => {
                if (!tripDay || !tripPoint) return;
                if (tripDay.date === undefined) return;

                const startDate = new Date(
                  `${tripDay.date}T${tripPoint.startTime}`,
                );
                const endDate = new Date(
                  `${tripDay.date}T${tripPoint.endTime}`,
                );

                const data = {
                  title: tripPoint.name,
                  startDate,
                  endDate,
                  timezone: "GMT+1",
                };

                addEventToMainCalendar(data);
              },
            },
            ...conditionalItem(
              !!tripDay?.date && new Date(tripDay.date) > new Date(),
              {
                title: notificationId
                  ? "Usuń przypomnienie"
                  : "Ustaw przypomnienie",
                icon: notificationId
                  ? REMOVE_NOTIFICATION_ICON_MATERIAL
                  : ADD_NOTIFICATION_ICON_MATERIAL,
                color: theme.colors.onSurface,
                onPress: async () => {
                  if (notificationId && tripPoint) {
                    try {
                      await cancelNotification(notificationId);
                      await unregisterNotification(tripPoint.id);
                    } catch (error: any) {
                      console.error("Error while setting notification", error);
                      showSnackbar("Wystąpił błąd", "error");
                    }
                  } else {
                    console.log(`Dodaj`);
                    setIsNotificationFormVisible(true);
                  }
                },
              },
            ),
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
  }, [tripDay, navigation]);

  const handleScheduleNotification = async (
    minutes: number,
  ): Promise<boolean> => {
    if (!tripPoint) return false;

    if (!tripDay?.date) {
      showSnackbar("Wystąpił błąd", "error");
      return false;
    }

    const parsedDate = new Date(
      new Date(tripDay?.date).getTime() - minutes * 60 * 1000,
    );

    if (parsedDate < new Date()) {
      showSnackbar("Nie można ustawić przypomnienia w przeszłości", "error");
      return false;
    }

    const newNotificationId = await schedulePushNotification(
      tripPoint.name,
      `Zaczyna się za ${formatMinutes(minutes)}`,
      parsedDate,
    );
    await registerNotification(tripPoint.id, newNotificationId);

    return true;
  };

  if (loading) return <LoadingView />;

  if (error) {
    router.back();
    showSnackbar(error?.toString() || "Unknown error", "error");
    return null;
  }

  return (
    <>
      <GestureHandlerRootView>
        <ScrollView style={styles.container}>
          {Object.entries(parsedTripPoint)
            .filter(([key]) => key in LABELS)
            .map(([key, value]) => (
              <TripPointDetailsLabel
                key={key}
                title={LABELS[key]}
                element={
                  <Text style={styles.value}>
                    {value?.toString() || "Brak danych"}
                  </Text>
                }
              />
            ))}
          {
            <TripPointDetailsLabel
              title="Powiązana atrakcja"
              element={
                tripPoint?.place?.providerId ? (
                  <SimplePlaceCard place={convertPlace(tripPoint?.place)} />
                ) : (
                  <Text style={styles.value}>Brak danych</Text>
                )
              }
            />
          }
        </ScrollView>
        <CustomModal visible={isModalVisible} onDismiss={hideModal}>
          <View>
            <Text style={styles.modalTitleText}>
              Czy na pewno chcesz usunąć ten punkt wycieczki?
            </Text>
            <View style={styles.modalContent}>
              <Text style={styles.boldText}>{parsedTripPoint.name}</Text>
              <Text style={styles.modalSubtitle}>
                {formatTimeRange(
                  parsedTripPoint.startTime || "",
                  parsedTripPoint.endTime || "",
                )}
              </Text>
            </View>
            <ActionTextButtons
              onAction1={hideModal}
              onAction2={onDeleteTripPoint}
              action1ButtonLabel="Anuluj"
              action2ButtonLabel="Usuń"
              action1Icon={undefined}
              action2Icon={undefined}
            />
          </View>
        </CustomModal>

        <NotificationFormBottomSheet
          isVisible={isNotificationFormVisible}
          onClose={() => setIsNotificationFormVisible(false)}
          onCancel={() => {
            setIsNotificationFormVisible(false);
          }}
          onSave={async (minutes) => {
            const didSchedule = await handleScheduleNotification(minutes);
            if (didSchedule) {
              setIsNotificationFormVisible(false);
            }
          }}
        />
      </GestureHandlerRootView>
    </>
  );
};

export default TripPointDetailsView;

const createStyles = (theme: MD3ThemeExtended) =>
  StyleSheet.create({
    container: {
      flex: 1,
      backgroundColor: theme.colors.background,
    },
    value: {
      ...theme.fonts.titleMedium,
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
    bottomSheetText: {
      marginBottom: 10,
      marginTop: -10,
      color: theme.colors.onSurface,
      ...theme.fonts.bodyMedium,
    },
  });
