import { Dimensions, ScrollView, StyleSheet, View } from "react-native";
import { TripPointCard } from "@/components/TripPointCard";
import { TransferPointNode } from "@/components/TransferPointNode";
import { useRouter, useLocalSearchParams, useFocusEffect } from "expo-router";
import { MD3ThemeExtended } from "@/constants/Themes";
import {
  TripPointCompact,
  TransferPoint,
  TransferTypeLabels,
  TransferType,
} from "@/types/data";
import { useTheme, FAB, Text, TextInput } from "react-native-paper";
import React, {
  Fragment,
  useCallback,
  useEffect,
  useMemo,
  useState,
} from "react";
import {
  BUS_ICON,
  CAR_ICON,
  CREATING_TRIP_POINT_ICON,
  DELETE_ICON,
  DETAILS_ICON,
  EDIT_ICON,
  NON_STANDARD_TRANSFER_ICON,
  RECOMMENDATION_ICON,
  SEARCH_TRIP_POINT_ICON,
  TRAIN_ICON,
  WALK_ICON,
} from "@/constants/Icons";
import { GestureHandlerRootView } from "react-native-gesture-handler";
import CreatingTripPointSelector from "@/components/CreatingTripPointSelector";
import ActionButtons from "@/components/ActionButtons";
import { Option } from "@/types/data";
import useTripDayDetails from "@/composables/useTripDay";
import LoadingView from "./LoadingView";
import { useSnackbar } from "@/context/SnackbarContext";
import { formatTimeRange, getTimeWithoutSeconds } from "@/utils/TimeUtils";
import ActionTextButtons from "@/components/ActionTextButtons";
import CustomModal from "@/components/CustomModal";
import { useDeleteTripPoint } from "@/composables/useTripPoint";
import ActionMenuBottomSheet from "@/components/ActionMenu/ActionMenuBottomSheet";

const { width } = Dimensions.get("window");

