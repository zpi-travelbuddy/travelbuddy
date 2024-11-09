import { ScrollView, StyleSheet, View } from "react-native";
import { TripPointCard } from "@/components/TripPointCard";
import { TransferPointNode } from "@/components/TransferPointNode";
import { MD3ThemeExtended } from "@/constants/Themes";
import {
  TripPoint,
  TransferPoint,
  TransferTypeLabels,
  TransferType,
} from "@/types/data";
import { useTheme, FAB } from "react-native-paper";
import React, { Fragment, useMemo, useState } from "react";
import {
  BUS_ICON,
  CAR_ICON,
  DELETE_ICON,
  NON_STANDARD_TRANSFER_ICON,
  TRAIN_ICON,
  WALK_ICON,
} from "@/constants/Icons";
import { GestureHandlerRootView } from "react-native-gesture-handler";
import CreatingTripPointSelector from "@/components/CreatingTripPointSelector";

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
  const style = createStyles(theme as MD3ThemeExtended);

  const [isVisible, setIsVisible] = useState<boolean>(false);
  const [dynamicLabel, setDynamicLabel] = useState<string>("");
  const [selectedTransferPoint, setSelectedTransferPoint] = useState<
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
  ]);

  const changeTransferType = (type: TransferType) => {
    if (selectedTransferPoint) {
      const updatedTransferPoints = transferPoints.includes(
        selectedTransferPoint,
      )
        ? transferPoints.map((point) =>
            point.id === selectedTransferPoint.id ? { ...point, type } : point,
          )
        : [...transferPoints, selectedTransferPoint].map((point) =>
            point.id === selectedTransferPoint.id ? { ...point, type } : point,
          );
      setTransferPoints(updatedTransferPoints);
    }
  };

  const transferPointOptions: Option[] = [
    {
      icon: BUS_ICON,
      label: "Autobus",
      onPress: () => changeTransferType("bus"),
    },
    {
      icon: TRAIN_ICON,
      label: "Pociąg",
      onPress: () => changeTransferType("train"),
    },
    {
      icon: CAR_ICON,
      label: "Samochód",
      onPress: () => changeTransferType("car"),
    },
    {
      icon: WALK_ICON,
      label: "Chód",
      onPress: () => changeTransferType("walk"),
    },
    {
      icon: NON_STANDARD_TRANSFER_ICON,
      label: "Ręcznie",
      onPress: () => changeTransferType("manual"),
    },
    {
      icon: DELETE_ICON,
      label: "Usuń",
      onPress: () => console.log(selectedTransferPoint),
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
    setIsVisible(true);
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

    if (!transferPoint) {
      // It will be replaced in the future - we need to create new transfer point but without saving it or request at the beginning in case the user cancels.
      const tempTransferPoint: TransferPoint = {
        id: "newID",
        fromTripPointId: fromTripPoint.id,
        toTripPointId: sortedTripPoints[index + 1].id,
        type: "empty",
        duration: 0,
      };
      return (
        <TransferPointNode
          transferPoint={tempTransferPoint}
          onPress={() => handleTransferPointPress(tempTransferPoint)}
        />
      );
    }

    return (
      <TransferPointNode
        onPress={() => {
          handleTransferPointPress(transferPoint);
        }}
        transferPoint={transferPoint}
      />
    );
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
          onClose={() => {
            setIsVisible(false);
            setDynamicLabel("");
          }}
          label={dynamicLabel}
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
  });

export default TripDayView;
