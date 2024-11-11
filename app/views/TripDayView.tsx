import { Dimensions, ScrollView, StyleSheet, View } from "react-native";
import { TripPointCard } from "@/components/TripPointCard";
import { TransferPointNode } from "@/components/TransferPointNode";
import {
  TripPoint,
  TransferPoint,
  TransferTypeLabels,
  TransferType,
  Option,
} from "@/types/data";
import { useTheme, FAB, MD3Theme, Text, TextInput } from "react-native-paper";
import React, { Fragment, useMemo, useState } from "react";
import {
  BUS_ICON,
  CAR_ICON,
  DELETE_ICON,
  NON_STANDARD_TRANSFER_ICON,
  TRAIN_ICON,
  WALK_ICON,
  CREATING_TRIP_POINT_ICON,
  RECOMMENDATION_ICON,
  SEARCH_TRIP_POINT_ICON,
} from "@/constants/Icons";
import { GestureHandlerRootView } from "react-native-gesture-handler";
import CreatingTripPointSelector from "@/components/CreatingTripPointSelector";
import ActionButtons from "@/components/ActionButtons";
import { useRouter } from "expo-router";

const { width } = Dimensions.get("window");

const tripPoints: TripPoint[] = [
  {
    id: "1",
    name: "Muzeum",
    fromTime: "13:00",
    toTime: "14:00",
  },
  {
    id: "2",
    name: "Zamek",
    fromTime: "12:00",
    toTime: "13:00",
  },
  {
    id: "3",
    name: "Katedra",
    fromTime: "14:00",
    toTime: "15:00",
  },
  {
    id: "4",
    name: "Rynek",
    fromTime: "16:00",
    toTime: "17:00",
  },
  {
    id: "5",
    name: "Park",
    fromTime: "18:00",
    toTime: "19:00",
  },
];

const TripDayView = () => {
  const theme = useTheme();
  const style = createStyles(theme);
  const router = useRouter();

  const options: Option[] = [
    {
      icon: CREATING_TRIP_POINT_ICON,
      label: "Utwórz",
      onPress: () => {
        console.log("go to creating trip point");
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

  const [transferPoints, setTransferPoints] = useState<TransferPoint[]>([
    {
      id: "1",
      fromTripPointId: "2",
      toTripPointId: "3",
      type: "walk",
      duration: 110,
    },
    {
      id: "id1",
      fromTripPointId: "1",
      toTripPointId: "2",
      type: "empty",
      duration: 0,
    },
    {
      id: "id2",
      fromTripPointId: "3",
      toTripPointId: "4",
      type: "empty",
      duration: 0,
    },
    {
      id: "id3",
      fromTripPointId: "4",
      toTripPointId: "5",
      type: "empty",
      duration: 0,
    },
  ]);

  const handleTextChange = (text: string) => {
    const numericText = text.replace(/[^0-9]/g, "");
    setEstimatedTime(Number(numericText));
  };

  const undoChange = () => {
    setSelectedTransferPoint(previousTransfer);
    if (previousTransfer) handleChangeTransferType(previousTransfer.type);
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
        onCancel={onCancel}
        cancelButtonLabel="Resetuj"
        cancelIcon={undefined}
        onConfirm={onSave}
        confirmButtonLabel="Zapisz"
        confirmIcon={undefined}
      />
    </View>
  );

  const handleChangeTransferType = (
    type: TransferType,
    isVisibleTrigger: boolean = false,
  ) => {
    if (selectedTransferPoint) {
      setTransferPoints(
        transferPoints.map((point) =>
          point.id === selectedTransferPoint.id ? { ...point, type } : point,
        ),
      );
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

  const handleTripPointPress = () => {
    console.log("Trip point pressed");
  };

  const handleTripPointLongPress = () => {
    console.log("Trip point long pressed");
  };

  const handleTransferPointPress = (transferPoint: TransferPoint) => {
    setSelectedTransferPoint(transferPoint);
    setDynamicLabel(TransferTypeLabels[transferPoint.type]);
    if (transferPoint.type === "manual") {
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
      return a.fromTime.localeCompare(b.fromTime);
    });
  }, [tripPoints]);

  const renderTransferPoint = (fromTripPoint: TripPoint, index: number) => {
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
      selectedTransferPoint.type = "empty";
    }
    onSelectorClose();
  };

  const onSelectorClose = () => {
    setIsVisible(false);
    setDynamicLabel("");
    setExtendedView(undefined);
    setPreviousTransfer(undefined);
  };

  return (
    <>
      <GestureHandlerRootView>
        <ScrollView
          style={style.container}
          contentContainerStyle={style.containerContent}
        >
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
        </ScrollView>
        <FAB
          icon="plus"
          style={style.fab}
          color={theme.colors.onPrimary}
          label="Dodaj"
          onPress={() => {
            console.log("FAB Clicked");
          }}
        />
        <CreatingTripPointSelector
          options={transferPointOptions}
          isVisible={isVisible}
          onClose={() => onSelectorClose()}
          label={dynamicLabel}
          extendedView={extendedView}
        />
      </GestureHandlerRootView>
    </>
  );
};

const createStyles = (theme: MD3Theme) =>
  StyleSheet.create({
    container: {
      backgroundColor: theme.colors.surface,
    },
    containerContent: {
      alignItems: "center",
    },
    verticalSpace: {
      height: 40,
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
