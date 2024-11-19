import { TransferPoint, TransferType } from "@/types/TripDayData";
import { StyleSheet, View } from "react-native";
import { useTheme, Text, IconButton } from "react-native-paper";
import { DashedVerticalLine } from "./DashedVerticalLine";
import { formatMinutes } from "@/utils/TimeUtils";
import {
  WALK_ICON,
  BUS_ICON,
  CAR_ICON,
  EMPTY_ICON,
  TRAIN_ICON,
  NON_STANDARD_TRANSFER_ICON,
} from "@/constants/Icons";
import { MD3ThemeExtended } from "@/constants/Themes";

const VERTICAL_LINE_HEIGHT = 20;
const ICON_SIZE = 40;

// Defined in case the icon name is different than type name
const TRANSFER_TYPE_MAP: {
  [key in TransferType]: string;
} = {
  walk: WALK_ICON,
  bus: BUS_ICON,
  car: CAR_ICON,
  train: TRAIN_ICON,
  manual: NON_STANDARD_TRANSFER_ICON,
  empty: EMPTY_ICON,
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
  // change any to MD3ThemeExtended later
  const theme = useTheme() as MD3ThemeExtended;
  const style = createStyles(theme);

  const { mode, seconds: duration } = transferPoint || {};

  const icon = mode ? TRANSFER_TYPE_MAP[mode] : EMPTY_ICON;
  const handlePress = mode ? onPress : onPressEmpty;

  return (
    <View style={style.wrapper}>
      <DashedVerticalLine height={VERTICAL_LINE_HEIGHT} />
      <IconButton
        icon={icon}
        size={ICON_SIZE}
        style={style.iconButton}
        iconColor={theme.colors.onSurface}
        onPress={handlePress}
      />
      <DashedVerticalLine height={VERTICAL_LINE_HEIGHT} />
      {duration ? (
        <Text numberOfLines={1} style={style.durationText}>
          {formatMinutes(duration)}
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
