import { MD3ThemeExtended } from "@/constants/Themes";
import { ScrollView, StyleSheet, View } from "react-native";
import { Divider, Text, useTheme } from "react-native-paper";
import { TripPointDetails, TripPointViewModel } from "@/types/TripDayData";
import { TripPointDetailsLabel } from "@/components/TripPointDetailLabel";
import { getMoneyWithCurrency } from "@/utils/CurrencyUtils";
import { useLayoutEffect, useMemo, useState } from "react";
import { Link, router, useLocalSearchParams, useNavigation } from "expo-router";
import { DEFAULT_ICON_SIZE, DELETE_ICON } from "@/constants/Icons";
import CustomModal from "@/components/CustomModal";
import { formatTimeRange, getTimeWithoutSeconds } from "@/utils/TimeUtils";
import ActionTextButtons from "@/components/ActionTextButtons";
import { useDeleteTripPoint } from "@/composables/useTripPoint";
import { formatAddress } from "@/utils/TextUtils";
import LoadingView from "./LoadingView";
import { TripDetails } from "@/types/Trip";
import IconComponent from "@/components/IconComponent";
import {
  CategoryIcons,
  CategoryLabelsForTripCategory,
  DEFAULT_CATEGORY_NAME,
} from "@/types/Profile";
import { findAttractionCategory } from "@/utils/CategoryUtils";
import { PlaceDetails, PlaceOverview } from "@/types/Place";

interface TripPointDetailsViewProps {
  tripPoint: TripPointDetails | null;
  trip: TripDetails | null;
}

const LABELS: Record<string, string> = {
  name: "Nazwa punktu",
  address: "Adres punktu",
  category: "Rodzaj",
  predictedCost: "Przewidywany koszt łączny",
  predictedCostPerPerson: "Przewidywany koszt na osobę",
  startTime: "Godzina rozpoczęcia",
  endTime: "Godzina zakończenia",
  comment: "Komentarz",
};

const parseTripPoint = (
  tripPoint: TripPointDetails | null,
  trip: TripDetails | null,
): TripPointViewModel => {
  if (!tripPoint) {
    return {};
  }

  const category = tripPoint.category?.name || "Brak danych";

  const address = tripPoint.place
    ? formatAddress(tripPoint.place, false)
    : "Brak danych";

  const predictedCost =
    tripPoint.predictedCost != null
      ? getMoneyWithCurrency(
          tripPoint.predictedCost || 0,
          tripPoint.currencyCode,
        )
      : "Brak danych";

  const predictedCostPerPerson =
    tripPoint.predictedCost != null && trip?.numberOfTravelers
      ? getMoneyWithCurrency(
          tripPoint.predictedCost / trip.numberOfTravelers || 0,
          tripPoint.currencyCode,
        )
      : "Brak danych";

  const startTime = tripPoint.startTime
    ? getTimeWithoutSeconds(tripPoint.startTime)
    : "Brak danych";

  const endTime = tripPoint.endTime
    ? getTimeWithoutSeconds(tripPoint.endTime)
    : "Brak danych";

  const comment = tripPoint.comment || "Brak danych";

  return {
    name: tripPoint.name,
    address,
    category,
    predictedCost,
    predictedCostPerPerson,
    startTime,
    endTime,
    comment,
  };
};

const OpeningsHours = ({
  openingTime,
  closingTime,
  startTime,
  endTime,
}: {
  openingTime: string | undefined;
  closingTime: string | undefined;
  startTime: string | undefined;
  endTime: string | undefined;
}) => {
  const theme = useTheme();
  const styles = createStyles(theme as MD3ThemeExtended);

  let fitsInTripPoint = false;

  if (startTime && openingTime && endTime && closingTime) {
    if (openingTime <= closingTime) {
      fitsInTripPoint = startTime >= openingTime && endTime <= closingTime;
    } else {
      fitsInTripPoint =
        (startTime >= "00:00:00" && endTime <= closingTime) ||
        (startTime >= openingTime && endTime <= "24:00:00");
    }
  }

  if (!openingTime || !closingTime) {
    return <Text style={styles.value}>Brak danych</Text>;
  }

  return (
    <Text style={[fitsInTripPoint ? {} : styles.warning, styles.value]}>
      {getTimeWithoutSeconds(openingTime)} -{" "}
      {getTimeWithoutSeconds(closingTime)}
      {fitsInTripPoint ? "" : "(wizyta poza godzinami otwarcia!)"}
    </Text>
  );
};

