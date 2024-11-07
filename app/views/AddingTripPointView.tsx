import { StyleSheet, View, Dimensions, ScrollView } from "react-native";
import React, { useEffect, useMemo, useState } from "react";
import {
  useTheme,
  MD3Theme,
  TextInput,
  Text,
  SegmentedButtons,
} from "react-native-paper";
import { addHoursToDate, roundToNearestQuarterHour } from "@/utils/TimeUtils";
import CurrencyValueInput from "@/components/CurrencyValueInput";
import ActionButtons from "@/components/ActionButtons";
import TimePicker from "@/components/TimePicker";
import { GestureHandlerRootView } from "react-native-gesture-handler";
import SettingsBottomSheet from "@/components/SettingsBottomSheet";
import { AttractionTypeLabels, TripPointType } from "@/types/Trip";
import { CALENDAR_ICON } from "@/constants/Icons";
import { useAnimatedKeyboard } from "react-native-reanimated";
import TripPointTypePicker from "@/components/TripPointTypePicker";

const { height, width } = Dimensions.get("window");

const AddingTripPointView = () => {
  const theme = useTheme();
  const styles = useMemo(() => createStyles(theme), [theme]);

  useAnimatedKeyboard();

  const [tripPointName, setTripPointName] = useState("");
  const [tripPointAddress, setTripPointAddress] = useState("");

  const [expectedCost, setExpectedCost] = useState<number>(0);
  const [costType, setCostType] = useState<string>("perPerson");
  const selectedCurrency = "EUR";
  const [comment, setComment] = useState<string>("");
  const [tripPointType, setTripPointType] =
    useState<TripPointType>("attraction");
  const [startTime, setStartTime] = useState<Date>(roundToNearestQuarterHour());
  const [endTime, setEndTime] = useState<Date>(addHoursToDate(startTime, 1));

  const [isStartDatePickerVisible, setIsStartDatePickerVisible] =
    useState<boolean>(false);
  const [isEndDatePickerVisible, setIsEndDatePickerVisible] =
    useState<boolean>(false);
  const [isSheetVisible, setIsSheetVisible] = useState<boolean>(false);

  const [dateErrorMessage, setDateErrorMessage] = useState<string | null>(null);
  useEffect(() => {
    if (startTime.getTime() > endTime.getTime())
      setDateErrorMessage("Godzina zakończenia jest przed godziną rozpoczęcia");
    else setDateErrorMessage(null);
  }, [startTime, endTime]);

  return (
    <>
      <GestureHandlerRootView>
        <ScrollView style={styles.scrollView}>
          <View style={styles.container}>
            <TextInput
              mode="outlined"
              style={styles.textInput}
              label="Nazwa"
              value={tripPointName}
              placeholder={tripPointName}
              onChangeText={setTripPointName}
            ></TextInput>

            <TextInput
              mode="outlined"
              style={styles.textInput}
              label="Adres punktu"
              value={tripPointAddress}
              placeholder={tripPointAddress}
              onChangeText={setTripPointAddress}
            ></TextInput>

            <CurrencyValueInput
              label={"Przewidywany koszt"}
              disable={true}
              onValueChange={setExpectedCost}
              selectedCurrency={selectedCurrency}
            />

            <SegmentedButtons
              value={costType}
              onValueChange={setCostType}
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

            <TextInput
              mode="outlined"
              style={styles.textInput}
              label="Komentarz"
              value={comment}
              placeholder={comment}
              onChangeText={setComment}
            ></TextInput>

            <TripPointTypePicker
              onPress={() => setIsSheetVisible(true)}
              selectedTripPointType={tripPointType}
            />

            <TextInput
              mode="outlined"
              style={styles.textInput}
              label="Data"
              left={<TextInput.Icon icon={CALENDAR_ICON} />}
              value={startTime.toLocaleDateString()}
              placeholder={comment}
              editable={false}
              disabled={true}
            ></TextInput>

            <TimePicker
              date={startTime}
              showPicker={isStartDatePickerVisible}
              setShowPicker={setIsStartDatePickerVisible}
              onDateChange={setStartTime}
              label="Godzina rozpoczęcia"
            ></TimePicker>

            <TimePicker
              date={endTime}
              showPicker={isEndDatePickerVisible}
              setShowPicker={setIsEndDatePickerVisible}
              onDateChange={setEndTime}
              label="Godzina zakończenia"
            ></TimePicker>

            <Text style={styles.errorMessage}>{dateErrorMessage}</Text>
          </View>

          <ActionButtons
            onCancel={() => console.log("Anulowanie")}
            cancelButtonLabel="Anuluj"
            cancelIcon={undefined}
            onConfirm={() => {
              if (dateErrorMessage)
                console.log("Nie można zapisać z powodu błędu w godzinach");
              else console.log("Zapisywanie");
            }}
            confirmButtonLabel="Zapisz"
            confirmIcon={undefined}
          />
        </ScrollView>

        <SettingsBottomSheet
          title={"Wybierz rodzaj punktu wycieczki"}
          items={AttractionTypeLabels}
          selectedItem={tripPointType}
          isVisible={isSheetVisible}
          onSelect={(item: string) => {
            setTripPointType(item as TripPointType);
          }}
          onClose={() => setIsSheetVisible(false)}
        />
      </GestureHandlerRootView>
    </>
  );
};

export default AddingTripPointView;

const createStyles = (theme: MD3Theme) =>
  StyleSheet.create({
    scrollView: {
      flex: 1,
      backgroundColor: theme.colors.surface,
      width: width,
    },
    container: {
      flex: 1,
      alignItems: "center",
      paddingBottom: 20,
      backgroundColor: theme.colors.surface,
    },
    image: {
      marginVertical: 25,
      width: "100%",
      height: height * 0.2,
    },
    textInput: {
      width: "90%",
      height: 50,
      marginVertical: 10,
      backgroundColor: theme.colors.surface,
    },
    modal: {
      backgroundColor: theme.colors.surface,
      marginHorizontal: "10%",
      padding: 20,
      borderRadius: 10,
      alignSelf: "center",
    },
    modalContent: {
      fontSize: 16,
      textAlign: "center",
    },
    modalText: {
      fontSize: 16,
      textAlign: "center",
      marginBottom: 20,
    },
    segmentedButtons: {
      width: 0.9 * width,
      marginVertical: 15,
    },
    errorMessage: {
      color: theme.colors.error,
      width: 0.85 * width,
      textAlign: "left",
      ...theme.fonts.bodySmall,
    },
  });
