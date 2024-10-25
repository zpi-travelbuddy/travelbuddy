import React from "react";
import { Divider, List, MD3Theme, useTheme } from "react-native-paper";
import { StyleSheet } from "react-native";
import { BLACK } from "@/constants/Colors";

type SettingListItemProps = {
  title: string;
  rightComponent: () => React.ReactNode;
  onPress: () => void;
};

const SettingListItem = ({
  title,
  rightComponent,
  onPress,
}: SettingListItemProps) => {
  const styles = createStyles(useTheme());
  return (
    <>
      <List.Item title={title} right={rightComponent} onPress={onPress} />
      <Divider style={styles.divider} />
    </>
  );
};

const createStyles = (theme: MD3Theme) =>
  StyleSheet.create({
    divider: {
      backgroundColor: theme.colors.onSurface,
    },
  });

export default SettingListItem;
