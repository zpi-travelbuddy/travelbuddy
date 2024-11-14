import { StyleSheet, View, Image, Dimensions, ScrollView } from "react-native";
import React, { useEffect, useMemo, useState } from "react";
import { useTheme, Text } from "react-native-paper";
import {
  ADD_ICON,
  DEFAULT_ICON_SIZE,
  DOG_ICON,
  HUMAN_DISABLE_ICON,
  VEGAN_ICON,
  LOCATION_ICON,
} from "@/constants/Icons";
import ActionButtons from "@/components/ActionButtons";
import { MD3ThemeExtended } from "@/constants/Themes";
import { displayCost, displayTime, formatAddress } from "@/utils/TextUtils";
import StarRatingDisplayComponent from "@/components/StarRatingDisplayComponent";
import IconComponent from "@/components/IconComponent";
import IconRow from "@/components/IconRow";
import { formatMinutesInWords } from "@/utils/TimeUtils";
import { AttractionTypeIcons, AttractionTypeLabels } from "@/types/Trip";
import usePlaceDetails from "@/composables/usePlace";
import { PlaceViewModel } from "@/types/Place";
import LoadingView from "./LoadingView";
import { useRouter } from "expo-router";
import { useSnackbar } from "@/context/SnackbarContext";
import { convertToPlaceViewModel } from "@/converters/placeConverter";

const { height, width } = Dimensions.get("window");

// const attraction: AttractionViewModel = {
//   name: "Wycieczka do Londynu",
//   address: {
//     street: "",
//     number: "",
//     city: "Londyn",
//     country: "Wielka Brytania",
//   },
//   attractionType: "park",
//   conveniences: [],
//   rating: 5,
//   averageCostPerPerson: 0,
//   averageVisitTime: 120,
//   latitude: 51.50861,
//   longitude: -0.163611,
//   imageUrl: "https://upload.wikimedia.org/wikipedia/commons/1/1a/Big_Ben..JPG",
// };

const AttractionDetailsView = () => {
  const theme = useTheme() as MD3ThemeExtended;
  const styles = useMemo(() => createStyles(theme), [theme]);
  const router = useRouter();

  const { showSnackbar } = useSnackbar();

  // const params = useLocalSearchParams();
  // const { id } = params;
  const id = "eb2a3de6-8998-4a3c-992c-9e4fd76ef027";

  const { placeDetails, loading, error, refetch } = usePlaceDetails(id);
  const [placeViewModel, setPlaceViewModel] = useState<PlaceViewModel | null>(
    null,
  );

  useEffect(() => {
    if (placeDetails) setPlaceViewModel(convertToPlaceViewModel(placeDetails));
  }, [placeDetails]);

  if (loading) {
    return <LoadingView />;
  }

  if (error) {
    router.back();
    showSnackbar(error?.toString() || "Unknown error", "error");
    return null;
  }

  if (placeViewModel) {
    return (
      <View style={styles.container}>
        <ScrollView contentContainerStyle={styles.scrollContent}>
          <Image
            source={{
              uri: "https://upload.wikimedia.org/wikipedia/commons/1/1a/Big_Ben..JPG",
            }}
            style={styles.image}
            resizeMode="cover"
          />
          <View style={styles.labelContainer}>
            <Text variant="headlineSmall">{placeViewModel.name}</Text>
            <Text variant="titleSmall">
              {formatAddress(placeViewModel.address)}
            </Text>

            <StarRatingDisplayComponent
              style={styles.starRatingPadding}
              rating={placeViewModel.rating || 0.0}
            />

            <Text variant="bodySmall">Rodzaj</Text>
            <View style={styles.rowContainer}>
              <IconComponent
                source={AttractionTypeIcons[placeViewModel.attractionType]}
                iconSize={DEFAULT_ICON_SIZE}
                color={theme.colors.onSurface}
                backgroundColor={theme.colors.primaryContainer}
              />
              <Text style={styles.label}>
                {AttractionTypeLabels[placeViewModel.attractionType]}
              </Text>
            </View>

            <Text style={styles.doubleSpace} variant="bodySmall">
              Udogodnienia
            </Text>

            <IconRow
              style={styles.space}
              icons={[HUMAN_DISABLE_ICON, DOG_ICON, VEGAN_ICON]}
              iconColor={theme.colors.onSurface}
            />

            <Text style={styles.doubleSpace} variant="bodySmall">
              Średni koszt na osobę
            </Text>
            <Text variant="titleSmall">
              {displayCost(placeViewModel.averageCostPerPerson)}
            </Text>

            <Text style={styles.doubleSpace} variant="bodySmall">
              Średni czas pobytu
            </Text>
            <Text variant="titleSmall">
              {displayTime(placeViewModel.averageVisitTime)}
            </Text>
          </View>
        </ScrollView>

        <ActionButtons
          onAction1={() => {
            console.log("Opening Maps");
          }}
          action1ButtonLabel={"Mapa"}
          onAction2={() => {
            console.log("Adding to trip");
          }}
          action2ButtonLabel={"Dodaj"}
          action1Icon={LOCATION_ICON}
          action2Icon={ADD_ICON}
        />
      </View>
    );
  } else {
    router.back();
    showSnackbar("Wystąpił błąd", "error");
    return null;
  }
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
