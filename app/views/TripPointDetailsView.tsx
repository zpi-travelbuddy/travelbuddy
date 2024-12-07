import { MD3ThemeExtended } from "@/constants/Themes";
import { ScrollView, StyleSheet, View } from "react-native";
import { Text, useTheme } from "react-native-paper";
import { TripPointDetails, TripPointViewModel } from "@/types/TripDayData";
import { TripPointDetailsLabel } from "@/components/TripPointDetailLabel";
import { SimplePlaceCard } from "@/components/TripPointDetailsView/SimplePlaceCard";
import { getMoneyWithCurrency } from "@/utils/CurrencyUtils";
import { useLayoutEffect, useMemo, useState } from "react";
import { Place, PlaceViewModel } from "@/types/Place";
import { router, useLocalSearchParams, useNavigation } from "expo-router";
import { DELETE_ICON } from "@/constants/Icons";
import CustomModal from "@/components/CustomModal";
import { formatTimeRange, getTimeWithoutSeconds } from "@/utils/TimeUtils";
import ActionTextButtons from "@/components/ActionTextButtons";
import { useDeleteTripPoint } from "@/composables/useTripPoint";
import { formatAddress } from "@/utils/TextUtils";
import LoadingView from "./LoadingView";
import { TripDetails } from "@/types/Trip";

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

const convertPlace = (place: Place): PlaceViewModel => {
  const subtitle = [place.city, place.state, place.country]
    .filter(Boolean)
    .join(", ");

  return {
    id: place.id,
    providerId: place.providerId || "",
    title: place.name,
    subtitle: subtitle,
  };
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

const TripPointDetailsView = ({
  tripPoint,
  trip,
}: TripPointDetailsViewProps) => {
  const theme = useTheme();
  const styles = createStyles(theme as MD3ThemeExtended);
  const { trip_id, day_id } = useLocalSearchParams();
  const navigation = useNavigation();

  const { deleteTripPoint, loading, error } = useDeleteTripPoint();

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
      pathname: `/trips/details/${trip_id}/day/${day_id}`,
      params: { refresh: "true" },
    });
  };

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
                <Text style={styles.value}>
                  {value?.toString() || "Brak danych"}
                </Text>
              }
            />
          ))}
        {
          <TripPointDetailsLabel
            title="Powiązana atrakcja"
            element={
              tripPoint?.place?.providerId ? (
                <SimplePlaceCard place={convertPlace(tripPoint?.place)} />
              ) : (
                <Text style={styles.value}>Brak danych</Text>
              )
            }
          />
        }
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
  });
