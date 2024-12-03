/* eslint-disable @typescript-eslint/no-explicit-any */
import { Fragment, useCallback, useMemo, useRef, useState } from "react";
import { Dimensions, ScrollView, StyleSheet, View } from "react-native";
import { useTheme, FAB, TextInput, Text } from "react-native-paper";
import { GestureHandlerRootView } from "react-native-gesture-handler";
import { useRouter, useLocalSearchParams, useFocusEffect } from "expo-router";
import { TripPointCard } from "@/components/TripPointCard";
import { TransferPointNode } from "@/components/TransferPointNode";
import CreatingTripPointSelector from "@/components/CreatingTripPointSelector";
import ActionButtons from "@/components/ActionButtons";
import LoadingView from "./LoadingView";
import { MD3ThemeExtended } from "@/constants/Themes";
import {
  TripPointCompact,
  TransferPoint,
  TransferTypeLabels,
  TransferType,
} from "@/types/TripDayData";
import {
  BICYCLE_ICON,
  CAR_ICON,
  CREATING_TRIP_POINT_ICON,
  DELETE_ICON,
  DETAILS_ICON,
  EDIT_ICON,
  NON_STANDARD_TRANSFER_ICON,
  RECOMMENDATION_ICON,
  SEARCH_TRIP_POINT_ICON,
  MOTORBIKE_ICON,
  WALK_ICON,
  ADD_NOTIFICATION_ICON,
  REMOVE_NOTIFICATION_ICON,
  CALENDAR_ADD_ICON,
} from "@/constants/Icons";
import { Option } from "@/types/TripDayData";
import useTripDayDetails from "@/composables/useTripDay";
import { useSnackbar } from "@/context/SnackbarContext";
import { useAuth } from "@/app/ctx";
import { conditionalItem } from "@/utils/ArrayUtils";
import { formatTimeRange, formatMinutes } from "@/utils/TimeUtils";
import ActionTextButtons from "@/components/ActionTextButtons";
import CustomModal from "@/components/CustomModal";
import { useDeleteTripPoint } from "@/composables/useTripPoint";
import ActionMenuBottomSheet from "@/components/ActionMenu/ActionMenuBottomSheet";
import { useTripNotificationManager } from "@/hooks/useTripNotificationManager";
import {
  cancelNotification,
  schedulePushNotification,
} from "@/utils/notifications";
import NotificationFormBottomSheet from "@/components/NotificationFormBottomSheet";
import { addEventToMainCalendar } from "@/utils/calendar";

const { width } = Dimensions.get("window");

const MAX_TRANSFER_TIME = 1439; // 23h 59m

enum VisibilityState {
  None = "none",
  TripPoint = "trip-point",
  Transfer = "transfer",
  NotificationForm = "notification-form",
}

type TransferPointData =
  | TransferPoint
  | { fromTripPointId: string; toTripPointId: string };

