import { MD3ThemeExtended } from "@/constants/Themes";
import { ScrollView, StyleSheet, View } from "react-native";
import { Divider, Text, useTheme } from "react-native-paper";
import {
  TripPointDetails,
  TripPointStatus,
  TripPointViewModel,
} from "@/types/TripDayData";
import { TripPointDetailsLabel } from "@/components/TripPointDetailLabel";
import { getMoneyWithCurrency } from "@/utils/CurrencyUtils";
import {
  useCallback,
  useEffect,
  useLayoutEffect,
  useMemo,
  useState,
} from "react";
import {
  Link,
  router,
  useFocusEffect,
  useLocalSearchParams,
  useNavigation,
} from "expo-router";
import {
  ADD_NOTIFICATION_ICON_MATERIAL,
  CALENDAR_ADD_ICON_MATERIAL,
  DEFAULT_ICON_SIZE,
  DELETE_ICON,
  EDIT_ICON_MATERIAL,
  FILL_SURVEY_ICON_MATERIAL,
  REMOVE_NOTIFICATION_ICON_MATERIAL,
} from "@/constants/Icons";
import CustomModal from "@/components/CustomModal";
import {
  formatMinutes,
  formatMinutesInWords,
  formatTimeRange,
  getTimeWithoutSeconds,
  getTotalMinutesFromTimestamp,
} from "@/utils/TimeUtils";
import ActionTextButtons from "@/components/ActionTextButtons";
import {
  useDeleteTripPoint,
  useGetTripPoint,
} from "@/composables/useTripPoint";
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
import useTripNotificationManager from "@/hooks/useTripNotificationManager";
import { GestureHandlerRootView } from "react-native-gesture-handler";
import NotificationFormBottomSheet from "@/components/NotificationFormBottomSheet";
import { useTripDetails } from "@/composables/useTripDetails";
import StarRatingDisplayComponent from "@/components/StarRatingDisplayComponent";
import IconComponent from "@/components/IconComponent";
import {
  CategoryIcons,
  DEFAULT_CATEGORY_NAME,
  CategoryLabelsForTripCategory,
} from "@/types/Profile";

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

const REVIEW_LABELS: Record<string, string> = {
  actualCostPerPerson: "Koszt na osobę",
  actualTimeSpent: "Czas pobytu",
};

const parseTripPoint = (
  tripPoint: TripPointDetails | undefined,
  trip: TripDetails | undefined,
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
  const actualCostPerPerson: string =
    tripPoint.review?.actualCostPerPerson && tripPoint.review?.currencyCode
      ? `${tripPoint.review?.actualCostPerPerson} ${tripPoint.review?.currencyCode}`
      : "Brak danych";
  const actualTimeSpent: string = tripPoint.review?.actualTimeSpent
    ? `${formatMinutesInWords(getTotalMinutesFromTimestamp(tripPoint.review?.actualTimeSpent))}`
    : "Brak danych";
  const rating = tripPoint.review?.rating;

  return {
    name: tripPoint.name,
    address,
    category,
    predictedCost,
    predictedCostPerPerson,
    startTime,
    endTime,
    comment,
    review: {
      actualTimeSpent,
      actualCostPerPerson,
      rating,
    },
  };
};

const OpeningsHours = ({
  openingTime,
  closingTime,
  startTime,
  endTime,
}: {
  openingTime: string | undefined;
  closingTime: string | undefined;
  startTime: string | undefined;
  endTime: string | undefined;
}) => {
  const theme = useTheme();
  const styles = createStyles(theme as MD3ThemeExtended);

  let fitsInTripPoint = false;

  if (startTime && openingTime && endTime && closingTime) {
    if (openingTime <= closingTime) {
      fitsInTripPoint = startTime >= openingTime && endTime <= closingTime;
    } else {
      fitsInTripPoint =
        (startTime >= "00:00:00" && endTime <= closingTime) ||
        (startTime >= openingTime && endTime <= "24:00:00");
    }
  }

  if (!openingTime || !closingTime) {
    return <Text style={styles.value}>Brak danych</Text>;
  }

  return (
    <Text style={[fitsInTripPoint ? {} : styles.warning, styles.value]}>
      {getTimeWithoutSeconds(openingTime)} -{" "}
      {getTimeWithoutSeconds(closingTime)}
      {fitsInTripPoint ? "" : "(wizyta poza godzinami otwarcia!)"}
    </Text>
  );
};

