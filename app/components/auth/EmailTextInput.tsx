import { TextInput } from "react-native-paper";
import { StyleProp, TextStyle } from "react-native";

export function EmailTextInput({
  style,
  value,
  onChangeText,
  error,
}: {
  style: StyleProp<TextStyle>;
  value: string | undefined;
  onChangeText: (((text: string) => void) & Function) | undefined;
  error: boolean | undefined;
}) {
  return (
    <TextInput
      style={style}
      value={value}
      onChangeText={onChangeText}
      error={error}
      mode="outlined"
      placeholder="Email"
      keyboardType="email-address"
      inputMode="email"
      left={<TextInput.Icon icon="at" />}
    />
  );
}
