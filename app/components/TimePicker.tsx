import React, { useState } from "react";
import { View, StyleSheet, Dimensions } from "react-native";
import DateTimePicker, {
  DateTimePickerEvent,
} from "@react-native-community/datetimepicker";
import ClickableInput from "./ClickableInput";
import { formatTime } from "@/utils/TimeUtils";
import { CLOCK_ICON } from "@/constants/Icons";

interface TimePickerProps {
  date: Date;
  showPicker: boolean;
  setShowPicker: (val: boolean) => void;
  onDateChange: (date: Date) => void;
  label?: string;
  error?: boolean;
}

const { width } = Dimensions.get("window");

const TimePicker: React.FC<TimePickerProps> = ({
  date,
  showPicker,
  setShowPicker,
  onDateChange,
  label,
  error,
}) => {
  const [timeString, setTimeString] = useState<string>(formatTime(date));

  const onChange = (event: DateTimePickerEvent, selectedTime?: Date) => {
    const currentTime = selectedTime || date;
    setShowPicker(false);
    onDateChange(currentTime);
    setTimeString(formatTime(currentTime));
  };

  return (
    <View style={styles.container}>
      <ClickableInput
        icon={CLOCK_ICON}
        value={timeString}
        label={label || "Godzina"}
        onPress={() => setShowPicker(true)}
        touchableStyle={styles.touchable}
        inputStyle={styles.input}
        error={error || false}
      />
      {showPicker && (
        <DateTimePicker
          value={date}
          mode="time"
          is24Hour={true}
          display="spinner"
          onChange={onChange}
        />
      )}
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    paddingHorizontal: 5,
    paddingVertical: 10,
  },
  timeText: {
    fontSize: 18,
    marginVertical: 10,
  },
  touchable: {
    width: width,
    alignItems: "center",
  },
  input: {
    width: "90%",
  },
});

export default TimePicker;
