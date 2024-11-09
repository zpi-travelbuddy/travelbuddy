export function stringToDate(date: string): Date {
  const [year, month, day] = date.split("-").map(Number);
  return new Date(year, month - 1, day);
}

export function getPreviousDay(): Date {
  const today = new Date();
  today.setDate(today.getDate() - 1);

  return new Date(formatDateToISO(today));
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

export function formatDateToPolish(date: Date | undefined): string {
  if (!date) return "";
  return date.toLocaleDateString("pl-PL");
}

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

export function formatTimeRange(startTime: string, endTime: string): string {
  return `${startTime} - ${endTime}`;
}
