import { TripPointCompact } from "@/types/data";
import { StyleSheet, Dimensions } from "react-native";
import { Card, useTheme } from "react-native-paper";
import { formatTimeRange } from "@/utils/TimeUtils";

const { height, width } = Dimensions.get("window");

interface TripPointCardProps {
  tripPoint: TripPoint;
  onPress?: () => void;
  onLongPress?: () => void;
}

export const TripPointCard = ({
  tripPoint,
  onPress,
  onLongPress,
}: TripPointCardProps) => {
  const theme = useTheme();
  const style = createStyles(theme);

  const { name, startTime, endTime } = tripPoint;

  const timeRange = formatTimeRange(startTime, endTime);

  return (
    <Card
      onPress={onPress}
      onLongPress={onLongPress}
      style={style.card}
      mode="contained"
    >
      <Card.Title title={name} subtitle={timeRange} />
    </Card>
  );
};

const createStyles = (theme: any) =>
  StyleSheet.create({
    card: {
      backgroundColor: theme.colors.surfaceContainer,
      width: Math.min(300, width * 0.8),
    },
  });
