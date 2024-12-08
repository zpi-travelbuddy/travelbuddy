import { useState, useEffect, useCallback } from "react";
import AsyncStorage from "@react-native-async-storage/async-storage";
import * as Notifications from "expo-notifications";

type TripNotifications = Record<string, string>; // Mapping of tripPointId to notificationId

const STORAGE_KEY = "trip-notifications";

export function useTripNotificationManager() {
  const [tripNotifications, setTripNotifications] = useState<TripNotifications>(
    {},
  );

  // Load stored data from AsyncStorage and validate against scheduled notifications
  useEffect(() => {
    const loadAndValidateData = async () => {
      try {
        // Load stored trip notifications from AsyncStorage
        const storedData = await AsyncStorage.getItem(STORAGE_KEY);
        const storedTripNotifications = storedData
          ? (JSON.parse(storedData) as TripNotifications)
          : {};

        // Fetch all currently scheduled notifications
        const scheduledNotifications =
          await Notifications.getAllScheduledNotificationsAsync();
        const scheduledIds = scheduledNotifications.map(
          (notification) => notification.identifier,
        );

        // Filter out trip notifications that are no longer scheduled
        const validatedTripNotifications = Object.fromEntries(
          Object.entries(storedTripNotifications).filter(
            ([_, notificationId]) => scheduledIds.includes(notificationId),
          ),
        );

        // Update state and save validated data back to AsyncStorage
        setTripNotifications(validatedTripNotifications);
        await AsyncStorage.setItem(
          STORAGE_KEY,
          JSON.stringify(validatedTripNotifications),
        );
      } catch (error) {
        console.error("Failed to validate and load trip notifications", error);
      }
    };

    loadAndValidateData();
  }, []);

  // Helper function to persist the current state to AsyncStorage
  const saveToStorage = async (data: TripNotifications) => {
    try {
      await AsyncStorage.setItem(STORAGE_KEY, JSON.stringify(data));
    } catch (error) {
      console.error("Failed to save trip notifications to storage", error);
    }
  };

  /**
   * Registers a trip point ID with a notification ID.
   * @param tripPointId - The ID of the trip point.
   * @param notificationId - The ID of the notification.
   */
  const registerNotification = useCallback(
    async (tripPointId: string, notificationId: string) => {
      setTripNotifications((prev) => {
        const updated = { ...prev, [tripPointId]: notificationId };
        saveToStorage(updated);
        return updated;
      });
    },
    [setTripNotifications, saveToStorage],
  );

  /**
   * Unregisters a trip point ID and removes its associated notification ID.
   * @param tripPointId - The ID of the trip point to unregister.
   */
  const unregisterNotification = useCallback(
    async (tripPointId: string) => {
      setTripNotifications((prev) => {
        const { [tripPointId]: _, ...remaining } = prev; // Exclude the removed key
        saveToStorage(remaining);
        return remaining;
      });
    },
    [setTripNotifications, saveToStorage],
  );

  /**
   * Checks if a trip point ID is registered with a notification.
   * @param tripPointId - The ID of the trip point.
   * @returns True if the trip point ID is registered.
   */
  const isRegistered = useCallback(
    (tripPointId: string): boolean =>
      tripNotifications.hasOwnProperty(tripPointId),
    [tripNotifications],
  );

  /**
   * Gets the notification ID associated with a trip point ID.
   * @param tripPointId - The ID of the trip point.
   * @returns The notification ID, or null if not found.
   */
  const getNotificationId = useCallback(
    (tripPointId: string): string | null =>
      tripNotifications[tripPointId] || null,
    [tripNotifications],
  );

  /**
   * Listener to handle notification responses and clean up local storage.
   */
  useEffect(() => {
    const subscription = Notifications.addNotificationReceivedListener(
      async (response) => {
        const firedNotificationId = response.request.identifier;
        setTripNotifications((prev) => {
          // Find the trip point ID associated with the fired notification
          const updated = Object.fromEntries(
            Object.entries(prev).filter(([tripPointId, notificationId]) => {
              return notificationId !== firedNotificationId;
            }),
          );

          saveToStorage(updated); // Save the cleaned-up mapping
          return updated;
        });
      },
    );

    return () => {
      subscription.remove(); // Cleanup the listener when the component unmounts
    };
  }, []);

  return {
    tripNotifications,
    registerNotification,
    unregisterNotification,
    isRegistered,
    getNotificationId,
  };
}
