import { Dimensions, StyleSheet } from "react-native";
import React, { useEffect, useState } from "react";
import { Card, MD3Theme, Text, useTheme } from "react-native-paper";
import useTripImageStorage from "@/hooks/useTripImageStore";
import { DEFAULT_TRIP_IMAGE, TRIP_IMAGES } from "@/constants/Images";

interface TripCardProps {
  id: string;
  title: string;
  subtitle: string;
  isArchived: boolean;
  onPress?: () => void;
  onLongPress?: () => void;
}

const { width } = Dimensions.get("window");
const CARD_WIDTH = width * 0.85;
const CARD_ASPECT_RATIO = 4 / 3;
const CARD_HEIGHT = CARD_WIDTH / CARD_ASPECT_RATIO + 10;

export const TripCard: React.FC<TripCardProps> = ({
  id,
  title,
  subtitle,
  isArchived,
  onPress,
  onLongPress,
}) => {
  const theme = useTheme();
  const styles = createStyles(theme);
  const { getImageName } = useTripImageStorage();
  const [resolvedImage, setResolvedImage] = useState(null);

  const resolvedImageSource = resolvedImage ?? DEFAULT_TRIP_IMAGE;

  useEffect(() => {
    const fetchImageName = async () => {
      const storedImageName = await getImageName(id);
      setResolvedImage(storedImageName ? TRIP_IMAGES[storedImageName] : null);
    };

    fetchImageName();
  }, [id, getImageName]);

  const handlePress = () => {
    if (onPress) onPress();
    console.log("Go to details!");
  };

  const handleLongPress = () => {
    if (onLongPress) onLongPress();
    console.log("Go to trip settings!");
  };

  return (
    <Card
      mode="outlined"
      style={styles.card}
      onPress={handlePress}
      onLongPress={handleLongPress}
    >
      <Card.Cover
        style={{ ...styles.image, opacity: isArchived ? 0.25 : 1 }}
        source={resolvedImageSource}
      />
      <Card.Content style={styles.textContent}>
        <Text style={{ ...styles.text, ...styles.title }}>{title}</Text>
        <Text style={{ ...styles.text, ...styles.subtitle }}>{subtitle}</Text>
      </Card.Content>
    </Card>
  );
};

const createStyles = (theme: MD3Theme) =>
  StyleSheet.create({
    image: {
      width: "100%",
      height: "70%",
      resizeMode: "cover",
      borderBottomLeftRadius: 0,
      borderBottomRightRadius: 0,
    },
    text: {
      alignSelf: "center",
      width: "100%",
    },
    title: {
      marginTop: 10,
      ...theme.fonts.titleMedium,
    },
    subtitle: {
      ...theme.fonts.default,
    },
    textContent: {
      height: "35%",
    },
    card: {
      width: CARD_WIDTH,
      height: CARD_HEIGHT,
      alignSelf: "center",
      marginVertical: 10,
    },
  });
