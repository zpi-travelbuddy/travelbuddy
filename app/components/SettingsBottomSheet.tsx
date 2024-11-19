import React, {
  useCallback,
  useEffect,
  useMemo,
  useRef,
  useState,
} from "react";
import { View, StyleSheet, TouchableWithoutFeedback } from "react-native";
import BottomSheet, { BottomSheetView } from "@gorhom/bottom-sheet";
import {
  List,
  RadioButton,
  Text,
  useTheme,
  MD3Theme,
} from "react-native-paper";

interface SettingsBottomSheetProps {
  title: string;
  items: Record<string, string>;
  selectedItem: string;
  isVisible: boolean;
  itemHeight?: number;
  onSelect: (item: string) => void;
  onClose: () => void;
}

const SettingsBottomSheet: React.FC<SettingsBottomSheetProps> = ({
  title,
  items,
  selectedItem,
  isVisible,
  itemHeight = 50,
  onSelect,
  onClose,
}) => {
  const theme = useTheme();
  const styles = createStyles(theme);
  const sheetRef = useRef<BottomSheet>(null);
  const [selectedOption, setSelectedOption] = useState<string>(selectedItem);

  const snapPoints = useMemo(() => {
    const titleHeight = 60;
    const paddingHeight = 32;
    return [
      titleHeight + 2 * paddingHeight + Object.keys(items).length * itemHeight,
    ];
  }, [items]);

  const handleSelect = (key: string) => {
    setSelectedOption(key);
    onSelect(key);
    onClose();
  };

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
        snapPoints={snapPoints}
        enablePanDownToClose
        onClose={onClose}
        onAnimate={handleAnimate}
        containerStyle={{ zIndex: 3 }}
        backgroundComponent={({ style }) => (
          <View style={[style, styles.bottomSheetContainer]} />
        )}
      >
        <BottomSheetView>
          <View style={styles.titleContainer}>
            <Text style={styles.bottomSheetTitle}>{title}</Text>
          </View>
          {Object.entries(items).map(([key, value]) => (
            <List.Item
              key={key}
              title={value}
              titleStyle={styles.bottomSheetItemTitle}
              style={{ height: itemHeight }}
              right={() => (
                <RadioButton
                  value={key}
                  status={selectedItem === key ? "checked" : "unchecked"}
                  onPress={() => handleSelect(key)}
                />
              )}
            />
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

const createStyles = (theme: MD3Theme) =>
  StyleSheet.create({
    bottomSheetContainer: {
      padding: 30,
      borderTopLeftRadius: 40,
      borderTopRightRadius: 40,
      backgroundColor: theme.colors.elevation.level1,
    },
    titleContainer: {
      padding: 16,
      justifyContent: "flex-start",
    },
    bottomSheetTitle: {
      ...theme.fonts.titleMedium,
    },
    bottomSheetItemTitle: {
      ...theme.fonts.bodyMedium,
    },
    scrim: {
      ...StyleSheet.absoluteFillObject,
      backgroundColor: "rgba(0, 0, 0, 0.5)",
      zIndex: 1,
    },
  });

export default SettingsBottomSheet;
