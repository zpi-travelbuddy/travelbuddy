import { TransferPoint, TransferType } from "@/types/TripDayData";
import { StyleSheet, View } from "react-native";
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
} from "@/constants/Icons";
import { useMemo } from "react";
import { MD3ThemeExtended } from "@/constants/Themes";

const VERTICAL_LINE_HEIGHT = 20;
const ICON_SIZE = 40;

// Defined in case the icon name is different than type name
const TRANSFER_TYPE_MAP = {
  [TransferType.Car]: CAR_ICON,
  [TransferType.Motorbike]: MOTORBIKE_ICON,
  [TransferType.Bicycle]: BICYCLE_ICON,
  [TransferType.Walk]: WALK_ICON,
  null: NON_STANDARD_TRANSFER_ICON,
};

interface TransferPointNodeProps {
  transferPoint?: TransferPoint;
  onPress?: () => void;
  onPressEmpty?: () => void;
}

export const TransferPointNode = ({
  transferPoint,
  onPress,
  onPressEmpty,
}: TransferPointNodeProps) => {
  const theme = useTheme();
  const style = createStyles(theme as MD3ThemeExtended);

  const { mode, seconds } = transferPoint || {};

  const minutes = useMemo(() => {
    return seconds != null ? Math.round(seconds / 60) : null;
  }, [seconds]);

  const icon = transferPoint
    ? TRANSFER_TYPE_MAP[mode as TransferType]
    : EMPTY_ICON;

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
  });
