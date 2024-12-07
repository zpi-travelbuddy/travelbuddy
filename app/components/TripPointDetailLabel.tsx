import { MD3ThemeExtended } from "@/constants/Themes";
import { StyleSheet, View } from "react-native";
import { Text, useTheme } from "react-native-paper";

interface TripPointDetailsLabelProps {
  title: string;
  element: JSX.Element;
}

export const TripPointDetailsLabel = ({
  title,
  element,
}: TripPointDetailsLabelProps) => {
  const theme = useTheme();
  const styles = createStyles(theme as MD3ThemeExtended);

  return (
    <View style={styles.container}>
      <Text style={styles.title}>{title}</Text>
      {element}
    </View>
  );
};

const createStyles = (theme: MD3ThemeExtended) =>
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
  });
