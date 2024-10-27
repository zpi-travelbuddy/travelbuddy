import { TripPoint } from "@/types/data";
import { StyleSheet, Dimensions } from "react-native";
import { Card, useTheme } from "react-native-paper";
import { formatTimeRange } from "@/utils/TimeUtils";

const { height, width } = Dimensions.get("window");

export const TripPointCard = ({
  tripPoint,
  onPress,
  onLongPress,
}: {
  tripPoint: TripPoint;
  onPress?: () => void;
  onLongPress?: () => void;
}) => {
  const theme = useTheme();
  const style = createStyles(theme);

  const { name, fromTime, toTime } = tripPoint;

  const timeRange = formatTimeRange(fromTime, toTime);

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
