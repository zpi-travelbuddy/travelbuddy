/* eslint-disable @typescript-eslint/no-explicit-any */
// context/NavigationDataContext.tsx
import React, { createContext, useContext, useState, ReactNode } from "react";

interface NavigationDataContextType {
  data: Record<string, any> | null;
  setData: (data: Record<string, any> | null) => void;
}

const NavigationDataContext = createContext<
  NavigationDataContextType | undefined
>(undefined);

export const NavigationDataProvider: React.FC<{ children: ReactNode }> = ({
  children,
}) => {
  const [data, setData] = useState<Record<string, any> | null>(null);

  return (
    <NavigationDataContext.Provider value={{ data, setData }}>
      {children}
    </NavigationDataContext.Provider>
  );
};

export const useNavigationData = (): NavigationDataContextType => {
  const context = useContext(NavigationDataContext);
  if (!context) {
    throw new Error(
      "useNavigationData must be used within a NavigationDataProvider",
    );
  }
  return context;
};
