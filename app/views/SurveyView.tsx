/* eslint-disable @typescript-eslint/no-explicit-any */
import { StyleSheet, Text, ScrollView, View } from "react-native";
import React, { useEffect, useState } from "react";
import { MD3ThemeExtended } from "@/constants/Themes";
import { SegmentedButtons, TextInput, useTheme } from "react-native-paper";
import StarRatingDisplayComponent from "@/components/StarRatingDisplayComponent";
import { useLocalSearchParams, useRouter } from "expo-router";
import ActionButtons from "@/components/ActionButtons";
import { GestureHandlerRootView } from "react-native-gesture-handler";
import CurrencyValueInput from "@/components/CurrencyValueInput";
import { useTripDetails } from "@/composables/useTripDetails";
import LoadingView from "./LoadingView";
import { ReviewRequest } from "@/types/Review";
import { useAuth } from "@/app/ctx";
import { API_SUBMIT_REVIEW } from "@/constants/Endpoints";
import { formatTimeSpan } from "@/utils/TimeUtils";
import { useSnackbar } from "@/context/SnackbarContext";

const SurveyView = () => {
  const theme = useTheme();
  const styles = createStyles(theme as MD3ThemeExtended);
  const router = useRouter();

  const { trip_id, trip_point_id } = useLocalSearchParams();

  const {
    tripDetails,
    loading: tripLoading,
    error: tripError,
  } = useTripDetails(trip_id as string);

  const { api } = useAuth();
  const { showSnackbar } = useSnackbar();

  const [error, setError] = useState<string>("");
  const [loading, setLoading] = useState<boolean>(false);

  const [hours, setHours] = useState<number | undefined>(undefined);
  const [minutes, setMinutes] = useState<number | undefined>(undefined);
  const [hoursText, setHoursText] = useState<string>("");
  const [minutesText, setMinutesText] = useState<string>("");
  const [costType, setCostType] = useState<string>("perPerson");
  const [currency, setCurrency] = useState<string>("");
  const [cost, setCost] = useState<number>(0);
  const [rating, setRating] = useState<number>(3);

  useEffect(() => {
    if (tripDetails) setCurrency(tripDetails?.currencyCode);
  }, [tripDetails]);

  useEffect(() => setLoading(tripLoading || false), [tripLoading]);

  useEffect(() => {
    if (error) showSnackbar(error);
  }, [error]);

  const handleChange = (setter: React.Dispatch<React.SetStateAction<any>>) => {
    return (value: any) => {
      setter(value);
    };
  };

  const handleTimeChange = (
    timeText: string,
    setTimePart: React.Dispatch<React.SetStateAction<number | undefined>>,
  ) => {
    const numericValue = Number(timeText);
    if (!isNaN(numericValue) && numericValue >= 0) setTimePart(numericValue);
    else setError("Wartość spędzonego czasu jest nieprawidłowa.");
  };

  const handleHoursChange = () => {
    handleTimeChange(hoursText || "", setHours);
  };

  const handleMinutesChange = () => {
    handleTimeChange(minutesText || "", setMinutes);
  };

  const onCancel = () => router.back();

  const onSave = async () => {
    if ((minutes && minutes < 0) || (hours && hours < 0)) {
      setError("Wartość spędzonego czasu jest nieprawidłowa.");
      return;
    }

    let totalCost = cost;
    if (costType === "total") {
      const numberOfTravelers = tripDetails
        ? tripDetails?.numberOfTravelers
        : 1;
      totalCost = cost / numberOfTravelers;
    }

    const timespan = formatTimeSpan(hours, minutes);

    const reviewRequest: ReviewRequest = {
      actualCostPerPerson: totalCost,
      actualTimeSpent: timespan,
      rating: rating,
    };
    setLoading(true);
    try {
      await api!.post(
        `${API_SUBMIT_REVIEW}/${trip_point_id as string}`,
        reviewRequest,
      );
      router.back();
      router.setParams({ refresh: "true" });
      showSnackbar("Pomyślnie dodano recenzję!", "success");
    } catch (err: any) {
      console.error(err.response.data);
      showSnackbar("Wystąpił błąd", "error");
    } finally {
      setLoading(false);
    }
  };

  if (loading) {
    return <LoadingView transparent={false} />;
  }

  if (tripError) {
    router.back();
    showSnackbar(tripError?.toString() || "Unknown error", "error");
    return null;
  }

  return (
    <GestureHandlerRootView style={styles.wrapper}>
      <ScrollView
        style={styles.scrollView}
        contentContainerStyle={styles.content}
      >
        <View style={styles.container}>
          <Text style={styles.timeLabel}>Czas spędzony</Text>
          <View style={styles.inputContainer}>
            <View style={styles.inputWithLabel}>
              <TextInput
                value={hoursText}
                mode="outlined"
                style={styles.timeInput}
                onChangeText={handleChange(setHoursText)}
                onEndEditing={handleHoursChange}
                keyboardType="numeric"
              />
              <Text style={styles.label}>h</Text>
            </View>
            <View style={styles.inputWithLabel}>
              <TextInput
                value={minutesText}
                mode="outlined"
                style={styles.timeInput}
                onChangeText={handleChange(setMinutesText)}
                onEndEditing={handleMinutesChange}
                keyboardType="numeric"
              />
              <Text style={styles.label}>min</Text>
            </View>
          </View>

          <CurrencyValueInput
            label={"Koszt"}
            budget={cost}
            currency={currency ? (currency as string) : ""}
            currencyDisable={true}
            handleBudgetChange={handleChange(setCost)}
          />

          <SegmentedButtons
            value={costType}
            onValueChange={handleChange(setCostType)}
            style={styles.segmentedButtons}
            buttons={[
              {
                value: "perPerson",
                label: "Na osobę",
              },
              {
                value: "total",
                label: "Łącznie",
              },
            ]}
          />
          <StarRatingDisplayComponent
            style={styles.starRatingPadding}
            rating={rating}
            editable={true}
            onRatingChange={(rating) => setRating(rating)}
          />
        </View>
      </ScrollView>
      <View style={styles.actionButtonsContainer}>
        <ActionButtons
          onAction1={onCancel}
          action1ButtonLabel="Anuluj"
          action1Icon={undefined}
          onAction2={onSave}
          action2ButtonLabel="Zapisz"
          action2Icon={undefined}
        />
      </View>
    </GestureHandlerRootView>
  );
};