const TripDayView = () => {
  const theme = useTheme();
  const styles = createStyles(theme as MD3ThemeExtended);
  const router = useRouter();
  const params = useLocalSearchParams();
  const { api } = useAuth();
  const { trip_id, day_id, refresh } = params;
  const { showSnackbar } = useSnackbar();

  const {
    isRegistered,
    registerNotification,
    unregisterNotification,
    getNotificationId,
  } = useTripNotificationManager();

  const [selectedTripPoint, setSelectedTripPoint] =
    useState<TripPointCompact | null>(null);

  const {
    transferPoints,
    tripPoints,
    tripDay,
    loading: tripDayLoading,
    error: tripDayError,
    refetch: refetchDayData,
    refetchNoLoading: refetchNoLoadingDayData,
  } = useTripDayDetails(day_id as string);

  const {
    deleteTripPoint,
    loading: deleteTripPointLoading,
    error: deleteTripPointError,
  } = useDeleteTripPoint();

  const selectedTripPointDate =
    selectedTripPoint && tripDay
      ? new Date(`${tripDay.date}T${selectedTripPoint.startTime}`)
      : null;

  const transferPointMap = useMemo(() => {
    const map = new Map<string, TransferPoint>();
    transferPoints.forEach((point) => {
      map.set(point.fromTripPointId, point);
    });
    return map;
  }, [transferPoints]);

  const loading = useMemo(() => {
    return tripDayLoading || deleteTripPointLoading;
  }, [tripDayLoading, deleteTripPointLoading]);

  const error = useMemo(() => {
    return tripDayError || deleteTripPointError;
  }, [tripDayError, deleteTripPointError]);

  const [isVisible, setIsVisible] = useState<VisibilityState>(
    VisibilityState.None,
  );
  const [isTripPointSheetVisible, setIsTripPointSheetVisible] =
    useState<boolean>(false);
  const [isNotificationFormVisible, setIsNotificationFormVisible] =
    useState<boolean>(false);
  const [isModalVisible, setIsModalVisible] = useState<boolean>(false);

  const options: Option[] = useMemo(
    () => [
      {
        icon: CREATING_TRIP_POINT_ICON,
        label: "Utwórz",
        onPress: () => {
          router.push({
            pathname: `/trips/details/${trip_id}/day/${day_id}/tripPoints/create`,
            params: {
              date: new Date(tripDay?.date as string).toLocaleDateString(),
            },
          });
          setIsVisible(VisibilityState.None);
        },
      },
      {
        icon: SEARCH_TRIP_POINT_ICON,
        label: "Wyszukaj",
        onPress: () => {
          router.push({
            pathname: "/explore",
            params: {
              trip_id: trip_id,
              day_id: day_id,
              date: new Date(tripDay?.date as string).toLocaleDateString(),
            },
          });
          setIsVisible(VisibilityState.None);
        },
      },
      {
        icon: RECOMMENDATION_ICON,
        label: "Rekomendacje",
        onPress: () => {
          setIsVisible(VisibilityState.None);
        },
      },
    ],
    [setIsVisible, tripDay, trip_id, day_id],
  );

  const [loadingOverlay, setLoadingOverlay] = useState<boolean>(false);

  const [selectedFromToTripPointId, setSelectedFromToTripPointId] = useState<{
    fromTripPointId: string;
    toTripPointId: string;
  } | null>(null);

  const selectedTransferPointData = useMemo(() => {
    const { fromTripPointId, toTripPointId } = selectedFromToTripPointId || {};
    const transferPointData: TransferPointData | undefined =
      transferPointMap.get(fromTripPointId as string);
    if (!transferPointData) {
      return { fromTripPointId, toTripPointId };
    }
    return transferPointData;
  }, [transferPointMap, selectedFromToTripPointId]);

  const [extendedView, setExtendedView] = useState<boolean>(false);

  const dynamicLabel = useMemo(() => {
    if (extendedView) return "Ręcznie";
    if ("mode" in selectedTransferPointData) {
      const mode =
        selectedTransferPointData.mode != null
          ? selectedTransferPointData.mode
          : "null";
      return TransferTypeLabels[mode];
    }
    return "Brak";
  }, [selectedTransferPointData, extendedView]);

  useFocusEffect(
    useCallback(() => {
      if (refresh && refresh === "true") {
        refetchDayData();
        router.setParams({ refresh: undefined });
        hideAll();
      }
    }, [refetchDayData, router, refresh]),
  );

  const getTripPoint = useCallback(
    (tripPointId: string): TripPointCompact | null => {
      const tripPoint = tripPoints.find((point) => point.id === tripPointId);
      return tripPoint || null;
    },
    [tripPoints],
  );

  const updateTransferPoint = useCallback(
    async (
      transferPoint: Omit<TransferPoint, "id">,
      transferPointId?: string,
    ) => {
      try {
        if (transferPointId) {
          await api?.put(`/transferPoints/${transferPointId}`, transferPoint);
        } else {
          await api?.post("/transferPoints", transferPoint);
        }
      } catch (error: any) {
        console.error(error.response);
        showSnackbar(
          error?.response?.data?.message || "Wystąpił błąd",
          "error",
        );
      }
    },
    [api, showSnackbar],
  );

  const handleManualTransferSave = useCallback(
    async (minutes: number | null) => {
      if (minutes === null) return;
      const newTransferPoint: Omit<TransferPoint, "id"> = {
        tripDayId: day_id as string,
        seconds: minutes * 60,
        fromTripPointId: selectedTransferPointData.fromTripPointId as string,
        toTripPointId: selectedTransferPointData.toTripPointId as string,
      };
      const transferPointId =
        "id" in selectedTransferPointData
          ? selectedTransferPointData.id
          : undefined;
      try {
        setLoadingOverlay(true);
        await updateTransferPoint(newTransferPoint, transferPointId);
        await refetchNoLoadingDayData();
      } catch (error: any) {
        showSnackbar("Wystąpił błąd", "error");
      } finally {
        setLoadingOverlay(false);
      }
    },
    [
      selectedTransferPointData,
      updateTransferPoint,
      refetchNoLoadingDayData,
      showSnackbar,
    ],
  );

  const ExampleExtendedView = useCallback(
    ({ seconds }: { seconds?: number | null }) => {
      const initialDuration = useRef<number>(Math.floor((seconds || 0) / 60));
      const [duration, setDuration] = useState<number | null>(null);
      const [errorText, setErrorText] = useState<string | null>(null);

      const onReset = () => {
        setDuration(null);
        setErrorText(null);
      };

      const handleTextChange = (text: string) => {
        const numericText = text.replace(/[^0-9]/g, "");
        const parsedDuration = Number(numericText);
        if (parsedDuration > MAX_TRANSFER_TIME) {
          setErrorText("Maksymalny czas to 23h 59m");
          setDuration(MAX_TRANSFER_TIME);
          return;
        }
        if (parsedDuration <= 0) {
          setErrorText("Czas musi być większy od 0");
          setDuration(null);
          return;
        }
        setErrorText(null);
        setDuration(Number(numericText));
      };

      const onSave = useCallback(() => {
        if (duration === null) {
          setErrorText("Wpisz czas");
          return;
        }
        handleManualTransferSave(duration);
      }, [handleManualTransferSave, duration]);

      return (
        <View style={styles.extendedView}>
          <Text>Wpisz szacowany czas podróży:</Text>
          <TextInput
            mode="outlined"
            style={styles.textInput}
            label="Minuty"
            value={duration === null ? "" : duration.toString()}
            placeholder={initialDuration.current.toString()}
            onChangeText={handleTextChange}
            keyboardType="numeric"
          />
          <Text style={{ color: theme.colors.error }}>
            {errorText ? errorText : " "}
          </Text>
          <ActionButtons
            onAction1={onReset}
            action1ButtonLabel="Resetuj"
            onAction2={onSave}
            action2ButtonLabel="Zapisz"
            action1Icon={undefined}
            action2Icon={undefined}
          />
        </View>
      );
    },
    [handleManualTransferSave],
  );

  const handleChangeTransferType = useCallback(
    async (type: TransferType) => {
      setExtendedView(false);
      if (
        "mode" in selectedTransferPointData &&
        selectedTransferPointData.mode === type
      ) {
        return;
      }
      const newTransferPoint: Omit<TransferPoint, "id"> = {
        tripDayId: day_id as string,
        mode: type,
        fromTripPointId: selectedTransferPointData.fromTripPointId as string,
        toTripPointId: selectedTransferPointData.toTripPointId as string,
      };
      const transferPointId =
        "id" in selectedTransferPointData
          ? selectedTransferPointData.id
          : undefined;
      try {
        setLoadingOverlay(true);
        await updateTransferPoint(newTransferPoint, transferPointId);
        await refetchNoLoadingDayData();
      } catch (error: any) {
        showSnackbar("Wystąpił błąd", "error");
      } finally {
        setLoadingOverlay(false);
      }
    },
    [
      selectedTransferPointData,
      setExtendedView,
      setLoadingOverlay,
      updateTransferPoint,
      refetchNoLoadingDayData,
      showSnackbar,
    ],
  );

  const handleManualTransferEdit = useCallback(() => {
    setExtendedView(true);
    setIsVisible(VisibilityState.Transfer);
  }, [setExtendedView, setIsVisible]);

  const deleteTransferPoint = useCallback(async () => {
    if ("id" in selectedTransferPointData) {
      try {
        setLoadingOverlay(true);
        await api?.delete(`/transferPoints/${selectedTransferPointData.id}`);
        await refetchNoLoadingDayData();
      } catch (error: any) {
        showSnackbar("Wystąpił błąd", "error");
      } finally {
        setLoadingOverlay(false);
      }
    }
    onSelectorClose();
  }, [
    selectedTransferPointData,
    setLoadingOverlay,
    refetchNoLoadingDayData,
    showSnackbar,
  ]);

  const transferPointOptions: Option[] = useMemo(() => {
    const previousTransferPoint = getTripPoint(
      selectedTransferPointData.fromTripPointId as string,
    );

    const nextTransferPoint = getTripPoint(
      selectedTransferPointData.toTripPointId as string,
    );

    const disableAutomaticTransferTime =
      previousTransferPoint?.latitude === null ||
      previousTransferPoint?.longitude === null ||
      nextTransferPoint?.latitude === null ||
      nextTransferPoint?.longitude === null;

    return [
      {
        icon: CAR_ICON,
        label: "Samochód",
        onPress: () => handleChangeTransferType(TransferType.Car),
        disabled: disableAutomaticTransferTime,
      },
      {
        icon: MOTORBIKE_ICON,
        label: "Motocykl",
        onPress: () => handleChangeTransferType(TransferType.Motorbike),
        disabled: disableAutomaticTransferTime,
      },
      {
        icon: BICYCLE_ICON,
        label: "Rower",
        onPress: () => handleChangeTransferType(TransferType.Bicycle),
        disabled: disableAutomaticTransferTime,
      },
      {
        icon: WALK_ICON,
        label: "Chód",
        onPress: () => handleChangeTransferType(TransferType.Walk),
        disabled: disableAutomaticTransferTime,
      },
      {
        icon: NON_STANDARD_TRANSFER_ICON,
        label: "Ręcznie",
        onPress: handleManualTransferEdit,
      },
      {
        icon: DELETE_ICON,
        label: "Usuń",
        onPress: deleteTransferPoint,
        isDelete: true,
      },
    ];
  }, [
    selectedTransferPointData,
    handleChangeTransferType,
    handleManualTransferEdit,
    deleteTransferPoint,
  ]);

  const handleTripPointPress = (tripPoint: TripPointCompact) => {
    console.log("Trip point pressed");
    router.push(
      `/trips/details/${trip_id}/day/${day_id}/tripPoints/${tripPoint.id}/survey`,
    );
  };

  const handleTripPointLongPress = (tripPoint: TripPointCompact) => {
    console.log("Trip point long pressed");
    setSelectedTripPoint(tripPoint);
    setIsVisible(VisibilityState.None);
    setIsTripPointSheetVisible(true);
  };

  const handleTransferPointPress = useCallback(
    (fromTripPointId: string, toTripPointId: string) => {
      const transferPoint = transferPointMap.get(fromTripPointId);
      setSelectedFromToTripPointId({ fromTripPointId, toTripPointId });
      if (transferPoint && transferPoint.mode === null) {
        setExtendedView(true);
      }
      setIsVisible(VisibilityState.Transfer);
    },
    [
      transferPointMap,
      setIsVisible,
      setExtendedView,
      setSelectedFromToTripPointId,
    ],
  );

  const sortedTripPoints = useMemo(() => {
    return [...tripPoints].sort((a, b) => {
      return a.startTime.localeCompare(b.startTime);
    });
  }, [tripPoints]);

  const renderTransferPoint = useCallback(
    (fromTripPoint: TripPointCompact, index: number) => {
      if (index === sortedTripPoints.length - 1) {
        return null;
      }

      const transferPoint = transferPointMap.get(fromTripPoint.id);
      const toTripPointId = sortedTripPoints[index + 1].id;

      return (
        <TransferPointNode
          onPress={() =>
            handleTransferPointPress(fromTripPoint.id, toTripPointId)
          }
          transferPoint={transferPoint}
        />
      );
    },
    [sortedTripPoints, transferPointMap, handleTransferPointPress],
  );

  const onSelectorClose = useCallback(() => {
    setIsVisible(VisibilityState.None);
    setExtendedView(false);
    setSelectedFromToTripPointId(null);
  }, [setIsVisible, setExtendedView, setSelectedFromToTripPointId]);

  const hideModal = () => {
    setIsModalVisible(false);
  };

  const onCloseBottomSheet = () => {
    console.log("Close bottom sheet");
    setIsTripPointSheetVisible(false);
  };

  const handleScheduleNotification = async (
    minutes: number,
  ): Promise<boolean> => {
    if (!selectedTripPoint) return false;

    if (!tripDay?.date || !selectedTripPointDate) {
      showSnackbar("Wystąpił błąd", "error");
      return false;
    }

    const parsedDate = new Date(
      selectedTripPointDate.getTime() - minutes * 60 * 1000,
    );

    if (parsedDate < new Date()) {
      showSnackbar("Nie można ustawić przypomnienia w przeszłości", "error");
      return false;
    }

    const newNotificationId = await schedulePushNotification(
      selectedTripPoint.name,
      `Zaczyna się za ${formatMinutes(minutes)}`,
      parsedDate,
    );
    await registerNotification(selectedTripPoint.id, newNotificationId);

    return true;
  };

  const getActionsForSelectedTripPoint: Action[] = useMemo(() => {
    if (!selectedTripPoint) return [];

    const notificationId = getNotificationId(selectedTripPoint.id);

    return [
      {
        label: "Szczegóły punktu wycieczki",
        icon: DETAILS_ICON,
        onPress: () => {
          console.log(`Nawiguj do szczegółów`);
          setIsVisible(VisibilityState.None);
          // router.push(`/trips/details/${selectedTripPo.id}`);
        },
      },
      {
        label: "Edytuj szczegóły punktu wycieczki",
        icon: EDIT_ICON,
        onPress: () => {
          console.log(`Edytuj`);
          setIsVisible(VisibilityState.None);
          // router.push(`/trips/edit/${selectedTrip.id}`);
        },
      },
      ...conditionalItem(
        !!selectedTripPointDate && selectedTripPointDate > new Date(),
        {
          label: notificationId ? "Usuń przypomnienie" : "Ustaw przypomnienie",
          icon: notificationId
            ? REMOVE_NOTIFICATION_ICON
            : ADD_NOTIFICATION_ICON,
          onPress: async () => {
            if (notificationId) {
              try {
                await cancelNotification(notificationId);
                await unregisterNotification(selectedTripPoint.id);
              } catch (error: any) {
                console.error("Error while setting notification", error);
                showSnackbar("Wystąpił błąd", "error");
              }
            } else {
              console.log(`Dodaj`);
              setIsTripPointSheetVisible(false);
              setIsNotificationFormVisible(true);
            }
          },
        },
      ),
      {
        label: "Dodaj do kalendarza",
        icon: CALENDAR_ADD_ICON,
        onPress: () => {
          if (tripDay?.date === undefined) return;

          const startDate = new Date(
            `${tripDay?.date}T${selectedTripPoint.startTime}`,
          );
          const endDate = new Date(
            `${tripDay?.date}T${selectedTripPoint.endTime}`,
          );

          const data = {
            title: selectedTripPoint.name,
            startDate,
            endDate,
            timezone: "GMT+1",
          };

          addEventToMainCalendar(data);
        },
      },
      {
        label: "Usuń punkt wycieczki",
        icon: DELETE_ICON,
        onPress: () => {
          console.log(`Usuń`);
          setIsModalVisible(true);
          setIsVisible(VisibilityState.None);
        },
      },
    ];
  }, [selectedTripPoint, getNotificationId]);

  const hideAll = () => {
    console.log("Hide all");
    setIsVisible(VisibilityState.None);
    setIsTripPointSheetVisible(false);
    setIsModalVisible(false);
  };

  const onDeleteTripPoint = async () => {
    await deleteTripPoint(selectedTripPoint?.id);
    hideAll();
    await refetchDayData();
  };

  if (loading) {
    return <LoadingView />;
  }

  if (error) {
    router.back();
    showSnackbar(tripDayError?.toString() || "Unknown error", "error");
    return null;
  }

  return (
    <>
      <GestureHandlerRootView>
        <ScrollView
          style={styles.container}
          contentContainerStyle={styles.containerContent}
        >
          {tripPoints.length === 0 ? (
            <View style={styles.emptyDayContainer}>
              <Text style={styles.emptyDayText}>
                Ten dzień jest jeszcze pusty - dodaj punkty wycieczki
              </Text>
            </View>
          ) : (
            <>
              <View style={{ height: 40 }} />
              {sortedTripPoints.map((fromTripPoint, index) => (
                <Fragment key={fromTripPoint.id}>
                  <TripPointCard
                    onPress={() => handleTripPointPress(fromTripPoint)}
                    onLongPress={() => handleTripPointLongPress(fromTripPoint)}
                    tripPoint={fromTripPoint}
                  />
                  {renderTransferPoint(fromTripPoint, index)}
                </Fragment>
              ))}
              <View style={{ height: 100 }} />
            </>
          )}
        </ScrollView>
        <FAB
          icon="plus"
          style={styles.fab}
          color={theme.colors.onPrimary}
          label="Dodaj"
          onPress={() => setIsVisible(VisibilityState.TripPoint)}
        />
        <CreatingTripPointSelector
          options={
            isVisible === VisibilityState.TripPoint
              ? options
              : transferPointOptions
          }
          isVisible={
            isVisible === VisibilityState.TripPoint ||
            isVisible === VisibilityState.Transfer
          }
          onClose={onSelectorClose}
          label={dynamicLabel}
          extendedView={
            extendedView ? (
              <ExampleExtendedView
                seconds={
                  "seconds" in selectedTransferPointData
                    ? selectedTransferPointData.seconds
                    : null
                }
              />
            ) : undefined
          }
        />

        <CustomModal visible={isModalVisible} onDismiss={hideModal}>
          <View>
            <Text style={styles.modalTitleText}>
              Czy na pewno chcesz usunąć tą wycieczkę?
            </Text>
            <View style={styles.modalContent}>
              <Text style={styles.boldText}>{selectedTripPoint?.name}</Text>
              <Text style={styles.modalSubtitle}>
                {formatTimeRange(
                  selectedTripPoint?.startTime || "",
                  selectedTripPoint?.endTime || "",
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

        <ActionMenuBottomSheet
          headerComponent={() => (
            <Text style={styles.bottomSheetText}>Wybierz opcję</Text>
          )}
          actions={getActionsForSelectedTripPoint}
          isVisible={isTripPointSheetVisible}
          onClose={onCloseBottomSheet}
        />

        <NotificationFormBottomSheet
          isVisible={isNotificationFormVisible}
          onClose={() => setIsNotificationFormVisible(false)}
          onCancel={() => {
            setIsNotificationFormVisible(false);
            setIsTripPointSheetVisible(true);
          }}
          onSave={async (minutes) => {
            const didSchedule = await handleScheduleNotification(minutes);
            if (didSchedule) {
              setIsNotificationFormVisible(false);
              setIsTripPointSheetVisible(true);
            }
          }}
        />
      </GestureHandlerRootView>
      <LoadingView show={loadingOverlay} />
    </>
  );
};

const createStyles = (theme: MD3ThemeExtended) =>
  StyleSheet.create({
    boldText: {
      fontWeight: "bold",
      color: theme.colors.onSurface,
    },
    bottomSheetText: {
      marginBottom: 10,
      marginTop: -10,
      color: theme.colors.onSurface,
      ...theme.fonts.bodyMedium,
    },
    modalSubtitle: {
      color: theme.colors.onSurface,
    },
    modalTitleText: {
      ...theme.fonts.titleLarge,
      color: theme.colors.onSurface,
    },
    modalContent: {
      marginVertical: 20,
    },
    container: {
      backgroundColor: theme.colors.surface,
    },
    containerContent: {
      alignItems: "center",
      flexGrow: 1,
    },
    verticalSpace: {
      height: 40,
    },
    emptyDayText: {
      ...theme.fonts.bodyLarge,
      color: theme.colors.onSurface,
      textAlign: "center",
      marginHorizontal: 0.1 * width,
    },
    emptyDayContainer: {
      height: "100%",
      backgroundColor: theme.colors.surface,
      alignItems: "center",
      justifyContent: "center",
      flex: 1,
    },
    fab: {
      position: "absolute",
      margin: 16,
      right: 0,
      bottom: 0,
      backgroundColor: theme.colors.primary,
    },
    text: {
      fontSize: 16,
      marginBottom: 10,
    },
    textInput: {
      width: "100%",
      height: 50,
      marginTop: 10,
      backgroundColor: theme.colors.surface,
    },
    extendedView: {
      backgroundColor: theme.colors.elevation.level1,
      paddingHorizontal: 0.1 * width,
      width: "100%",
    },
  });

export default TripDayView;
