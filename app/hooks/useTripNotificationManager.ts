import { NotificationDataContext } from "@/context/NotificationsContext";
import { useContext } from "react";

const useTripNotificationManager = () => {
  const context = useContext(NotificationDataContext);

  if (!context) {
    throw new Error(
      "useTripNotificationManager must be used within an NotificationDataContext",
    );
  }

  return context;
};

export default useTripNotificationManager;