const TripPointDetailsView = ({
  tripPoint,
  trip,
}: TripPointDetailsViewProps) => {
  const theme = useTheme();
  const styles = createStyles(theme as MD3ThemeExtended);
  const { trip_id, day_id } = useLocalSearchParams();
  const navigation = useNavigation();

  const { deleteTripPoint, loading, error } = useDeleteTripPoint();

  console.log(JSON.stringify(tripPoint));
  console.log(JSON.stringify(trip));

  const [isModalVisible, setIsModalVisible] = useState<boolean>(false);

  const parsedTripPoint: TripPointViewModel = useMemo(
    () => parseTripPoint(tripPoint, trip),
    [tripPoint, trip],
  );

  const hideModal = () => setIsModalVisible(false);
  const showRemovalModal = () => setIsModalVisible(true);

  const onDeleteTripPoint = async () => {
    await deleteTripPoint(tripPoint?.id);
    router.navigate({
      // @ts-ignore
      pathname: `/trips/details/${trip_id}/day/${day_id}`,
      params: { refresh: "true" },
    });
  };

  console.log(JSON.stringify(tripPoint));
  console.log(JSON.stringify(trip));

  useLayoutEffect(() => {
    navigation.setOptions({
      actions: [
        {
          hasMenu: true,
          menuActions: [
            {
              title: "Usuń",
              icon: DELETE_ICON,
              color: theme.colors.error,
              onPress: () => {
                showRemovalModal();
              },
            },
          ],
        },
      ],
    });
  }, [navigation]);

  if (loading) {
    return <LoadingView />;
  }

  return (
    <>
      <ScrollView style={styles.container}>
        {Object.entries(parsedTripPoint)
          .filter(([key]) => key in LABELS)
          .map(([key, value]) => (
            <TripPointDetailsLabel
              key={key}
              title={LABELS[key]}
              element={
                key === "category" ? (
                  <View style={styles.rowContainer}>
                    <IconComponent
                      source={
                        CategoryIcons[
                          tripPoint?.place?.superCategory?.name ??
                            DEFAULT_CATEGORY_NAME
                        ]
                      }
                      iconSize={DEFAULT_ICON_SIZE}
                      color={theme.colors.onSurface}
                      backgroundColor={theme.colors.primaryContainer}
                    />
                    <Text style={styles.label}>
                      {
                        CategoryLabelsForTripCategory[
                          tripPoint?.place?.superCategory?.name ??
                            DEFAULT_CATEGORY_NAME
                        ]
                      }
                    </Text>
                  </View>
                ) : (
                  <Text style={styles.value}>
                    {value?.toString() || "Brak danych"}
                  </Text>
                )
              }
            />
          ))}

        {tripPoint?.place && (
          <View style={styles.placeDetails}>
            <Divider style={styles.divider} />
            <Text variant="titleLarge" style={styles.placeTitle}>
              Powiązana atrakcja
            </Text>
            <TripPointDetailsLabel
              title="Nazwa"
              element={
                <Text style={styles.value}>
                  {tripPoint?.place?.name || "Brak danych"}
                </Text>
              }
            />
            <TripPointDetailsLabel
              title="Godziny otwarcia"
              element={
                <OpeningsHours
                  openingTime={tripPoint.openingTime}
                  closingTime={tripPoint.closingTime}
                  startTime={tripPoint.startTime}
                  endTime={tripPoint.endTime}
                />
              }
            />
            <Text style={styles.placeUrl} variant="titleMedium">
              <Link href={`/trips/place/${tripPoint.place.providerId}`}>
                Sprawdź szczegóły
              </Link>
            </Text>
          </View>
        )}
      </ScrollView>
      <CustomModal visible={isModalVisible} onDismiss={hideModal}>
        <View>
          <Text style={styles.modalTitleText}>
            Czy na pewno chcesz usunąć ten punkt wycieczki?
          </Text>
          <View style={styles.modalContent}>
            <Text style={styles.boldText}>{parsedTripPoint.name}</Text>
            <Text style={styles.modalSubtitle}>
              {formatTimeRange(
                parsedTripPoint.startTime || "",
                parsedTripPoint.endTime || "",
              )}
            </Text>
          </View>
          <ActionTextButtons
            onAction1={hideModal}
            onAction2={onDeleteTripPoint}
            action1ButtonLabel="Anuluj"
            action2ButtonLabel="Usuń"
            action1Icon={undefined}
            action2Icon={undefined}
          />
        </View>
      </CustomModal>
    </>
  );
};

export default TripPointDetailsView;

const createStyles = (theme: MD3ThemeExtended) =>
  StyleSheet.create({
    container: {
      flex: 1,
      backgroundColor: theme.colors.background,
    },
    value: {
      ...theme.fonts.titleMedium,
    },
    modalTitleText: {
      ...theme.fonts.titleLarge,
      color: theme.colors.onSurface,
    },
    modalContent: {
      marginVertical: 20,
    },
    boldText: {
      fontWeight: "bold",
      color: theme.colors.onSurface,
    },
    modalSubtitle: {
      color: theme.colors.onSurface,
    },
    placeTitle: { paddingHorizontal: 16 },
    warning: {
      color: theme.colors.error,
    },
    placeUrl: {
      marginTop: 10,
      paddingHorizontal: 16,
      color: theme.colors.tertiary,
      fontFamily: "Manrope_700Bold",
      textDecorationLine: "underline",
    },
    placeDetails: {
      marginBottom: 80,
    },
    divider: { marginVertical: 10 },
    rowContainer: {
      flexDirection: "row",
      alignItems: "center",
      flex: 3,
      paddingTop: 10,
      width: "100%",
    },
    label: {
      ...theme.fonts.bodyLarge,
      marginLeft: 10,
      textAlign: "center",
      color: theme.colors.onBackground,
    },
  });
