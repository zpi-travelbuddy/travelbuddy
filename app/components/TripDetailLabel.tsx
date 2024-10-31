import { StyleSheet, View } from "react-native";
import React, { useMemo } from "react";
import { MD3Theme, Text, useTheme } from "react-native-paper";

interface TripDetailLabelProps {
  title: string;
  value: string;
}

const TripDetailLabel = ({ title, value }: TripDetailLabelProps) => {
  const theme = useTheme();
  const styles = useMemo(() => createStyles(theme), [theme]);
  return (
    <View style={styles.container}>
      <Text style={styles.title}>{title}</Text>
      <Text style={styles.value}>{value}</Text>
    </View>
  );
};

export default TripDetailLabel;

const createStyles = (theme: MD3Theme) =>
  StyleSheet.create({
    container: {
      width: "100%",
      paddingHorizontal: 16,
      paddingVertical: 8,
    },
    title: {
      ...theme.fonts.bodyMedium,
      marginBottom: 4,
    },
    value: {
      ...theme.fonts.titleMedium,
      width: "60%",
    },
  });
