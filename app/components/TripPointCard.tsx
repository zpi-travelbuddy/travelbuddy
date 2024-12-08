import { TripPointCompact } from "@/types/TripDayData";
import { StyleSheet, Dimensions, View } from "react-native";
import { Card, Icon, Text, useTheme } from "react-native-paper";
import { formatTimeFromString, formatTimeRange } from "@/utils/TimeUtils";
import { MD3ThemeExtended } from "@/constants/Themes";
import {
  FILL_SURVEY_ICON,
  LOCATION_ICON,
  NOTIFICATION_ICON,
} from "@/constants/Icons";
import { YELLOW } from "@/constants/Colors";

const { width } = Dimensions.get("window");

interface TripPointCardProps {
  tripPoint: TripPointCompact;
  onPress?: () => void;
  onLongPress?: () => void;
  isRegistered: (tripPointId: string) => boolean;
  isFillSurvey: (tripPoint: TripPointCompact) => boolean;
  openSurveyModal: () => void;
}

export const TripPointCard = ({
  tripPoint,
  onPress,
  onLongPress,
  isRegistered,
  isFillSurvey,
  openSurveyModal,
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

  const hasSurveyToFillOut = isFillSurvey(tripPoint);

  return (
    <Card
      onPress={hasSurveyToFillOut ? openSurveyModal : onPress}
      onLongPress={onLongPress}
      style={[style.card, hasSurveyToFillOut && style.cardWithSurvey]}
      mode="contained"
    >
      <Card.Title
        title={name}
        subtitle={
          <View style={style.subtitleContainer}>
            <Text>{timeRange}</Text>
            {hasLocation && <Icon size={20} source={LOCATION_ICON} />}
            {hasReminder && <Icon size={20} source={NOTIFICATION_ICON} />}
            {hasSurveyToFillOut && (
              <Icon size={20} color={YELLOW} source={FILL_SURVEY_ICON} />
            )}
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
    cardWithSurvey: {
      borderWidth: 2,
      borderColor: YELLOW,
    },
    subtitleContainer: {
      display: "flex",
      flexDirection: "row",
      alignItems: "center",
      gap: 10,
    },
  });
