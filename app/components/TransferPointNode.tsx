import { TransferPoint, TransferType } from "@/types/data";
import { StyleSheet, View } from "react-native";
import { useTheme, Text, IconButton } from "react-native-paper";
import { DashedVerticalLine } from "./DashedVerticalLine";
import { formatMinutes } from "@/utils/TimeUtils";
import {
  WALK_ICON,
  BUS_ICON,
  CAR_ICON,
  MANUAL_ICON,
  EMPTY_ICON,
} from "@/constants/Icons";

const VERTICAL_LINE_HEIGHT = 20;

// Defined in case the icon name is different than type name
const TRANSFER_TYPE_MAP: {
  [key in TransferType]: string;
} = {
  walk: WALK_ICON,
  bus: BUS_ICON,
  car: CAR_ICON,
  manual: MANUAL_ICON,
};

const ICON_SIZE = 40;

export const TransferPointNode = ({
  transferPoint,
  onPress,
  onPressEmpty,
}: {
  transferPoint?: TransferPoint;
  onPress?: () => void;
  onPressEmpty?: () => void;
}) => {
  // change any to MD3ThemeExtended later
  const theme = useTheme() as any;
  const style = createStyles(theme);

  const { type, duration } = transferPoint || {};

  return (
    <View style={style.wrapper}>
      <DashedVerticalLine height={VERTICAL_LINE_HEIGHT} />
      {type ? (
        <IconButton
          icon={TRANSFER_TYPE_MAP[type]}
          size={ICON_SIZE}
          style={style.iconButton}
          iconColor={theme.colors.onSurface}
          onPress={onPress}
        />
      ) : (
        <IconButton
          icon={EMPTY_ICON}
          size={ICON_SIZE}
          style={style.iconButton}
          iconColor={theme.colors.onSurface}
          onPress={onPressEmpty}
        />
      )}
      <DashedVerticalLine height={VERTICAL_LINE_HEIGHT} />
      {duration ? (
        <Text numberOfLines={1} style={style.durationText}>
          {formatMinutes(duration)}
        </Text>
      ) : null}
    </View>
  );
};

const createStyles = (theme: any) =>
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
      transformOrigin: "right",
    },
  });
