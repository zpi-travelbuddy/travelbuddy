type Action = {
  name: string;
  label: string;
  icon: string;
  onPress: () => void;
};

type ActionTextButtonsProps = {
  onCancel: () => void;
  cancelButtonLabel: string | undefined;
  onConfirm: () => void;
  confirmButtonLabel: string | undefined;
};

type ActionButtonsProps = ActionTextButtonsProps & {
  cancelIcon: string | undefined;
  confirmIcon: string | undefined;
};