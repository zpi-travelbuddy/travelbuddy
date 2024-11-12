import React, { useRef, useEffect, useCallback } from "react";
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
  extendedView?: React.ReactNode;
  onClose: () => void;
  label?: string;
}

const CreatingTripPointSelector: React.FC<BottomSheetComponentProps> = ({
  options,
  isVisible,
  extendedView,
  onClose,
  label,
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
        enablePanDownToClose
        onClose={onClose}
        onAnimate={handleAnimate}
        containerStyle={styles.containerStyle}
        backgroundComponent={({ style }) => (
          <View style={[style, styles.contentContainer]} />
        )}
      >
        <BottomSheetView style={styles.contentContainer}>
          {!!label && <Text style={styles.label}>{label}</Text>}
          <View style={styles.buttonsContainer}>
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
          </View>
          {extendedView && extendedView}
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
      paddingVertical: 10,
      borderTopLeftRadius: 40,
      borderTopRightRadius: 40,
      backgroundColor: theme.colors.elevation.level1,
    },
    buttonsContainer: {
      flexDirection: "row",
      flexWrap: "wrap",
      justifyContent: "flex-start",
      marginVertical: 10,
    },
    option: {
      alignItems: "center",
      flexBasis: "30%",
      maxWidth: "30%",
      marginBottom: 20,
      marginHorizontal: "1.5%",
    },
    optionLabel: {
      ...theme.fonts.bodySmall,
      marginVertical: 10,
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