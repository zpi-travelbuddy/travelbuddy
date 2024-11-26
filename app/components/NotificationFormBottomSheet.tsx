import React, { useRef, useEffect, useState } from "react";
import {
  View,
  Text,
  StyleSheet,
  TouchableWithoutFeedback,
  Keyboard,
} from "react-native";
import { MD3Theme, TextInput, useTheme } from "react-native-paper";
import BottomSheet, { BottomSheetView } from "@gorhom/bottom-sheet";
import Animated, {
  useAnimatedKeyboard,
  useAnimatedStyle,
} from "react-native-reanimated";
import ActionButtons from "./ActionButtons";

const MAX_NOTIFICATION_TIME = 1440;

interface NotificationFormBottomSheetProps {
  isVisible: boolean;
  onSave: (time: number) => void;
  onCancel: () => void;
  onClose: () => void;
  label?: string;
}

const NotificationFormBottomSheet: React.FC<
  NotificationFormBottomSheetProps
> = ({ isVisible, onClose, onSave, onCancel }) => {
  const theme = useTheme();
  const styles = createStyles(theme);
  const sheetRef = useRef<BottomSheet>(null);

  const keyboard = useAnimatedKeyboard();

  const [time, setTime] = useState<number | null>(null);
  const [errorText, setErrorText] = useState<string | null>(null);

  const handleClose = () => {
    setTime(null);
    onClose();
  };

  const handleCancel = () => {
    setTime(null);
    Keyboard.dismiss();
    onCancel();
  };

  const handleSave = () => {
    Keyboard.dismiss();
    if (validateTime(time)) {
      onSave(time!);
      setTime(null);
      setErrorText(null);
    }
  };

  const animatedStyles = useAnimatedStyle(() => {
    return {
      marginBottom: keyboard.height.value,
    };
  });

  useEffect(() => {
    if (isVisible) {
      sheetRef.current?.snapToIndex(0);
    } else {
      sheetRef.current?.close();
    }
  }, [isVisible]);

  const validateTime = (time: number | null) => {
    if (time === null || time <= 0) {
      setErrorText("Czas musi być większy od 0");
      return false;
    }
    if (time > MAX_NOTIFICATION_TIME) {
      setErrorText("Maksymalny czas to 24h");
      return false;
    }
    return true;
  };

  const handleTextChange = (text: string) => {
    const numericText = text.replace(/[^0-9]/g, "");
    const parsedDuration = Number(numericText);
    if (parsedDuration > MAX_NOTIFICATION_TIME) {
      setErrorText("Maksymalny czas to 24h");
      setTime(MAX_NOTIFICATION_TIME);
      return;
    }
    if (parsedDuration <= 0) {
      setErrorText("Czas musi być większy od 0");
      setTime(null);
      return;
    }
    setErrorText(null);
    setTime(Number(numericText));
  };

  return (
    <>
      <BottomSheet
        ref={sheetRef}
        index={isVisible ? 0 : -1}
        enablePanDownToClose
        onClose={handleClose}
        containerStyle={styles.containerStyle}
        backgroundComponent={({ style }) => (
          <View style={[style, styles.contentContainer]} />
        )}
        keyboardBlurBehavior="restore"
      >
        <TouchableWithoutFeedback onPress={Keyboard.dismiss}>
          <View>
            <BottomSheetView style={styles.contentContainer}>
              <Text style={styles.label}>
                Ustaw czas powiadomienia przed wydarzeniem
              </Text>
              <Animated.View style={animatedStyles}>
                <TextInput
                  value={time?.toString() || ""}
                  onChangeText={handleTextChange}
                  mode="outlined"
                  style={styles.textInput}
                  label="Minuty"
                ></TextInput>
                <Text style={[{ color: theme.colors.error }, styles.textError]}>
                  {errorText ? errorText : " "}
                </Text>
                <ActionButtons
                  onAction1={handleCancel}
                  action1ButtonLabel="Anuluj"
                  onAction2={handleSave}
                  action2ButtonLabel="Zapisz"
                  action1Icon={undefined}
                  action2Icon={undefined}
                />
              </Animated.View>
            </BottomSheetView>
          </View>
        </TouchableWithoutFeedback>
      </BottomSheet>

      {isVisible && (
        <TouchableWithoutFeedback
          onPress={() => {
            if (Keyboard.isVisible()) {
              Keyboard.dismiss();
            } else {
              handleClose();
            }
          }}
        >
          <View style={styles.scrim} />
        </TouchableWithoutFeedback>
      )}
    </>
  );
};

export default NotificationFormBottomSheet;

const createStyles = (theme: MD3Theme) =>
  StyleSheet.create({
    contentContainer: {
      paddingVertical: 10,
      borderTopLeftRadius: 40,
      borderTopRightRadius: 40,
      backgroundColor: theme.colors.elevation.level1,
    },
    scrim: {
      ...StyleSheet.absoluteFillObject,
      backgroundColor: "rgba(0, 0, 0, 0.5)",
      zIndex: 1,
    },
    label: {
      ...theme.fonts.titleMedium,
      textAlign: "center",
      color: theme.colors.onBackground,
    },
    containerStyle: { zIndex: 3 },
    textInput: {
      height: 50,
      marginTop: 10,
      backgroundColor: theme.colors.surface,
      marginHorizontal: 50,
    },
    textError: {
      marginHorizontal: 50,
    },
  });
