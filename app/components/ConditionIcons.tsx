import { StyleSheet, View, ViewStyle } from "react-native";
import { Text, useTheme } from "react-native-paper";
import React, { useEffect, useState } from "react";
import IconRow from "./IconRow";
import { Condition } from "@/types/Trip";
import { MD3ThemeExtended } from "@/constants/Themes";

interface ConditionIconsProps {
  conditions: Condition[];
  iconColor: string;
  style?: ViewStyle;
}

const ConditionIcons: React.FC<ConditionIconsProps> = ({
  conditions = [],
  iconColor,
  style,
}) => {
  const theme = useTheme() as MD3ThemeExtended;
  const styles = createStyles(theme, iconColor);
  if (conditions.length === 0)
    return (
      <>
        <Text style={styles.text}>Brak</Text>
      </>
    );
  return (
    <>
      <IconRow style={style} iconColor={iconColor} icons={conditions}></IconRow>
    </>
  );
};

export default ConditionIcons;

const createStyles = (theme: MD3ThemeExtended, iconColor: string) =>
  StyleSheet.create({
    text: {
      ...theme.fonts.bodyLarge,
      color: iconColor,
    },
  });
