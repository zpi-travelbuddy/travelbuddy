import * as Calendar from "expo-calendar";
import { useEffect } from "react";
import { Platform } from "react-native";
import { Colors } from "@/constants/Colors";

const CALENDAR_IDENTIFIER = "travelbuddy-calendar";

const getDefaultCalendar = async (): Promise<string> => {
  if (Platform.OS === "ios") {
    return (await Calendar.getDefaultCalendarAsync()).id;
  } else {
    const calendars = await Calendar.getCalendarsAsync();
    const defaultCalendar = calendars.find(
      (cal) => cal.source.name === CALENDAR_IDENTIFIER,
    );

    if (!defaultCalendar) {
      return createDefaultCalendar();
    }

    return defaultCalendar.id;
  }
};

async function createDefaultCalendar(): Promise<string> {
  const source = {
    name: CALENDAR_IDENTIFIER,
    isLocalAccount: true,
  } as Calendar.Source;
  return await Calendar.createCalendarAsync({
    title: "TravelBuddy",
    color: Colors.light.primary,
    entityType: Calendar.EntityTypes.EVENT,
    sourceId: source.id,
    source,
    name: "TravelBuddy",
    ownerAccount: "personal",
    accessLevel: Calendar.CalendarAccessLevel.OWNER,
    isVisible: true,
  });
}

export default function CalendarUtil() {
  useEffect(() => {
    (async () => {
      await Calendar.requestCalendarPermissionsAsync();
    })();
  }, []);

  return null;
}

export async function addEventToMainCalendar(
  data: Omit<Partial<Calendar.Event>, "id">,
): Promise<boolean> {
  const calendarId = await getDefaultCalendar();

  try {
    const eventId = await Calendar.createEventAsync(calendarId, data);
    Calendar.openEventInCalendar(eventId);
    return true;
  } catch (error) {
    console.error(error);
  }
  return false;
}
