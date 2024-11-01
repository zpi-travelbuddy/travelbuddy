import { registerTranslation } from "react-native-paper-dates";

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

export function registerTranslationForDatePicker(): void {
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
