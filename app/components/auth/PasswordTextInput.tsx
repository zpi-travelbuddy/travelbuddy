import { TextInput } from "react-native-paper";
import { StyleProp, TextStyle, Platform, View } from "react-native";
import { useState } from "react";
import { GestureResponderEvent } from "react-native";

export function PasswordTextInput({
  style,
  value,
  onChangeText,
  error,
}: {
  style: StyleProp<TextStyle>;
  value: string | undefined;
  onChangeText: (((text: string) => void) & Function) | undefined;
  error?: boolean | undefined;
}) {
  const [hidePassword, setHidePassword] = useState(true);

  const switchPasswordVisibility = (e: GestureResponderEvent) => {
    e.stopPropagation();
    setHidePassword((prev) => !prev);
  };

  return (
    <TextInput
      style={style}
      value={value}
      onChangeText={onChangeText}
      error={error || undefined}
      mode="outlined"
      placeholder="Hasło"
      left={<TextInput.Icon icon="lock-outline" />}
      right={
        <TextInput.Icon
          icon={hidePassword ? "eye" : "eye-off"}
          forceTextInputFocus={false}
          onPress={switchPasswordVisibility}
          onLongPress={(e: GestureResponderEvent) => e.stopPropagation()}
        />
      }
      secureTextEntry={Platform.OS !== "ios" && hidePassword}
    />
  );
}
