import { Appbar } from "react-native-paper";
import { NativeStackHeaderProps } from "@react-navigation/native-stack";
import { NativeStackNavigationOptions } from "@react-navigation/native-stack";

interface Action {
  icon: string;
  onPress: () => void;
}

interface NativeStackNavigationOptionsWithActions
  extends NativeStackNavigationOptions {
  actions?: Action[];
}

export const AppBar = ({
  options,
  route,
  navigation,
}: NativeStackHeaderProps) => {
  // Check if should show back button
  const state = navigation.getState();
  const isTabRoot = state.index === 0;
  const showBackButton = navigation.canGoBack() && !isTabRoot;

  // Destructure the dynamic actions passed from the screen options
  const { actions = [] } = options as NativeStackNavigationOptionsWithActions;

  return (
    <Appbar.Header>
      {showBackButton && <Appbar.BackAction onPress={navigation.goBack} />}
      <Appbar.Content title={options.title} />
      {actions.map((action: Action, index: number) => (
        <Appbar.Action
          key={index}
          icon={action.icon}
          onPress={action.onPress}
        />
      ))}
    </Appbar.Header>
  );
};
