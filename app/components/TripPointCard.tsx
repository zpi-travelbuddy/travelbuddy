import { TripPointCompact } from "@/types/TripDayData";
import { StyleSheet, Dimensions, View } from "react-native";
import { Card, Icon, Text, useTheme } from "react-native-paper";
import { formatTimeFromString, formatTimeRange } from "@/utils/TimeUtils";
import { MD3ThemeExtended } from "@/constants/Themes";
import { LOCATION_ICON, NOTIFICATION_ICON } from "@/constants/Icons";

const { width } = Dimensions.get("window");

interface TripPointCardProps {
  tripPoint: TripPointCompact;
  onPress?: () => void;
  onLongPress?: () => void;
  isRegistered: (tripPointId: string) => boolean;
}

export const TripPointCard = ({
  tripPoint,
  onPress,
  onLongPress,
  isRegistered,
}: TripPointCardProps) => {
  const theme = useTheme();
  const style = createStyles(theme as MD3ThemeExtended);

  const { name, startTime, endTime } = tripPoint;

  const timeRange = formatTimeRange(
    formatTimeFromString(startTime),
    formatTimeFromString(endTime),
  );

  const hasReminder = isRegistered(tripPoint.id);

  const hasLocation = tripPoint.latitude && tripPoint.longitude;

  return (
    <Card
      onPress={onPress}
      onLongPress={onLongPress}
      style={style.card}
      mode="contained"
    >
      <Card.Title
        title={name}
        subtitle={
          <View
            style={{
              display: "flex",
              flexDirection: "row",
              alignItems: "center",
              gap: 10,
            }}
          >
            <Text>{timeRange}</Text>
            {hasLocation && <Icon size={20} source={LOCATION_ICON} />}
            {hasReminder && <Icon size={20} source={NOTIFICATION_ICON} />}
          </View>
        }
        titleVariant="titleMedium"
      />
    </Card>
  );
};

const createStyles = (theme: MD3ThemeExtended) =>
  StyleSheet.create({
    card: {
      backgroundColor: theme.colors.surfaceContainer,
      width: Math.min(300, width * 0.8),
    },
  });
