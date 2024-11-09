import { registerTranslation } from "react-native-paper-dates";

export function stringToDate(date: string): Date {
  const [year, month, day] = date.split("-").map(Number);
  return new Date(year, month - 1, day);
}

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

export function applyRegisterTranslation(): void {
  registerTranslation("pl", {
    save: "Zapisz",
    selectSingle: "Wybierz datę",
    selectMultiple: "Wybierz daty",
    selectRange: "Wybierz zakres",
    notAccordingToDateFormat: (inputFormat) =>
      `Data wymaga formatu: ${inputFormat}`,
    mustBeHigherThan: (date) => `Musi być później niż ${date}`,
    mustBeLowerThan: (date) => `Musi być wcześniej niż ${date}`,
    mustBeBetween: (startDate, endDate) =>
      `Musi być pomiędzy ${startDate} - ${endDate}`,
    dateIsDisabled: "Dzień nie jest dozwolony",
    previous: "Poprzedni",
    next: "Następny",
    typeInDate: "Wpisz datę",
    pickDateFromCalendar: "Wybierz datę z kalendarza",
    close: "Zamknij",
    hour: "",
    minute: "",
  });
}
