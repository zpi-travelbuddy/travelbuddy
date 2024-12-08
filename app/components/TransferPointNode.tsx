import { TransferPoint, TransferType } from "@/types/TripDayData";
import { StyleSheet, TouchableWithoutFeedback, View } from "react-native";
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
import { useSnackbar } from "@/context/SnackbarContext";

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
  isWarningText?: boolean;
}

export const TransferPointNode = ({
  transferPoint,
  onPress,
  onPressEmpty,
  isWarningText = false,
}: TransferPointNodeProps) => {
  const theme = useTheme();
  const style = createStyles(theme as MD3ThemeExtended);
  const { showSnackbar } = useSnackbar();

  const { mode, seconds } = transferPoint || {};

  const minutes = useMemo(() => {
    return seconds != null ? Math.round(seconds / 60) : null;
  }, [seconds]);

  const icon = transferPoint
    ? TRANSFER_TYPE_MAP[mode as TransferType]
    : EMPTY_ICON;

  const handlePress = () => {
    showSnackbar(
      "Czas transferu pomiędzy punktami jest za długi. Zalecamy zmianę godziny.",
      "warning",
    );
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
      {minutes != null ? (
        <TouchableWithoutFeedback
          onPress={isWarningText ? handlePress : undefined}
        >
          <Text
            numberOfLines={1}
            style={[style.durationText, isWarningText && style.warningText]}
          >
            {formatMinutes(minutes)}
          </Text>
        </TouchableWithoutFeedback>
      ) : null}
    </View>
  );
};

const createStyles = (theme: MD3ThemeExtended) =>
  StyleSheet.create({
    wrapper: {
      position: "relative",
      alignItems: "center",
      width: 100,
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
    warningText: {
      color: "#FFCC00",
    },
  });
