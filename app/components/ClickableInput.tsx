import React, { ReactNode } from "react";
import {
  TouchableOpacity,
  StyleSheet,
  TextStyle,
  ViewStyle,
} from "react-native";
import { TextInput, useTheme, MD3Theme } from "react-native-paper";

interface ClickableInputProps {
  label: string;
  value: string;
  icon?: string;
  onPress: () => void;
  touchableStyle?: ViewStyle;
  inputStyle?: TextStyle;
  left?: ReactNode;
  right?: ReactNode;
  error?: boolean;
}

const ClickableInput: React.FC<ClickableInputProps> = ({
  label,
  value,
  icon = "account",
  onPress,
  touchableStyle,
  inputStyle,
  left,
  right,
  error,
}) => {
  const theme = useTheme();

  return (
    <TouchableOpacity
      onPress={onPress}
      style={[styles(theme).container, touchableStyle]}
    >
      <TextInput
        mode="outlined"
        label={label}
        style={[{ backgroundColor: theme.colors.surface }, inputStyle]}
        value={value}
        editable={false}
        error={error || false}
        left={
          left ? (
            React.cloneElement(left as React.ReactElement, {
              onPress: onPress,
            })
          ) : (
            <TextInput.Icon icon={icon} onPress={onPress} />
          )
        }
        right={
          right
            ? React.cloneElement(right as React.ReactElement, {
                onPress: onPress,
              })
            : undefined
        }
      />
    </TouchableOpacity>
  );
};

const styles = (theme: MD3Theme) =>
  StyleSheet.create({
    container: {
      width: "90%",
      backgroundColor: theme.colors.surface,
    },
  });

export default ClickableInput;