const TripDayView = () => {
  const theme = useTheme();
  const styles = createStyles(theme as MD3ThemeExtended);
  const router = useRouter();
  const params = useLocalSearchParams();

  const { trip_id, day_id, refresh } = params;
  const [selectedTripPoint, setSelectedTripPoint] =
    useState<TripPointCompact | null>(null);

  const { showSnackbar } = useSnackbar();

  const {
    transferPoints,
    tripPoints,
    tripDay,
    loading: tripDayLoading,
    error: tripDayError,
    refetch: refetchDayData,
  } = useTripDayDetails(day_id as string);

  const {
    deleteTripPoint,
    loading: deleteTripPointLoading,
    error: deleteTripPointError,
  } = useDeleteTripPoint();

  const [loading, setLoading] = useState<boolean>(false);
  useEffect(() => {
    setLoading(tripDayLoading || deleteTripPointLoading);
  }, [tripDayLoading, deleteTripPointLoading]);

  const [error, setError] = useState<string>("");
  useEffect(() => {
    setError(tripDayError || deleteTripPointError || "");
  }, [tripDayError, deleteTripPointError]);

  const [tripPointsFormatted, setTripPointsFormatted] = useState<
    TripPointCompact[]
  >([] as TripPointCompact[]);

  useEffect(() => {
    setTripPointsFormatted(
      tripPoints.map(
        (tripPoint) =>
          ({
            ...tripPoint,
            startTime: getTimeWithoutSeconds(tripPoint.startTime),
            endTime: getTimeWithoutSeconds(tripPoint.endTime),
          }) as TripPointCompact,
      ),
    );
  }, [tripPoints]);

  const options: Option[] = [
    {
      icon: CREATING_TRIP_POINT_ICON,
      label: "Utwórz",
      onPress: () => {
        setIsSelectorVisible(false);
        console.log("go to creating trip point");
        router.push({
          pathname: `/(auth)/(tabs)/trips/details/${trip_id}/day/${day_id}/tripPoints/create`,
          params: {
            date: new Date(tripDay?.date as string).toLocaleDateString(),
          },
        });
      },
    },
    {
      icon: SEARCH_TRIP_POINT_ICON,
      label: "Wyszukaj",
      onPress: () => {
        router.push("/explore");
        setIsSelectorVisible(false);
      },
    },
    {
      icon: RECOMMENDATION_ICON,
      label: "Rekomendacje",
      onPress: () => {
        console.log("go to recommendation");
        setIsSelectorVisible(false);
      },
    },
  ];
  const [isModalVisible, setIsModalVisible] = useState<boolean>(false);
  const [isVisible, setIsVisible] = useState<boolean>(false);
  const [isSelectorVisible, setIsSelectorVisible] = useState<boolean>(false);

  const [dynamicLabel, setDynamicLabel] = useState<string>("");
  const [estimatedTime, setEstimatedTime] = useState<number>(0);
  const [extendedView, setExtendedView] = useState<
    React.JSX.Element | undefined
  >(undefined);
  const [selectedTransferPoint, setSelectedTransferPoint] = useState<
    TransferPoint | undefined
  >(undefined);
  const [previousTransfer, setPreviousTransfer] = useState<
    TransferPoint | undefined
  >(undefined);

  useFocusEffect(
    useCallback(() => {
      if (refresh && refresh === "true") {
        refetchDayData();
        router.setParams({ refresh: undefined });
        hideAll();
      }
    }, [refetchDayData, router, refresh]),
  );

  const handleTextChange = (text: string) => {
    const numericText = text.replace(/[^0-9]/g, "");
    setEstimatedTime(Number(numericText));
  };

  const undoChange = () => {
    setSelectedTransferPoint(previousTransfer);
    if (previousTransfer) handleChangeTransferType(previousTransfer.mode);
  };

  const onCancel = () => {
    undoChange();
    onSelectorClose();
  };

  const onSave = () => {
    console.log("Zapisz");
    if (selectedTransferPoint) selectedTransferPoint.duration = estimatedTime;
    onSelectorClose();
  };

  const ExampleExtendedView = () => (
    <View style={styles.extendedView}>
      <Text>Wpisz szacowany czas podróży:</Text>
      <TextInput
        mode="outlined"
        style={styles.textInput}
        label="Minuty"
        defaultValue={selectedTransferPoint?.duration.toString()}
        onChangeText={handleTextChange}
        keyboardType="numeric"
      ></TextInput>
      <ActionButtons
        onAction1={onCancel}
        action1ButtonLabel="Resetuj"
        action1Icon={undefined}
        onAction2={onSave}
        action2ButtonLabel="Zapisz"
        action2Icon={undefined}
      />
    </View>
  );

  const handleChangeTransferType = (
    type: TransferType,
    isVisibleTrigger: boolean = false,
  ) => {
    if (selectedTransferPoint) {
      // setTransferPoints(
      //   transferPoints.map((point) =>
      //     point.id === selectedTransferPoint.id ? { ...point, type } : point,
      //   ),
      // );
      // To implement after connecting trip day to backend
    }
    setIsSelectorVisible(isVisibleTrigger);
    if (!isVisibleTrigger) setExtendedView(undefined);
  };

  const handleManualTransferEdit = () => {
    setExtendedView(<ExampleExtendedView />);
    handleChangeTransferType("manual", true);
    setDynamicLabel(TransferTypeLabels["manual"]);
  };

  const transferPointOptions: Option[] = [
    {
      icon: BUS_ICON,
      label: "Autobus",
      onPress: () => handleChangeTransferType("bus"),
    },
    {
      icon: TRAIN_ICON,
      label: "Pociąg",
      onPress: () => handleChangeTransferType("train"),
    },
    {
      icon: CAR_ICON,
      label: "Samochód",
      onPress: () => handleChangeTransferType("car"),
    },
    {
      icon: WALK_ICON,
      label: "Chód",
      onPress: () => handleChangeTransferType("walk"),
    },
    {
      icon: NON_STANDARD_TRANSFER_ICON,
      label: "Ręcznie",
      onPress: () => handleManualTransferEdit(),
    },
    {
      icon: DELETE_ICON,
      label: "Usuń",
      onPress: () => deleteTransferPoint(),
    },
  ];

  const [selectedOptions, setSelectedOptions] = useState<Option[]>(options);

  const handleTripPointPress = () => {
    console.log("Trip point pressed");
  };

  const handleTripPointLongPress = (tripPoint: TripPointCompact) => {
    console.log("Trip point long pressed");
    setSelectedTripPoint(tripPoint);
    setIsVisible(true);
  };

  const handleTransferPointPress = (transferPoint: TransferPoint) => {
    setSelectedOptions(transferPointOptions);
    setSelectedTransferPoint(transferPoint);
    setDynamicLabel(TransferTypeLabels[transferPoint.mode]);
    if (transferPoint.mode === "manual") {
      setExtendedView(<ExampleExtendedView />);
    }
    setIsSelectorVisible(true);
    if (previousTransfer === undefined)
      setPreviousTransfer({ ...transferPoint });
  };

  const transferPointMap = useMemo(() => {
    const map = new Map();
    transferPoints.forEach((point) => {
      map.set(point.fromTripPointId, point);
    });
    return map;
  }, [transferPoints]);

  const sortedTripPoints = useMemo(() => {
    return [...tripPointsFormatted].sort((a, b) => {
      return a.startTime.localeCompare(b.startTime);
    });
  }, [tripPointsFormatted]);

  const renderTransferPoint = (
    fromTripPoint: TripPointCompact,
    index: number,
  ) => {
    if (index === tripPointsFormatted.length - 1) {
      return null;
    }

    const transferPoint: TransferPoint = transferPointMap.get(fromTripPoint.id);

    return (
      <TransferPointNode
        onPress={() => {
          handleTransferPointPress(transferPoint);
        }}
        transferPoint={transferPoint}
      />
    );
  };

  const deleteTransferPoint = () => {
    if (selectedTransferPoint) {
      selectedTransferPoint.duration = 0;
      selectedTransferPoint.mode = "empty";
    }
    onSelectorClose();
  };

  const onSelectorClose = () => {
    setIsSelectorVisible(false);
    setDynamicLabel("");
    setExtendedView(undefined);
    setPreviousTransfer(undefined);
  };

  const hideModal = () => {
    setIsModalVisible(false);
    setSelectedTripPoint(null);
  };

  const onCloseBottomSheet = () => {
    setIsVisible(false);
    if (!isModalVisible) setSelectedTripPoint(null);
  };

  const getActionsForSelectedTripPoint: Action[] = useMemo(() => {
    if (!selectedTripPoint) return [];
    return [
      {
        label: "Szczegóły punktu wycieczki",
        icon: DETAILS_ICON,
        onPress: () => {
          console.log(`Nawiguj do szczegółów`);
          setIsVisible(false);
          // router.push(`/trips/details/${selectedTripPo.id}`);
        },
      },
      {
        label: "Edytuj szczegóły punktu wycieczki",
        icon: EDIT_ICON,
        onPress: () => {
          console.log(`Edytuj`);
          setIsVisible(false);
          // router.push(`/trips/edit/${selectedTrip.id}`);
        },
      },
      {
        label: "Usuń punkt wycieczki",
        icon: DELETE_ICON,
        onPress: () => {
          console.log(`Usuń`);
          setIsModalVisible(true);
          setIsVisible(false);
        },
      },
    ];
  }, [selectedTripPoint]);

  const hideAll = () => {
    setIsModalVisible(false);
    setIsSelectorVisible(false);
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
    showSnackbar(error?.toString() || "Unknown error", "error");
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
                    onPress={handleTripPointPress}
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
          onPress={() => {
            setSelectedOptions(options);
            setIsSelectorVisible(true);
          }}
        />
        <CreatingTripPointSelector
          options={selectedOptions}
          isVisible={isSelectorVisible}
          onClose={onSelectorClose}
          label={dynamicLabel}
          extendedView={extendedView}
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
          isVisible={isVisible}
          onClose={onCloseBottomSheet}
        />
      </GestureHandlerRootView>
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
