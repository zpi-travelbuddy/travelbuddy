import { StyleSheet, ViewStyle } from "react-native";
import { Text, useTheme } from "react-native-paper";
import React, { useEffect, useState } from "react";
import IconRow from "./IconRow";
import { MD3ThemeExtended } from "@/constants/Themes";
import { Condition, getConditionIcons } from "@/types/Profile";

interface ConditionIconsProps {
  placeConditions: Condition[];
  iconColor: string;
  style?: ViewStyle;
}

const ConditionIcons: React.FC<ConditionIconsProps> = ({
  placeConditions = [],
  iconColor,
  style,
}) => {
  const theme = useTheme() as MD3ThemeExtended;
  const styles = createStyles(theme, iconColor);

  const [conditionIcons, setConditionIcons] = useState<string[]>([]);

  useEffect(() => {
    setConditionIcons(getConditionIcons([...placeConditions]));
  }, [placeConditions]);

  if (conditionIcons.length === 0)
    return (
      <>
        <Text style={styles.text}>Brak</Text>
      </>
    );
  else
    return (
      <>
        <IconRow
          style={style}
          iconColor={iconColor}
          icons={conditionIcons}
        ></IconRow>
      </>
    );
};

export default ConditionIcons;

const createStyles = (theme: MD3ThemeExtended, iconColor: string) =>
  StyleSheet.create({
    text: {
      ...theme.fonts.titleMedium,
      color: iconColor,
    },
  });
