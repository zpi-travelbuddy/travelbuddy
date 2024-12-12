import React, { createContext, useContext, useState, ReactNode } from "react";

type ScreenName =
  | "trip-day"
  | "trips"
  | "trip-point-details"
  | "trip-details"
  | null;

interface ShouldRefreshContextProps {
  refreshScreens: ScreenName[];
  addRefreshScreen: (name: ScreenName) => void;
  removeRefreshScreen: (name: ScreenName) => void;
}

const ShouldRefreshContext = createContext<
  ShouldRefreshContextProps | undefined
>(undefined);

export const ShouldRefreshProvider: React.FC<{ children: ReactNode }> = ({
  children,
}) => {
  const [refreshScreens, setRefreshScreens] = useState<ScreenName[]>([]);

  const addRefreshScreen = (name: ScreenName) => {
    setRefreshScreens((prev) => {
      if (!prev.includes(name)) {
        return [...prev, name];
      }
      return prev;
    });
  };

  const removeRefreshScreen = (name: ScreenName) => {
    setRefreshScreens((prev) => prev.filter((screen) => screen !== name));
  };

  return (
    <ShouldRefreshContext.Provider
      value={{ refreshScreens, addRefreshScreen, removeRefreshScreen }}
    >
      {children}
    </ShouldRefreshContext.Provider>
  );
};

export const useShouldRefresh = (): ShouldRefreshContextProps => {
  const context = useContext(ShouldRefreshContext);
  if (!context) {
    throw new Error(
      "useShouldRefresh must be used within a ShouldRefreshProvider",
    );
  }
  return context;
};