export default SurveyView;

const createStyles = (theme: MD3ThemeExtended) =>
  StyleSheet.create({
    wrapper: {
      flex: 1,
      backgroundColor: theme.colors.background,
    },
    scrollView: {
      flex: 1,
      width: "100%",
      paddingTop: 20,
    },
    content: {
      paddingHorizontal: 16,
      paddingBottom: 100,
    },
    container: {
      alignItems: "center",
    },
    timeLabel: {
      ...theme.fonts.bodySmall,
      color: theme.colors.onBackground,
      alignSelf: "flex-start",
      marginLeft: 20,
      marginBottom: 8,
    },
    inputContainer: {
      flexDirection: "row",
      justifyContent: "center",
      alignItems: "center",
      marginVertical: 5,
      height: 50,
      width: "90%",
    },
    inputWithLabel: {
      flexDirection: "row",
      alignItems: "center",

      flex: 1,
    },
    timeInput: {
      flex: 1,
    },
    inputWithCurrency: {
      flexDirection: "row",
      alignItems: "center",
      justifyContent: "center",
      width: "90%",
      marginVertical: 20,
    },
    costInput: {
      flex: 1,
      backgroundColor: theme.colors.surface,
    },
    currencyLabel: {
      ...theme.fonts.bodySmall,
      color: theme.colors.onBackground,
      height: 50,
      lineHeight: 60,
      textAlign: "center",
      marginLeft: 8,
    },
    segmentedButtons: {
      width: "90%",
      marginVertical: 10,
    },
    starRatingPadding: {
      paddingVertical: 20,
    },
    actionButtonsContainer: {
      position: "absolute",
      bottom: 0,
      width: "100%",
      padding: 16,
      backgroundColor: theme.colors.background,
    },
    label: {
      ...theme.fonts.bodySmall,
      color: theme.colors.onBackground,
      marginHorizontal: 8,
    },
  });
