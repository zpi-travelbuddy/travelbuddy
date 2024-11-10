import { TextInput, useTheme } from "react-native-paper";
import { StyleProp, TextStyle, StyleSheet } from "react-native";
import { MD3ThemeExtended } from "@/constants/Themes";

export function CodeTextInput({
  style,
  value,
  onChangeText,
  error,
}: {
  style: StyleProp<TextStyle>;
  value: string | undefined;
  onChangeText: (((text: string) => void) & Function) | undefined;
  error?: boolean;
}) {
  const theme = useTheme() as MD3ThemeExtended;
  const innerStyle = makeStyles(theme);

  return (
    <TextInput
      style={style}
      value={value}
      onChangeText={onChangeText}
      mode="outlined"
      placeholder="Kod potwierdzający"
      keyboardType="numeric"
      inputMode="numeric"
      left={<TextInput.Icon style={innerStyle.icon} icon="pound" />}
      error={error}
    />
  );
}

const makeStyles = (theme: MD3ThemeExtended) =>
  StyleSheet.create({
    icon: {
      backgroundColor: theme.colors.surface,
    },
  });
