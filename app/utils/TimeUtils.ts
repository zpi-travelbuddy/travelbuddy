export function stringToDate(date: string): Date {
  const [year, month, day] = date.split("-").map(Number);
  return new Date(year, month - 1, day);


}export function stringToDateDots(date: string): Date {
  const [year, month, day] = date.split(".").map(Number).reverse();
  return new Date(year, month - 1, day);
}

export function getISOToday(): Date {
  const today = new Date(Date.now());
  const todayISO = new Date(formatDateToISO(today));
  todayISO.setHours(todayISO.getHours() - 1); // This fixes an issue with calendar (but a new issue may appear)
  return todayISO;
}

export function formatDateToISO(date: Date | undefined): string {
  if (!date) return "";
  const polishDate = formatDateToPolish(date);
  return polishDate
    .split(".")
    .reverse()
    .map((part: string) => part.padStart(2, "0"))
    .join("-");
}

export function formatDateFromISO(date: string | undefined): string {
  if (!date) return "";
  return date.split("-").reverse().join(".");
}

export function formatDateToPolish(date: Date | undefined): string {
  if (!date) return "";
  return date.toLocaleDateString("pl-PL");
}

export const formatTime = (
  date: Date,
  withSeconds: boolean = false,
): string => {
  const hours = date.getHours().toString().padStart(2, "0");
  const minutes = date.getMinutes().toString().padStart(2, "0");
  const seconds = date.getSeconds().toString().padStart(2, "0");
  if (withSeconds) return `${hours}:${minutes}:${seconds}`;
  else return `${hours}:${minutes}`;
};

export function formatDateRange(
  startDate: Date | undefined,
  endDate: Date | undefined,
): string {
  if (!endDate) return formatDateToPolish(startDate);
  if (startDate?.getDate() !== endDate?.getDate())
    return formatDateToPolish(startDate) + " - " + formatDateToPolish(endDate);
  return formatDateToPolish(startDate);
}

export function formatMinutes(minutes: number): string {
  const hours = Math.floor(minutes / 60);

  if (hours > 0) {
    if (minutes % 60 === 0) return `${hours} h`;
    return `${hours} h ${minutes % 60} min`;
  }

  return `${minutes} min`;
}

export function formatMinutesInWords(minutes: number): string {
  const hours = Math.floor(minutes / 60);
  const remainingMinutes = minutes % 60;
  if (hours > 0) {
    const hoursInWord =
      hours === 1 ? "godzina" : hours > 4 ? "godzin" : "godziny";
    return remainingMinutes === 0
      ? `${hours} ${hoursInWord}`
      : `Ponad ${hours} ${hoursInWord}`;
  }

  return `${minutes} minut`;
}

export function formatTimeFromString(time: string): string {
  if (time.length <= 5) return time;
  return time.slice(0, 5);
}

export function formatTimeRange(startTime: string, endTime: string): string {
  if (startTime === endTime) return startTime;
  return `${startTime} - ${endTime}`;
}

export function roundToNearestQuarterHour(date: Date = new Date()): Date {
  const minutes = date.getMinutes();
  const remainder = minutes % 15;
  const roundedMinutes = remainder === 0 ? minutes : minutes + (15 - remainder);
  const roundedDate = new Date(date);
  roundedDate.setMinutes(roundedMinutes);
  roundedDate.setSeconds(0);
  roundedDate.setMilliseconds(0);
  return roundedDate;
}
export function addHoursToDate(
  date: Date = new Date(),
  hours: number = 1,
): Date {
  const newDate = new Date(date);
  newDate.setHours(newDate.getHours() + hours);
  return newDate;
}

export function addHoursToTheSameDay(
  date: Date = new Date(),
  hours: number = 1,
): Date {
  let newDate = new Date(date);
  newDate.setHours(newDate.getHours() + hours);

  if (newDate.getDate() !== date.getDate()) {
    newDate = new Date(date);
    newDate.setHours(23, 59, 59, 999);
  }

  return newDate;
}

export const formatToISODate = (date: Date): string => {
  return date.toISOString().split("T")[0];
};

type TimeType = "hours" | "minutes";

export const convertToSeconds = (time: number, timeType: TimeType) => {
  if (timeType === "hours") return 60 * 60 * time;
  else if (timeType === "minutes") return 60 * time;
  else return time;
};
export const convertFromSeconds = (time: number, timeType: TimeType) => {
  if (timeType === "hours") return time / (60 * 60);
  else if (timeType === "minutes") return time / 60;
  else return time;
};

export const getTimeWithoutSeconds = (time: string) => {
  return time.split(":").slice(0, 2).join(":");
};

export const convertTimestampToDateTime = (timestamp: string) => {
  const [hours, minutes, seconds] = timestamp.split(":").map(Number);
  const date = new Date();
  date.setHours(hours, minutes, seconds || 0, 0);
  return date;
};

export const formatTimeSpan = (hours?: number, minutes?: number): string => {
  const h = hours ?? 0;
  const m = minutes ?? 0;

  if (h < 0 || m < 0) {
    throw new Error("Hours and minutes must be non-negative numbers.");
  }
  const s = 0;

  const hh = h.toString().padStart(2, "0");
  const mm = m.toString().padStart(2, "0");
  const ss = s.toString().padStart(2, "0");

  return `${hh}:${mm}:${ss}`;
};

export const combineDateAndTime = (date: Date, time: string): Date => {
  const [hours, minutes, seconds] = time.split(":").map(Number);

  const combinedDate = new Date(date);
  combinedDate.setHours(hours, minutes, seconds, 0);

  return combinedDate;
};

export const getTotalMinutesFromTimestamp = (timestamp: string): number => {
  const [hours, minutes, seconds] = timestamp.split(":").map(Number);
  const totalMinutes = hours * 60 + minutes + Math.floor(seconds / 60);
  return totalMinutes;
};
