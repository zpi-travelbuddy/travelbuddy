import React, { useRef, useEffect, useCallback, useState } from "react";
import {
  View,
  Text,
  StyleSheet,
  TouchableOpacity,
  TouchableWithoutFeedback,
} from "react-native";
import { MD3Theme, TextInput, useTheme } from "react-native-paper";
import BottomSheet, { BottomSheetView } from "@gorhom/bottom-sheet";
import { useAnimatedKeyboard } from "react-native-reanimated";
import IconComponent from "./IconComponent";

export interface Option {
  icon: string;
  label: string;
  onPress: () => void;
}

interface BottomSheetComponentProps {
  options: Option[];
  isVisible: boolean;
  isExtendedView: boolean;
  tripTime?: number;
  onChange: (newValue: number) => void;
  onClose: () => void;
}

const CREATING_TRANSFER_SNAP_POINTS_1 = [270];
const CREATING_TRANSFER_SNAP_POINTS_2 = [470];

const CreatingTransferSelector: React.FC<BottomSheetComponentProps> = ({
  options,
  isVisible,
  isExtendedView,
  tripTime,
  onChange,
  onClose,
}) => {
  const theme = useTheme();
  const styles = createStyles(theme);
  const sheetRef = useRef<BottomSheet>(null);

  const [snapPoints, setSnapPoints] = useState(CREATING_TRANSFER_SNAP_POINTS_1);

  useAnimatedKeyboard();

  const handleAnimate = useCallback(
    (fromIndex: number, toIndex: number) => {
      if (toIndex === -1) onClose();
    },
    [onClose],
  );

  useEffect(() => {
    if (isVisible) {
      sheetRef.current?.snapToIndex(0);
    } else {
      sheetRef.current?.close();
    }
  }, [isVisible]);

  useEffect(() => {
    if (isExtendedView && isVisible) {
      setSnapPoints(CREATING_TRANSFER_SNAP_POINTS_2);
      sheetRef.current?.snapToIndex(0);
    } else if (isVisible) {
      setSnapPoints(CREATING_TRANSFER_SNAP_POINTS_1);
      sheetRef.current?.snapToIndex(0);
    }
  }, [isVisible, isExtendedView]);

  return (
    <>
      <BottomSheet
        ref={sheetRef}
        index={isVisible ? 0 : -1}
        snapPoints={snapPoints}
        enablePanDownToClose
        onClose={onClose}
        onAnimate={handleAnimate}
        containerStyle={{ zIndex: 3 }}
        backgroundComponent={({ style }) => (
          <View style={[style, styles.contentContainer]} />
        )}
      >
        <BottomSheetView style={styles.contentContainer}>
          {options.map((option, index) => (
            <TouchableOpacity
              key={index}
              style={styles.option}
              onPress={() => {
                option.onPress();
              }}
            >
              <IconComponent
                source={option.icon}
                iconSize={36}
                color={theme.colors.onSecondaryContainer}
                backgroundColor={theme.colors.secondaryContainer}
              />
              <Text style={styles.optionLabel}>{option.label}</Text>
            </TouchableOpacity>
          ))}
          {isExtendedView && (
            <View>
              <Text>Wpisz szacowany czas podróży</Text>
              <TextInput
                label="Email"
                value={tripTime}
                onChangeText={(text) => onChange(number(text))}
              ></TextInput>
            </View>
          )}
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

export default CreatingTransferSelector;

const createStyles = (theme: MD3Theme) =>
  StyleSheet.create({
    contentContainer: {
      flexDirection: "row",
      flexWrap: "wrap", // allows wrapping to next row
      justifyContent: "space-around",
      paddingTop: 10,
      borderTopLeftRadius: 40,
      borderTopRightRadius: 40,
      backgroundColor: theme.colors.elevation.level1,
    },
    option: {
      alignItems: "center",
      width: "33%", // to fit three items in each row
      marginVertical: 10,
    },
    optionLabel: {
      ...theme.fonts.bodySmall,
      paddingVertical: 10,
      textAlign: "center",
      color: theme.colors.onBackground,
    },
    scrim: {
      ...StyleSheet.absoluteFillObject,
      backgroundColor: "rgba(0, 0, 0, 0.5)",
      zIndex: 1,
    },
  });
