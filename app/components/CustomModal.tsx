import React from "react";
import { Dimensions, StyleSheet, View } from "react-native";
import { Modal, Portal, MD3Theme, useTheme } from "react-native-paper";

interface CustomModalProps {
  visible: boolean;
  onDismiss: () => void;
  children: React.ReactNode;
}

const { width } = Dimensions.get("window");

const CustomModal: React.FC<CustomModalProps> = ({
  visible,
  onDismiss,
  children,
}) => {
  const theme = useTheme();
  const styles = createStyles(theme);
  return (
    <Portal>
      <Modal
        theme={theme}
        visible={visible}
        onDismiss={onDismiss}
        contentContainerStyle={styles.modalContainer}
      >
        <View style={styles.content}>{children}</View>
      </Modal>
    </Portal>
  );
};

const createStyles = (theme: MD3Theme) =>
  StyleSheet.create({
    modalContainer: {
      backgroundColor: theme.colors.background,
      width: width * 0.8,
      padding: 20,
      borderRadius: 10,
      alignSelf: "center",
    },
    content: {
      alignItems: "center",
    },
  });

export default CustomModal;
