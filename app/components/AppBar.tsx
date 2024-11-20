import { Appbar, Menu, useTheme } from "react-native-paper";
import { NativeStackHeaderProps } from "@react-navigation/native-stack";
import { NativeStackNavigationOptions } from "@react-navigation/native-stack";
import { useState } from "react";
import { MENU_ICON } from "@/constants/Icons";

interface Action {
  icon?: string;
  title?: string;
  color?: string;
  hasMenu?: boolean;
  menuActions?: Action[];
  onPress?: () => void;
}

interface NativeStackNavigationOptionsWithActions
  extends NativeStackNavigationOptions {
  actions?: Action[];
}

export const AppBar = ({ options, navigation }: NativeStackHeaderProps) => {
  // Menu state
  const [visible, setVisible] = useState(false);

  const openMenu = () => {
    setVisible(true);
  };

  const handleDismiss = () => {
    setVisible(false);
  };

  // Check if should show back button
  const state = navigation.getState();
  const isTabRoot = state.index === 0;
  const showBackButton = navigation.canGoBack() && !isTabRoot;

  const theme = useTheme();

  // Destructure the dynamic actions passed from the screen options
  const { actions = [] } = options as NativeStackNavigationOptionsWithActions;

  return (
    <Appbar.Header>
      {showBackButton && <Appbar.BackAction onPress={navigation.goBack} />}
      <Appbar.Content title={options.title} />
      {actions.map((action: Action, index: number) =>
        action.hasMenu ? (
          <Menu
            key={index}
            onDismiss={handleDismiss}
            visible={visible}
            anchor={
              <Appbar.Action
                icon={action?.icon ?? MENU_ICON}
                onPress={openMenu}
                color={action?.color ?? theme.colors.onSurface}
              />
            }
            anchorPosition="bottom"
          >
            {action?.menuActions?.map((menuAction: Action, index: number) => (
              <Menu.Item
                key={index}
                leadingIcon={menuAction.icon}
                onPress={() => {
                  menuAction?.onPress?.();
                  handleDismiss();
                }}
                title={menuAction.title}
                theme={{
                  colors: menuAction.color
                    ? {
                        onSurface: menuAction.color,
                        onSurfaceVariant: menuAction.color,
                      }
                    : undefined,
                }}
              />
            ))}
          </Menu>
        ) : (
          <Appbar.Action
            key={index}
            icon={action?.icon ?? MENU_ICON}
            onPress={action.onPress}
            color={action?.color ?? theme.colors.onSurface}
          />
        ),
      )}
    </Appbar.Header>
  );
};
