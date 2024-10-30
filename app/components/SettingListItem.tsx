import React from "react";
import { Divider, List, MD3Theme, useTheme } from "react-native-paper";
import { StyleSheet } from "react-native";

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
      <List.Item
        title={title}
        right={rightComponent}
        onPress={onPress}
        contentStyle={{ justifyContent: "center" }}
        style={styles.item}
        titleStyle={styles.title}
      />
      <Divider style={styles.divider} />
    </>
  );
};

const createStyles = (theme: MD3Theme) =>
  StyleSheet.create({
    item: {
      justifyContent: "center",
      alignItems: "center",
      height: 60,
    },
    title: {
      textAlignVertical: "center",
    },
    divider: {
      backgroundColor: theme.colors.onSurface,
    },
  });

export default SettingListItem;
