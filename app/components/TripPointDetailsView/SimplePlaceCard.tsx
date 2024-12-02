import { Button, Card, useTheme } from "react-native-paper";
import { StyleSheet, View } from "react-native";
import { truncateText } from "@/utils/TextUtils";
import { PlaceViewModel } from "@/types/Place";

import { useRouter } from "expo-router";
import { MD3ThemeExtended } from "@/constants/Themes";

interface SimplePlaceCardProps {
  place: PlaceViewModel;
}

export function SimplePlaceCard({ place }: SimplePlaceCardProps) {
  const theme = useTheme();
  const styles = createStyles(theme as MD3ThemeExtended);
  const router = useRouter();

  const onPress = () => {
    router.push(`/trips/place/${place.providerId}`);
  };

  return (
    <Card mode="outlined" onPress={onPress}>
      <View style={styles.headerContainer}>
        <Card.Title
          titleStyle={styles.title}
          title={truncateText(place.title, 50)}
          subtitle={truncateText(place.subtitle, 50)}
        />
      </View>
    </Card>
  );
}

const createStyles = (theme: MD3ThemeExtended) =>
  StyleSheet.create({
    card: {
      marginBottom: 16,
    },
    headerContainer: {
      position: "relative",
    },
    title: {
      fontFamily: "Manrope_700Bold",
    },
  });
