export function formatDate(date: Date | undefined): string {
  if (!date) return "";
  const day = String(date.getDate()).padStart(2, "0");
  const month = String(date.getMonth() + 1).padStart(2, "0");
  const year = date.getFullYear();

  return `${day}.${month}.${year}`;
}

export function formatDateRange(
  startDate: Date | undefined,
  endDate: Date | undefined,
): string {
  if (startDate?.getDate() !== endDate?.getDate())
    return formatDate(startDate) + " - " + formatDate(endDate);
  return formatDate(startDate);
}

export const formatTime = (date: Date): string => {
  const hours = date.getHours().toString().padStart(2, "0");
  const minutes = date.getMinutes().toString().padStart(2, "0");
  return `${hours}:${minutes}`;
};

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
