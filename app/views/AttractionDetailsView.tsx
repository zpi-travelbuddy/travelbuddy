/* eslint-disable @typescript-eslint/no-explicit-any */
import {
  StyleSheet,
  View,
  Image,
  Dimensions,
  ScrollView,
  Linking,
} from "react-native";
import { useEffect, useMemo } from "react";
import { useTheme, Text } from "react-native-paper";
import { ADD_ICON, DEFAULT_ICON_SIZE, LOCATION_ICON } from "@/constants/Icons";
import ActionButtons from "@/components/ActionButtons";
import { MD3ThemeExtended } from "@/constants/Themes";
import { displayCost, displayTime, formatAddress } from "@/utils/TextUtils";
import StarRatingDisplayComponent from "@/components/StarRatingDisplayComponent";
import IconComponent from "@/components/IconComponent";
import { useAttractionDetails } from "@/composables/usePlace";
import LoadingView from "./LoadingView";
import { useLocalSearchParams, useRouter } from "expo-router";
import { useSnackbar } from "@/context/SnackbarContext";
import ConditionIcons from "@/components/ConditionIcons";
import { CategoryIcons, CategoryLabelsForTripCategory } from "@/types/Profile";
import { createLocationURL } from "@/utils/maps";
import { findAttractionCategory } from "@/utils/CategoryUtils";

const { height, width } = Dimensions.get("window");

const AttractionDetailsView = () => {
  const theme = useTheme() as MD3ThemeExtended;
  const styles = useMemo(() => createStyles(theme), [theme]);
  const router = useRouter();

  const { showSnackbar } = useSnackbar();

  const params = useLocalSearchParams();
  const { place_id, trip_id, day_id, date } = params;

  const { placeDetails, loading, error } = useAttractionDetails(
    place_id as string,
  );

  if (error) {
    router.back();
    showSnackbar(error?.toString() || "Unknown error", "error");
    return null;
  }

  const onLocationButtonPress = async () => {
    if (!placeDetails) {
      console.error("Place details not available");
      return;
    }

    const name = placeDetails.name;
    const [latitude, longitude] = [
      placeDetails.latitude,
      placeDetails.longitude,
    ];

    const url = createLocationURL(latitude, longitude, name);

    try {
      await Linking.openURL(url);
    } catch (error: any) {
      console.error(error);
    }
  };

  const onAddButtonPress = () => {
    router.navigate({
      // @ts-ignore
      pathname: `/trips/details/${trip_id}/day/${day_id}/tripPoints/create`,
      params: {
        attractionProviderId: place_id,
        date: date,
      },
    });
  };
  if (!placeDetails) {
    return <LoadingView transparent={false} />;
  }
  return (
    <>
      <View style={styles.container}>
        <ScrollView contentContainerStyle={styles.scrollContent}>
          <View style={styles.labelContainer}>
            <Text variant="headlineSmall">{placeDetails.name}</Text>
            <Text variant="titleSmall">{formatAddress(placeDetails)}</Text>

            <StarRatingDisplayComponent
              style={styles.starRatingPadding}
              rating={placeDetails?.averageRating || 0.0}
              editable={false}
            />

            <Text variant="bodySmall">Rodzaj</Text>
            <View style={styles.rowContainer}>
              <IconComponent
                source={CategoryIcons[findAttractionCategory(placeDetails)]}
                iconSize={DEFAULT_ICON_SIZE}
                color={theme.colors.onSurface}
                backgroundColor={theme.colors.primaryContainer}
              />
              <Text style={styles.label}>
                {
                  CategoryLabelsForTripCategory[
                    findAttractionCategory(placeDetails)
                  ]
                }
              </Text>
            </View>

            <Text style={styles.doubleSpace} variant="bodySmall">
              Udogodnienia
            </Text>

            <ConditionIcons
              placeConditions={placeDetails.conditions}
              style={styles.space}
              iconColor={theme.colors.onSurface}
            />

            <Text style={styles.doubleSpace} variant="bodySmall">
              Średni koszt na osobę
            </Text>
            <Text variant="titleSmall">
              {displayCost(placeDetails.averageCostPerPerson)}
            </Text>

            <Text style={styles.doubleSpace} variant="bodySmall">
              Średni czas pobytu
            </Text>
            <Text variant="titleSmall">
              {displayTime(placeDetails.averageTimeSpent)}
            </Text>
          </View>
        </ScrollView>

        <ActionButtons
          onAction1={onLocationButtonPress}
          action1ButtonLabel={"Mapa"}
          onAction2={onAddButtonPress}
          action2ButtonLabel={"Dodaj"}
          action1Icon={LOCATION_ICON}
          action2Icon={ADD_ICON}
        />
      </View>
      <LoadingView show={loading} transparent={false} />
    </>
  );
};

export default AttractionDetailsView;

const createStyles = (theme: MD3ThemeExtended) =>
  StyleSheet.create({
    space: {
      paddingTop: 10,
    },
    doubleSpace: {
      paddingTop: 20,
    },
    rowContainer: {
      flexDirection: "row",
      alignItems: "center",
      flex: 3,
      paddingTop: 10,
    },
    container: {
      flex: 1,
      backgroundColor: theme.colors.background,
    },
    labelContainer: {
      paddingHorizontal: 20,
    },
    scrollContent: {},
    fab: {
      backgroundColor: theme.colors.primary,
      position: "absolute",
      bottom: width * 0.85,
      right: 16,
      borderRadius: 10000,
    },
    image: {
      marginVertical: 25,
      width: "100%",
      height: height * 0.2,
    },
    label: {
      ...theme.fonts.bodyLarge,
      marginLeft: 10,
      textAlign: "center",
      color: theme.colors.onBackground,
    },
    starRatingPadding: {
      paddingVertical: 10,
    },
  });
