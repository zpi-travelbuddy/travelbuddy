import React, { useRef, useEffect, useCallback, useState } from "react";
import {
  View,
  Text,
  StyleSheet,
  TouchableOpacity,
  TouchableWithoutFeedback,
} from "react-native";
import { MD3Theme, useTheme } from "react-native-paper";
import { Option } from "@/types/data";
import BottomSheet, { BottomSheetView } from "@gorhom/bottom-sheet";
import { useAnimatedKeyboard } from "react-native-reanimated";
import IconComponent from "./IconComponent";

interface BottomSheetComponentProps {
  options: Option[];
  isVisible: boolean;
  snapIndex: number;
  extendedView?: React.ReactNode;
  onClose: () => void;
  label?: string;
}

const CreatingTripPointSelector: React.FC<BottomSheetComponentProps> = ({
  options,
  isVisible,
  snapIndex,
  extendedView,
  onClose,
  label,
}) => {
  const theme = useTheme();
  const styles = createStyles(theme);
  const sheetRef = useRef<BottomSheet>(null);

  const DEFAULT_TRANSFER_SNAP_POINTS = [
    100 * (Math.floor(options.length / 3) + 1) + (label ? 40 : 0),
    100 * (Math.floor(options.length / 3) + 1) + (label ? 40 : 0),
  ];
  const EXTENDED_TRANSFER_SNAP_POINTS = [
    100 * (Math.floor(options.length / 3) + 1) + (label ? 40 : 0),
    150 * (Math.floor(options.length / 3) + 1) + (label ? 40 : 0),
  ];

  const [snapPoints, setSnapPoints] = useState<number[]>(
    DEFAULT_TRANSFER_SNAP_POINTS,
  );

  useEffect(() => {
    if (extendedView) setSnapPoints(EXTENDED_TRANSFER_SNAP_POINTS);
    else setSnapPoints(DEFAULT_TRANSFER_SNAP_POINTS);
  }, [extendedView]);

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
        index={isVisible ? snapIndex : -1}
        snapPoints={snapPoints}
        enablePanDownToClose
        onClose={onClose}
        onAnimate={handleAnimate}
        containerStyle={styles.containerStyle}
        backgroundComponent={({ style }) => (
          <View style={[style, styles.contentContainer]} />
        )}
      >
        {!!label && <Text style={styles.label}>{label}</Text>}
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
                color={
                  option.label === label
                    ? theme.colors.onPrimary
                    : theme.colors.onSecondaryContainer
                }
                backgroundColor={
                  option.label === label
                    ? theme.colors.primary
                    : theme.colors.secondaryContainer
                }
              />
              <Text style={styles.optionLabel}>{option.label}</Text>
            </TouchableOpacity>
          ))}
        </BottomSheetView>
        {extendedView && extendedView}
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
      flexWrap: "wrap",
      justifyContent: "flex-start",
      paddingTop: 10,
      paddingHorizontal: 15,
      borderTopLeftRadius: 40,
      borderTopRightRadius: 40,
      backgroundColor: theme.colors.elevation.level1,
    },
    option: {
      alignItems: "center",
      flexBasis: "30%",
      maxWidth: "30%",
      marginVertical: 10,
      marginHorizontal: "1.5%",
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
    label: {
      ...theme.fonts.titleMedium,
      textAlign: "center",
      color: theme.colors.onBackground,
    },
    containerStyle: { zIndex: 3 },
    extendedViewContainer: {
      backgroundColor: theme.colors.elevation.level1,
    },
  });
