import { MD3ThemeExtended } from "@/constants/Themes";
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
  disabled?: boolean;
}

const ClickableInput: React.FC<ClickableInputProps> = ({
  label,
  value,
  icon,
  onPress,
  touchableStyle,
  inputStyle,
  left,
  right,
  error,
  disabled,
}) => {
  const theme = useTheme();
  const styles = createStyles(theme as MD3ThemeExtended);

  return (
    <TouchableOpacity
      onPress={disabled ? undefined : onPress}
      activeOpacity={disabled ? 1 : 0.2}
      style={[styles.container, touchableStyle]}
    >
      <TextInput
        mode="outlined"
        label={label}
        style={[
          styles.textInput,
          inputStyle,
          disabled ? styles.textInputDisabled : {},
        ]}
        value={value}
        editable={false}
        error={error || false}
        left={
          left
            ? React.cloneElement(left as React.ReactElement, {
                onPress: onPress,
              })
            : icon
              ? React.cloneElement(
                  <TextInput.Icon icon={icon} onPress={onPress} />,
                )
              : undefined
        }
        right={
          right
            ? React.cloneElement(right as React.ReactElement, {
                onPress: onPress,
              })
            : undefined
        }
        disabled={disabled || false}
      />
    </TouchableOpacity>
  );
};

const createStyles = (theme: MD3ThemeExtended) =>
  StyleSheet.create({
    container: {
      width: "90%",
      backgroundColor: theme.colors.surface,
    },
    textInput: { backgroundColor: theme.colors.surface },
    textInputDisabled: {
      backgroundColor: theme.colors.inverseOnSurface,
    },
  });

export default ClickableInput;
