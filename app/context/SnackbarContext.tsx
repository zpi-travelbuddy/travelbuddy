// SnackbarContext.tsx

import React, { createContext, useContext, useState, ReactNode } from "react";
import { Dimensions, StyleSheet, Text } from "react-native";
import { MD3Theme, Snackbar, useTheme } from "react-native-paper";

type SnackbarType = "success" | "warning" | "error";

interface SnackbarContextType {
  showSnackbar: (message: string, type?: SnackbarType) => void;
}

const SnackbarContext = createContext<SnackbarContextType | undefined>(
  undefined,
);

export const useSnackbar = () => {
  const context = useContext(SnackbarContext);
  if (!context) {
    throw new Error("useSnackbar must be used within a SnackbarProvider");
  }
  return context;
};

const { width } = Dimensions.get("window");

interface SnackbarProviderProps {
  children: ReactNode;
}

export const SnackbarProvider: React.FC<SnackbarProviderProps> = ({
  children,
}) => {
  const [visible, setVisible] = useState<boolean>(false);
  const [message, setMessage] = useState<string>("");
  const [type, setType] = useState<SnackbarType>("success");

  const styles = createStyles(useTheme());

  const showSnackbar = (
    msg: string,
    snackbarType: SnackbarType = "success",
  ) => {
    setMessage(msg);
    setType(snackbarType);
    setVisible(true);
  };

  const hideSnackbar = () => {
    setVisible(false);
  };

  return (
    <SnackbarContext.Provider value={{ showSnackbar }}>
      {children}
      <Snackbar
        visible={visible}
        onDismiss={hideSnackbar}
        duration={3000}
        style={[styles.snackbar, styles[type]]}
      >
        <Text style={[styles.snackbarText, styles[`${type}Text`]]}>
          {message}
        </Text>
      </Snackbar>
    </SnackbarContext.Provider>
  );
};

const createStyles = (theme: MD3Theme) =>
  StyleSheet.create({
    snackbar: {
      marginBottom: 50,
      width: width * 0.9,
      alignSelf: "center",
      borderRadius: 24,
    },
    snackbarText: {
      ...theme.fonts.bodySmall,
      textAlign: "center",
    },
    success: {
      backgroundColor: theme.colors.inverseSurface,
    },
    warning: {
      backgroundColor: "#FFCC00",
    },
    error: {
      backgroundColor: theme.colors.errorContainer,
    },
    successText: {
      color: theme.colors.inverseOnSurface,
    },
    warningText: {
      color: "#000000",
    },
    errorText: {
      color: theme.colors.onErrorContainer,
    },
  });
