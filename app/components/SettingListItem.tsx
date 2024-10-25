import React from "react";
import { Divider, List } from "react-native-paper";
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
  const styles = createStyles();
  return (
    <>
      <List.Item title={title} right={rightComponent} onPress={onPress} />
      <Divider style={styles.divider} />
    </>
  );
};

const createStyles = () =>
  StyleSheet.create({
    divider: {
      backgroundColor: BLACK,
    },
  });

export default SettingListItem;
