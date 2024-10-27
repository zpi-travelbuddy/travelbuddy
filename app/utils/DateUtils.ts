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