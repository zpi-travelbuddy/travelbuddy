import React, { useRef, useEffect, useCallback } from "react";
import {
  View,
  Text,
  StyleSheet,
  TouchableOpacity,
  TouchableWithoutFeedback,
} from "react-native";
import { MD3Theme, useTheme } from "react-native-paper";
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
  onClose: () => void;
}

const CREATING_TRIP_POINT_SNAP_POINTS = [170];

const CreatingTripPointSelector: React.FC<BottomSheetComponentProps> = ({
  options,
  isVisible,
  onClose,
}) => {
  const theme = useTheme();
  const styles = createStyles(theme);
  const sheetRef = useRef<BottomSheet>(null);

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

  return (
    <>
      <BottomSheet
        ref={sheetRef}
        index={isVisible ? 0 : -1}
        snapPoints={CREATING_TRIP_POINT_SNAP_POINTS}
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
                onClose();
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

export default CreatingTripPointSelector;

const createStyles = (theme: MD3Theme) =>
  StyleSheet.create({
    contentContainer: {
      flexDirection: "row",
      justifyContent: "space-around",
      paddingTop: 10,
      borderTopLeftRadius: 40,
      borderTopRightRadius: 40,
      backgroundColor: theme.colors.elevation.level1,
    },
    option: {
      alignItems: "center",
    },
    optionLabel: {
      ...theme.fonts.bodySmall,
      paddingVertical: 10,
      marginHorizontal: -50,
      color: theme.colors.onBackground,
    },
    scrim: {
      ...StyleSheet.absoluteFillObject,
      backgroundColor: "rgba(0, 0, 0, 0.5)",
      zIndex: 1,
    },
  });
