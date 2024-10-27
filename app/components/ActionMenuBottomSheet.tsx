import React, { useCallback, useEffect, useMemo, useRef } from "react";
import {
  View,
  StyleSheet,
  TouchableWithoutFeedback,
  FlatList,
} from "react-native";
import BottomSheet, { BottomSheetView } from "@gorhom/bottom-sheet";
import { useTheme, MD3Theme } from "react-native-paper";
import ActionMenuListItem from "./ActionMenuListItem";
import {
  ITEM_HEIGHT,
  TITLE_HEIGHT,
  PADDING_HEIGHT,
} from "@/constants/BottomSheetConfigs";

interface ActionMenuBottomSheetProps {
  headerComponent: () => React.ReactNode;
  actions: Action[];
  isVisible: boolean;
  onClose: () => void;
}

const ActionMenuBottomSheet: React.FC<ActionMenuBottomSheetProps> = ({
  headerComponent: HeaderComponent,
  actions,
  isVisible,
  onClose,
}) => {
  const theme = useTheme();
  const styles = createStyles(theme);
  const sheetRef = useRef<BottomSheet>(null);

  const snapPoints = useMemo(() => {
    return [TITLE_HEIGHT + 2 * PADDING_HEIGHT + actions.length * ITEM_HEIGHT];
  }, [actions.length]);

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

  const renderItem = ({ item }: { item: Action }) => (
    <ActionMenuListItem
      label={item.label}
      icon={item.icon}
      onPress={item.onPress}
    />
  );

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
            {HeaderComponent && <HeaderComponent />}
            <FlatList
              data={actions}
              renderItem={renderItem}
              keyExtractor={(item, index) => `${item.label}-${index}`}
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
      marginVertical: 15,
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

export default ActionMenuBottomSheet;
