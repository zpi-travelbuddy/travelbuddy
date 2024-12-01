import { StyleSheet, Text, ScrollView, View } from "react-native";
import React from "react";
import { MD3ThemeExtended } from "@/constants/Themes";
import { SegmentedButtons, TextInput, useTheme } from "react-native-paper";
import StarRatingDisplayComponent from "@/components/StarRatingDisplayComponent";
import { useRouter } from "expo-router";
import ActionButtons from "@/components/ActionButtons";
import { GestureHandlerRootView } from "react-native-gesture-handler";

const SurveyView = () => {
  const theme = useTheme();
  const styles = createStyles(theme as MD3ThemeExtended);
  const router = useRouter();

  const onCancel = () => {
    router.back();
  };

  const onSave = () => {
    router.back();
  };

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
                mode="outlined"
                style={styles.timeInput}
                keyboardType="numeric"
              />
              <Text style={styles.label}>h</Text>
            </View>
            <View style={styles.inputWithLabel}>
              <TextInput
                mode="outlined"
                style={styles.timeInput}
                keyboardType="numeric"
              />
              <Text style={styles.label}>min</Text>
            </View>
          </View>

          <View style={styles.inputWithCurrency}>
            <TextInput
              label="Koszt"
              mode="outlined"
              style={styles.costInput}
              keyboardType="numeric"
            />
            <Text style={styles.currencyLabel}>PLN</Text>
          </View>

          <SegmentedButtons
            value={""}
            onValueChange={(value: string) => console.log(value.toString())}
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
            rating={4.5}
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
