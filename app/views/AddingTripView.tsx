import { StyleSheet, View, Image, Dimensions, ScrollView } from "react-native";
import React, { useMemo, useState } from "react";
import { useTheme, MD3Theme, TextInput } from "react-native-paper";
import { DatePickerModal } from "react-native-paper-dates";
import { registerTranslation } from "react-native-paper-dates";
import { formatDate } from "@/utils/DateUtils";
import CurrencyValueInput from "@/components/CurrencyValueInput";

const { height, width } = Dimensions.get("window");

registerTranslation("pl", {
  save: "Save",
  selectSingle: "Select date",
  selectMultiple: "Select dates",
  selectRange: "Select period",
  notAccordingToDateFormat: (inputFormat) =>
    `Date format must be ${inputFormat}`,
  mustBeHigherThan: (date) => `Must be later then ${date}`,
  mustBeLowerThan: (date) => `Must be earlier then ${date}`,
  mustBeBetween: (startDate, endDate) =>
    `Must be between ${startDate} - ${endDate}`,
  dateIsDisabled: "Day is not allowed",
  previous: "Previous",
  next: "Next",
  typeInDate: "Type in date",
  pickDateFromCalendar: "Pick date from calendar",
  close: "Close",
  hour: "",
  minute: "",
});

const AddingTripView = () => {
  type DateRange = {
    startDate: Date | undefined;
    endDate: Date | undefined;
  };

  const theme = useTheme();
  const styles = useMemo(() => createStyles(theme), [theme]);

  const [tripName, setTripName] = useState("");
  const [destination, setDestination] = useState("");

  const [range, setRange] = React.useState<DateRange>({
    startDate: undefined,
    endDate: undefined,
  });
  const [isOpen, setOpen] = React.useState<boolean>(false);
  const [dateRangeText, setDateRangeText] = React.useState<string>("");

  const [numberOfPeople, setNumberOfPeople] = React.useState<string>("");

  const onDismiss = React.useCallback(() => {
    setOpen(false);
  }, []);

  const onConfirm = React.useCallback(
    ({
      startDate,
      endDate,
    }: {
      startDate: Date | undefined;
      endDate: Date | undefined;
    }) => {
      setOpen(false);
      setRange({ startDate, endDate });
      if (startDate?.toISOString() !== endDate?.toISOString())
        setDateRangeText(formatDate(startDate) + " - " + formatDate(endDate));
      else setDateRangeText(formatDate(startDate) + "");
    },
    [],
  );

  const handleTextChange = (text: string) => {
    const numericText = text.replace(/[^0-9]/g, "");
    setNumberOfPeople(numericText);
  };

  return (
    <ScrollView style={styles.scrollView}>
      <View style={styles.container}>
        <Image
          source={{
            uri: "https://upload.wikimedia.org/wikipedia/commons/1/1a/Big_Ben..JPG",
          }}
          style={styles.image}
          resizeMode="cover"
        />
        <TextInput
          mode="outlined"
          style={styles.textInput}
          label="Nazwa"
          value={tripName}
          placeholder={tripName}
          onChangeText={(tripName) => setTripName(tripName)}
        ></TextInput>

        <TextInput
          mode="outlined"
          style={styles.textInput}
          label="Termin wycieczki"
          value={dateRangeText}
          left={<TextInput.Icon icon="calendar" />}
          onPress={() => setOpen(true)}
        ></TextInput>

        <DatePickerModal
          mode="range"
          visible={isOpen}
          onDismiss={onDismiss}
          startDate={range.startDate ?? undefined}
          endDate={range.endDate ?? undefined}
          onConfirm={onConfirm}
          locale="pl"
          validRange={{
            startDate: new Date(),
          }}
        />

        <TextInput
          mode="outlined"
          style={styles.textInput}
          label="Cel wycieczki"
          value={destination}
          placeholder={destination}
          onChangeText={(destination) => setDestination(destination)}
        ></TextInput>

        <TextInput
          mode="outlined"
          style={styles.textInput}
          label="Liczba osób"
          value={numberOfPeople}
          onChangeText={handleTextChange}
          keyboardType="numeric"
        ></TextInput>

        <CurrencyValueInput />
      </View>
    </ScrollView>
  );
};

export default AddingTripView;

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
    },
  });
