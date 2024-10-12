import { StyleSheet, TextStyle } from "react-native";

interface FontStyles {
  x_small: TextStyle;
  small: TextStyle;
  medium: TextStyle;
  large: TextStyle;
  x_large: TextStyle;
}

const useFontStyles = (): FontStyles => {
  const fontStyles = StyleSheet.create<FontStyles>({
    x_small: {
      fontFamily: "Manrope",
      fontSize: 8,
    },
    small: {
      fontFamily: "Manrope",
      fontSize: 12,
    },
    medium: {
      fontFamily: "Manrope",
      fontSize: 16,
    },
    large: {
      fontFamily: "Manrope",
      fontSize: 20,
    },
    x_large: {
      fontFamily: "Manrope",
      fontSize: 24,
    },
  });

  return fontStyles;
};

export default useFontStyles;
