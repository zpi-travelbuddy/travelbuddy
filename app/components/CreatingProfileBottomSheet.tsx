import React, { useRef, useEffect, useCallback, useState } from "react";
import { View, Text, StyleSheet, TouchableWithoutFeedback } from "react-native";
import { MD3Theme, TextInput, useTheme } from "react-native-paper";
import BottomSheet, { BottomSheetView } from "@gorhom/bottom-sheet";
import { useAnimatedKeyboard } from "react-native-reanimated";
import ActionButtons from "./ActionButtons";

interface BottomSheetComponentProps {
  isVisible: boolean;
  onClose: () => void;
  onSave: () => void;
  label?: string;
}

const CreatingProfileBottonSheet: React.FC<BottomSheetComponentProps> = ({
  isVisible,
  onClose,
  onSave,
  label,
}) => {
  const theme = useTheme();
  const styles = createStyles(theme);
  const sheetRef = useRef<BottomSheet>(null);

  const [profileName, setProfileName] = useState<string>("");
  const [error, setError] = useState<string>("");

  useAnimatedKeyboard();

  const handleAnimate = useCallback(
    (fromIndex: number, toIndex: number) => {
      if (toIndex === -1) onClose();
    },
    [onClose],
  );

  const handleSave = () => {
    if (profileName) {
      onClose();
      setError("");
      setProfileName("");
      onSave();
    } else setError("Uzupełnij nazwę profilu!");
  };

  useEffect(() => {
    if (isVisible) {
      sheetRef.current?.snapToIndex(0);
    } else {
      sheetRef.current?.close();
    }
  }, [isVisible]);

  return (
    <>
      <BottomSheet
        ref={sheetRef}
        index={isVisible ? 0 : -1}
        enablePanDownToClose
        onClose={onClose}
        onAnimate={handleAnimate}
        containerStyle={styles.containerStyle}
        backgroundComponent={({ style }) => (
          <View style={[style, styles.contentContainer]} />
        )}
      >
        <BottomSheetView>
          {!!label && <Text style={styles.label}>{label}</Text>}
          <View style={styles.contentContainer}>
            <TextInput
              style={styles.input}
              label="Nazwa profilu"
              value={profileName}
              onChangeText={setProfileName}
              error={!!error}
            />
            {!!error && <Text style={styles.textError}>{error}</Text>}
            <ActionButtons
              onAction1={onClose}
              action1ButtonLabel={"Anuluj"}
              onAction2={handleSave}
              action2ButtonLabel={"Zapisz"}
              action1Icon={undefined}
              action2Icon={undefined}
            />
          </View>
        </BottomSheetView>
      </BottomSheet>

      {isVisible && (
        <TouchableWithoutFeedback onPress={onClose}>
          <View style={styles.scrim} />
        </TouchableWithoutFeedback>
      )}
    </>
  );
};

export default CreatingProfileBottonSheet;

const createStyles = (theme: MD3Theme) =>
  StyleSheet.create({
    contentContainer: {
      borderTopLeftRadius: 40,
      borderTopRightRadius: 40,
      backgroundColor: theme.colors.elevation.level1,
      justifyContent: "center",
      alignItems: "center",
    },
    input: {
      width: "80%",
      height: 50,
      marginTop: 10,
      backgroundColor: theme.colors.surface,
    },
    scrim: {
      ...StyleSheet.absoluteFillObject,
      backgroundColor: "rgba(0, 0, 0, 0.5)",
      zIndex: 1,
    },
    label: {
      ...theme.fonts.labelMedium,
      width: "80%",
      textAlign: "left",
      alignSelf: "center",
      color: theme.colors.onBackground,
      marginTop: 10,
    },
    containerStyle: { zIndex: 3 },
    textError: {
      marginTop: 10,
      color: theme.colors.error,
      width: "80%",
      textAlign: "left",
      ...theme.fonts.bodySmall,
    },
  });
