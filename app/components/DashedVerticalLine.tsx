import { StyleSheet, View } from "react-native";
import { MD3Theme, useTheme } from "react-native-paper";

export const DashedVerticalLine = ({ height }: { height: number }) => {
  const theme = useTheme();
  const style = createStyles(theme);

  return <View style={[style.line, { height }]} />;
};

const createStyles = (theme: MD3Theme) =>
  StyleSheet.create({
    line: {
      width: 0,
      borderColor: theme.colors.onSurface,
      borderWidth: 1,
      borderStyle: "dashed",
    },
  });
