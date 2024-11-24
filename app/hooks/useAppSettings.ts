import { useContext } from "react";
import { AppSettingsContext } from "@/context/AppSettingsContext";

const useAppSettings = () => {
  const context = useContext(AppSettingsContext);

  if (!context) {
    throw new Error(
      "useAppSettings must be used within an AppSettingsProvider",
    );
  }

  return context;
};

export default useAppSettings;
