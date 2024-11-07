import { MD3ThemeExtended } from "@/constants/Themes";
import { StyleSheet } from "react-native";
import { ActivityIndicator, Modal, useTheme } from "react-native-paper";

interface LoadingViewProps {
  show?: boolean;
  transparent?: boolean;
}

const LoadingView = ({ show = true, transparent = true }: LoadingViewProps) => {
  const theme = useTheme();
  const style = createStyles(theme as MD3ThemeExtended);

  return (
    <Modal
      visible={show}
      style={[
        transparent ? null : { backgroundColor: theme.colors.surface },
        style.modal,
      ]}
      contentContainerStyle={style.modalContent}
      dismissable={false}
    >
      <ActivityIndicator size="large" animating={true} />
    </Modal>
  );
};

const createStyles = (theme: MD3ThemeExtended) =>
  StyleSheet.create({
    modal: {
      marginTop: 0,
      marginBottom: 0,
    },
    modalContent: {
      alignSelf: "center",
    },
  });

export default LoadingView;
