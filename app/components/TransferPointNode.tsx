import {
  TransferPoint,
  TransferType,
  TripPointCompact,
} from "@/types/TripDayData";
import { Linking, StyleSheet, View } from "react-native";
import { useTheme, Text, IconButton } from "react-native-paper";
import { DashedVerticalLine } from "./DashedVerticalLine";
import { formatMinutes } from "@/utils/TimeUtils";
import {
  WALK_ICON,
  BICYCLE_ICON,
  CAR_ICON,
  EMPTY_ICON,
  NON_STANDARD_TRANSFER_ICON,
  MOTORBIKE_ICON,
  NAVIGATION_ICON,
} from "@/constants/Icons";
import { useMemo } from "react";
import { MD3ThemeExtended } from "@/constants/Themes";
import { createNavigationURL } from "@/utils/maps";

const VERTICAL_LINE_HEIGHT = 20;
const ICON_SIZE = 40;

const SMALL_ICON_SIZE = 30;

// Defined in case the icon name is different than type name
const TRANSFER_TYPE_MAP = {
  [TransferType.Car]: CAR_ICON,
  [TransferType.Motorbike]: MOTORBIKE_ICON,
  [TransferType.Bicycle]: BICYCLE_ICON,
  [TransferType.Walk]: WALK_ICON,
  null: NON_STANDARD_TRANSFER_ICON,
};

// For Google Maps travel mode
const TRANSFER_TYPE_MAP_GOOGLE = {
  [TransferType.Car]: "driving",
  [TransferType.Motorbike]: "driving",
  [TransferType.Bicycle]: "bicycling",
  [TransferType.Walk]: "walking",
  null: "driving",
};

interface TransferPointNodeProps {
  transferPoint?: TransferPoint;
  tripPointContext: {
    fromTripPoint: TripPointCompact;
    toTripPoint: TripPointCompact;
  };
  onPress?: () => void;
}

export const TransferPointNode = ({
  transferPoint,
  tripPointContext,
  onPress,
}: TransferPointNodeProps) => {
  const theme = useTheme();
  const style = createStyles(theme as MD3ThemeExtended);

  const { fromTripPoint, toTripPoint } = tripPointContext;

  const { mode, seconds } = transferPoint || {};

  const minutes = useMemo(() => {
    return seconds != null ? Math.round(seconds / 60) : null;
  }, [seconds]);

  const icon = transferPoint
    ? TRANSFER_TYPE_MAP[mode as TransferType]
    : EMPTY_ICON;

  const { latitude: fromLatitude, longitude: fromLongitude } = fromTripPoint;
  const { latitude: toLatitude, longitude: toLongitude } = toTripPoint;

  const canNavigate =
    fromLatitude && fromLongitude && toLatitude && toLongitude;

  const handleNavigationButtonPress = async () => {
    const travelMode = TRANSFER_TYPE_MAP_GOOGLE[mode as TransferType];

    if (!canNavigate) {
      console.error("Can't navigate without coordinates");
      return;
    }

    const url = createNavigationURL(
      fromLatitude,
      fromLongitude,
      toLatitude,
      toLongitude,
      travelMode,
    );

    try {
      await Linking.openURL(url);
    } catch (error) {
      console.error(error);
    }
  };

  return (
    <View style={style.wrapper}>
      <DashedVerticalLine height={VERTICAL_LINE_HEIGHT} />
      <IconButton
        icon={icon}
        size={ICON_SIZE}
        style={style.iconButton}
        iconColor={theme.colors.onSurface}
        onPress={onPress}
      />
      <DashedVerticalLine height={VERTICAL_LINE_HEIGHT} />
      {transferPoint && canNavigate ? (
        <View style={style.leftComponent}>
          <IconButton
            icon={NAVIGATION_ICON}
            size={SMALL_ICON_SIZE}
            style={style.leftComponentButton}
            iconColor={theme.colors.onTertiaryContainer}
            onPress={handleNavigationButtonPress}
          />
        </View>
      ) : null}
      {minutes != null ? (
        <Text numberOfLines={1} style={style.durationText}>
          {formatMinutes(minutes)}
        </Text>
      ) : null}
    </View>
  );
};

const createStyles = (theme: MD3ThemeExtended) =>
  StyleSheet.create({
    wrapper: {
      position: "relative",
      alignItems: "center",
      width: 80,
    },
    iconButton: {
      backgroundColor: theme.colors.surfaceContainer,
      margin: 0,
    },
    durationText: {
      position: "absolute",
      top: "50%",
      transform: [{ translateY: -10 }],
      left: "100%",
      height: 20,
    },
    leftComponent: {
      position: "absolute",
      top: "50%",
      transform: [{ translateY: -22 }],
      right: "115%",
      display: "flex",
      alignItems: "center",
    },
    leftComponentButton: {
      margin: 0,
      backgroundColor: theme.colors.tertiaryContainer,
    },
  });