const TripPointDetailsView = () => {
  const theme = useTheme();
  const styles = createStyles(theme as MD3ThemeExtended);
  const { trip_id, trip_point_id, day_id, date, refresh } =
    useLocalSearchParams();
  const navigation = useNavigation();
  const { showSnackbar } = useSnackbar();

  const {
    tripPointDetails: tripPoint,
    loading: tripPointLoading,
    error: tripPointError,
    refetch: refetchTripPoint,
  } = useGetTripPoint(trip_point_id as string);

  const {
    tripDetails: trip,
    loading: tripLoading,
    error: tripError,
    refetch: refetchTrip,
  } = useTripDetails(trip_id as string);

  const {
    tripDay,
    loading: tripDayLoading,
    error: tripDayError,
    refetch: refetchTripDay,
  } = useTripDayDetails(day_id as string);

  const { registerNotification, unregisterNotification, getNotificationId } =
    useTripNotificationManager();

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

  useFocusEffect(
    useCallback(() => {
      if (refresh && refresh === "true") {
        refetchTrip();
        refetchTripPoint();
        refetchTripDay();
      }
      return () => {
        if (refresh && refresh === "true")
          router.setParams({ refresh: "true" });
      };
    }, [refetchTrip, refetchTripPoint, router, refresh]),
  );

  const onDeleteTripPoint = async () => {
    await deleteTripPoint(tripPoint?.id);
    router.navigate({
      // @ts-ignore
      pathname: `/trips/details/${trip_id}/day/${day_id}`,
      params: { refresh: "true" },
    });
  };

  useEffect(() => {
    setLoading(
      deleteLoading ||
        tripDayLoading ||
        tripLoading ||
        tripPointLoading ||
        false,
    );
  }, [deleteLoading, tripDayLoading, tripLoading, tripPointLoading]);

  useEffect(() => {
    setError(deleteError || tripDayError || tripError || tripPointError || "");
  }, [deleteError, tripDayError, tripError, tripPointError]);

  const onSurveyFillOut = () => {
    console.log("onSurveyFillOut");
    hideModal();
    if (tripPoint)
      router.push(
        `/trips/details/${trip_id}/day/${day_id}/tripPoints/${tripPoint.id}/survey`,
      );
    else showSnackbar("Wystąpił błąd!", "error");
  };

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
                if (tripPoint)
                  router.push({
                    // @ts-ignore
                    pathname: `/trips/details/${trip_id}/day/${day_id}/tripPoints/edit/${tripPoint.id}`,
                    params: { date: date },
                  });
                else showSnackbar("Wystąpił błąd", "error");
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
            ...conditionalItem(
              !!tripPoint &&
                [
                  TripPointStatus.REVIEW_PENDING,
                  TripPointStatus.REVIEW_REJECTED,
                ].includes(tripPoint?.status as TripPointStatus),
              {
                title: "Wypełnij ankietę",
                color: theme.colors.onSurface,
                icon: FILL_SURVEY_ICON_MATERIAL,
                onPress: onSurveyFillOut,
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
  }, [tripDay, navigation, notificationId, tripPoint, tripDay, theme]);

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

  if (error) {
    router.back();
    showSnackbar(error?.toString() || "Unknown error", "error");
    return null;
  }

  if (loading) {
    return <LoadingView transparent={false} />;
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
                  key === "category" ? (
                    <View style={styles.rowContainer}>
                      <IconComponent
                        source={
                          CategoryIcons[
                            tripPoint?.place?.superCategory?.name ??
                              DEFAULT_CATEGORY_NAME
                          ]
                        }
                        iconSize={DEFAULT_ICON_SIZE}
                        color={theme.colors.onSurface}
                        backgroundColor={theme.colors.primaryContainer}
                      />
                      <Text style={styles.label}>
                        {
                          CategoryLabelsForTripCategory[
                            tripPoint?.place?.superCategory?.name ??
                              DEFAULT_CATEGORY_NAME
                          ]
                        }
                      </Text>
                    </View>
                  ) : (
                    <Text style={styles.value}>
                      {value?.toString() || "Brak danych"}
                    </Text>
                  )
                }
              />
            ))}
          {tripPoint?.place && (
            <View style={styles.placeDetails}>
              <Divider style={styles.divider} />
              <Text variant="titleLarge" style={styles.placeTitle}>
                Powiązana atrakcja
              </Text>
              <TripPointDetailsLabel
                title="Nazwa"
                element={
                  <Text style={styles.value}>
                    {tripPoint?.place?.name || "Brak danych"}
                  </Text>
                }
              />
              <TripPointDetailsLabel
                title="Godziny otwarcia"
                element={
                  <OpeningsHours
                    openingTime={tripPoint.openingTime}
                    closingTime={tripPoint.closingTime}
                    startTime={tripPoint.startTime}
                    endTime={tripPoint.endTime}
                  />
                }
              />
              <Text style={styles.placeUrl} variant="titleMedium">
                <Link href={`/trips/place/${tripPoint.place.providerId}`}>
                  Sprawdź szczegóły
                </Link>
              </Text>
            </View>
          )}
          {tripPoint?.status === TripPointStatus.REVIEW_COMPLETED &&
            parsedTripPoint.review && (
              <View style={styles.placeDetails}>
                <Divider style={styles.divider} />
                <Text variant="titleLarge" style={styles.placeTitle}>
                  Szczegóły ankiety
                </Text>
                {Object.entries(parsedTripPoint.review)
                  .filter(([key]) => key in REVIEW_LABELS)
                  .map(([key, value]) => (
                    <TripPointDetailsLabel
                      key={key}
                      title={REVIEW_LABELS[key]}
                      element={
                        <Text style={styles.value}>
                          {value?.toString() || "Brak danych"}
                        </Text>
                      }
                    />
                  ))}
                <TripPointDetailsLabel
                  title="Twoja ocena"
                  element={
                    <StarRatingDisplayComponent
                      style={styles.starRatingPadding}
                      rating={parsedTripPoint.review.rating}
                      editable={false}
                    />
                  }
                />
              </View>
            )}
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
                  getTimeWithoutSeconds(parsedTripPoint.startTime || ""),
                  getTimeWithoutSeconds(parsedTripPoint.endTime || ""),
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
    placeTitle: { paddingHorizontal: 16 },
    warning: {
      color: theme.colors.error,
    },
    placeUrl: {
      marginTop: 10,
      paddingHorizontal: 16,
      color: theme.colors.tertiary,
      fontFamily: "Manrope_700Bold",
      textDecorationLine: "underline",
    },
    placeDetails: {
      marginVertical: 30,
    },
    divider: { marginVertical: 10 },
    starRatingPadding: {
      paddingVertical: 10,
      alignSelf: "center",
    },
    rowContainer: {
      flexDirection: "row",
      alignItems: "center",
      flex: 3,
      paddingTop: 10,
      width: "100%",
    },
    label: {
      ...theme.fonts.bodyLarge,
      marginLeft: 10,
      textAlign: "center",
    },
  });
