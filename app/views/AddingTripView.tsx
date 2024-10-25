import { StyleSheet, View, Image, Dimensions, Button } from "react-native";
import React, { useMemo, useState } from "react";
import { useTheme, MD3Theme, TextInput } from "react-native-paper";
import { DatePickerModal } from "react-native-paper-dates";

const { height, width } = Dimensions.get("window");

const AddingTripView = () => {
  type DateRange = {
    startDate: Date;
    endDate: Date;
  };

  const theme = useTheme();
  const styles = useMemo(() => createStyles(theme), [theme]);

  const [tripName, setTripName] = useState("");
  const [destination, setDestination] = useState("");

  const today = new Date();
  const oneWeekLater = new Date();
  oneWeekLater.setDate(today.getDate() + 7);

  const [range, setRange] = useState<DateRange>({
    startDate: today,
    endDate: oneWeekLater,
  });
  const [visible, setVisible] = useState(false);

  const openDatePicker = () => setVisible(true);
  const closeDatePicker = () => setVisible(false);

  const onConfirm = ({
    startDate,
    endDate,
  }: {
    startDate: Date;
    endDate: Date;
  }) => {
    setRange({ startDate, endDate });
    closeDatePicker();
  };

  return (
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
        placeholder="Moja nowa wycieczka"
        onChangeText={(tripName) => setTripName(tripName)}
      ></TextInput>

      <Button title="Wybierz zakres dat" onPress={openDatePicker} />
      {/* <DatePickerModal
        mode="range"
        visible={visible}
        onDismiss={closeDatePicker}
        startDate={range.startDate}
        endDate={range.endDate}
        onConfirm=RangeChange
        locale="pl" // ustawienie lokalizacji na język polski
      /> */}

      <TextInput
        mode="outlined"
        style={styles.textInput}
        label="Cel wycieczki"
        value={destination}
        placeholder="Wrocław, Polska"
        onChangeText={(destination) => setDestination(destination)}
      ></TextInput>
    </View>
  );
};

export default AddingTripView;

const createStyles = (theme: MD3Theme) =>
  StyleSheet.create({
    container: {
      alignItems: "center",
    },
    fab: {
      position: "absolute",
      backgroundColor: theme.colors.primary,
      margin: 16,
      top: 0.25 * height,
      right: 0.05 * width,
      borderRadius: 10000,
    },
    image: {
      marginVertical: 25,
      width: "100%",
      height: height * 0.2,
    },
    textInput: {
      width: 0.9 * width,
      height: 50,
      marginVertical: 10,
    },
  });
