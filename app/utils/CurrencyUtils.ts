export function formatMoneyToString(amount: number | undefined): string {
  if (amount === undefined || isNaN(amount)) return "";
  return amount
    .toFixed(2)
    .replace(".", ",")
    .replace(/\B(?=(\d{3})+(?!\d))/g, " ");
}

export function formatMoneyToNumber(value: string): number {
  const numericValue = value
    .replace(/,/g, ".")
    .replace(/[^0-9.,]/g, "")
    .replace(/(,|\.){2,}/g, "$1")
    .replace(/(,|\.)+/, (match) => match[0]);
  return Number(numericValue);
}
