type Action = {
  label: string;
  icon: string;
  onPress: () => void;
};

type ActionTextButtonsProps = {
  onAction1: () => void;
  action1ButtonLabel: string | undefined;
  onAction2: () => void;
  action2ButtonLabel: string | undefined;
};

type ActionButtonsProps = ActionTextButtonsProps & {
  action1Icon: string | undefined;
  action2Icon: string | undefined;
};
