import { ScrollView, StyleSheet, View } from "react-native";
import { TripPointCard } from "@/components/TripPointCard";
import { TransferPointNode } from "@/components/TransferPointNode";
import { TripPoint, TransferPoint } from "@/types/data";
import { useTheme, FAB } from "react-native-paper";
import { Fragment, useEffect, useMemo, useState } from "react";
import { GestureHandlerRootView } from "react-native-gesture-handler";
import CreatingTransferSelector from "@/components/CreatingTransferSelector";
import {
  BUS_ICON,
  CAR_ICON,
  DELETE_TRANSFER_ICON,
  NON_STANDARD_TRANSFER_ICON,
  TRAIN_ICON,
  WALK_ICON,
} from "@/constants/Icons";
import { useRouter, useLocalSearchParams } from "expo-router";

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

const transferPoints: TransferPoint[] = [
  {
    id: "1",
    fromTripPointId: "2",
    toTripPointId: "3",
    type: "walk",
    duration: 110,
  },
];

const TripDayView = () => {
  const theme = useTheme();
  const style = createStyles(theme);
  const router = useRouter();
  const params = useLocalSearchParams();
  const { id, day_id } = params;

  const [isVisible, setIsVisible] = useState<boolean>(false);
  const [isExtendedView, setIsExtendedView] = useState<boolean>(false);
  const [tripTime, setTripTime] = useState<number | undefined>(undefined);

  const options: Option[] = [
    { icon: BUS_ICON, label: "", onPress: () => console.log("") },
    { icon: TRAIN_ICON, label: "", onPress: () => console.log("") },
    { icon: CAR_ICON, label: "", onPress: () => console.log("") },
    { icon: WALK_ICON, label: "", onPress: () => console.log("") },
    {
      icon: NON_STANDARD_TRANSFER_ICON,
      label: "",
      onPress: () => setIsExtendedView(true),
    },
    {
      icon: DELETE_TRANSFER_ICON,
      label: "",
      onPress: () => console.log(""),
    },
  ];

  const handleTripPointPress = () => {
    console.log("Trip point pressed");
  };

  const handleTripPointLongPress = () => {
    console.log("Trip point long pressed");
  };

  const handleTransferPointPress = () => {
    console.log("Transfer point pressed");
  };

  const handleEmptyTransferPointPress = () => {
    console.log("Empty transfer point pressed");
    setIsVisible(true);
  };

  useEffect(() => {
    console.log("isVisible: " + isVisible);
  }, [isVisible]);

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

  const renderTransferPoint = (tripPointId: string, index: number) => {
    if (index === tripPoints.length - 1) {
      return null;
    }

    const transferPoint = transferPointMap.get(tripPointId);

    if (!transferPoint) {
      return <TransferPointNode onPressEmpty={handleEmptyTransferPointPress} />;
    }

    return (
      <TransferPointNode
        onPress={handleTransferPointPress}
        transferPoint={transferPoint}
      />
    );
  };

  return (
    <GestureHandlerRootView>
      <ScrollView
        style={style.container}
        contentContainerStyle={style.containerContent}
      >
        <View style={{ height: 40 }} />
        {sortedTripPoints.map((tripPoint, index) => (
          <Fragment key={tripPoint.id}>
            <TripPointCard
              onPress={handleTripPointPress}
              onLongPress={handleTripPointLongPress}
              tripPoint={tripPoint}
            />
            {renderTransferPoint(tripPoint.id, index)}
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
          console.log("DEBUG")
          setIsVisible(true);
        }}
      />

      <CreatingTransferSelector
        options={options}
        isVisible={isVisible}
        isExtendedView={isExtendedView}
        tripTime={tripTime}
        onChange={setTripTime}
        onClose={() => {
          setIsVisible(false);
        }}
      />
    </GestureHandlerRootView>
  );
};

const createStyles = (theme: any) =>
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
