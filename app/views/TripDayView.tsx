import { Dimensions, ScrollView, StyleSheet, View, Text } from "react-native";
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
import { useTheme, FAB, TextInput } from "react-native-paper";
import React, { Fragment, useCallback, useMemo, useState } from "react";
import {
  BUS_ICON,
  CAR_ICON,
  CREATING_TRIP_POINT_ICON,
  DELETE_ICON,
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

const { width } = Dimensions.get("window");

const TripDayView = () => {
  const theme = useTheme();
  const style = createStyles(theme as MD3ThemeExtended);
  const router = useRouter();
  const params = useLocalSearchParams();

  const { trip_id, day_id } = params;

  const { showSnackbar } = useSnackbar();

  const {
    transferPoints,
    tripPoints,
    tripDay,
    loading,
    error,
    refetch: refetchDayData,
  } = useTripDayDetails(day_id as string);

  const options: Option[] = [
    {
      icon: CREATING_TRIP_POINT_ICON,
      label: "Utwórz",
      onPress: () => {
        console.log("go to creating trip point");
        router.push({
          pathname: `/(auth)/(tabs)/trips/details/${trip_id}/day/${day_id}/tripPoints/create`,
          params: {
            date: new Date(tripDay?.date as string).toLocaleDateString(),
          },
        });
        setIsVisible(false);
      },
    },
    {
      icon: SEARCH_TRIP_POINT_ICON,
      label: "Wyszukaj",
      onPress: () => {
        router.push("/explore");
        setIsVisible(false);
      },
    },
    {
      icon: RECOMMENDATION_ICON,
      label: "Rekomendacje",
      onPress: () => {
        console.log("go to recommendation");
        setIsVisible(false);
      },
    },
  ];

  const [isVisible, setIsVisible] = useState<boolean>(false);
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
      refetchDayData();
      console.log("REFRESH");
    }, [refetchDayData]),
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
    console.log("Reset");
    undoChange();
    console.log(JSON.stringify(previousTransfer));
    onSelectorClose();
  };

  const onSave = () => {
    console.log("Zapisz");
    if (selectedTransferPoint) selectedTransferPoint.duration = estimatedTime;
    onSelectorClose();
  };

  const ExampleExtendedView = () => (
    <View style={style.extendedView}>
      <Text>Wpisz szacowany czas podróży:</Text>
      <TextInput
        mode="outlined"
        style={style.textInput}
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
    setIsVisible(isVisibleTrigger);
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

  const handleTripPointLongPress = () => {
    console.log("Trip point long pressed");
  };

  const handleTransferPointPress = (transferPoint: TransferPoint) => {
    setSelectedOptions(transferPointOptions);
    setSelectedTransferPoint(transferPoint);
    setDynamicLabel(TransferTypeLabels[transferPoint.mode]);
    if (transferPoint.mode === "manual") {
      setExtendedView(<ExampleExtendedView />);
    }
    setIsVisible(true);
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
    return [...tripPoints].sort((a, b) => {
      return a.startTime.localeCompare(b.startTime);
    });
  }, [tripPoints]);

  const renderTransferPoint = (
    fromTripPoint: TripPointCompact,
    index: number,
  ) => {
    if (index === tripPoints.length - 1) {
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
    setIsVisible(false);
    setDynamicLabel("");
    setExtendedView(undefined);
    setPreviousTransfer(undefined);
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
          style={style.container}
          contentContainerStyle={style.containerContent}
        >
          {tripPoints.length === 0 ? (
            <View style={style.emptyDayContainer}>
              <Text style={style.emptyDayText}>
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
                    onLongPress={handleTripPointLongPress}
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
          style={style.fab}
          color={theme.colors.onPrimary}
          label="Dodaj"
          onPress={() => {
            setSelectedOptions(options);
            setIsVisible(true);
          }}
        />
        <CreatingTripPointSelector
          options={selectedOptions}
          isVisible={isVisible}
          onClose={() => onSelectorClose()}
          label={dynamicLabel}
          extendedView={extendedView}
        />
      </GestureHandlerRootView>
    </>
  );
};

const createStyles = (theme: MD3ThemeExtended) =>
  StyleSheet.create({
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
