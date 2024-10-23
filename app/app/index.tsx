import { BottomNavigationTabs } from "@/components/BottomNavigationTabs";
import React from "react";
import { Provider, useTheme } from "react-native-paper";

export default function Index() {
  const theme = useTheme();

  return (
    <Provider theme={theme}>
      <BottomNavigationTabs />
    </Provider>
  );
}
