export function formatAddress(address: Address | undefined): string {
  if (!address) return "";
  return `${address.city}, ${address.country}`;
}

export function displayCost(number: number): string {
  if (number === 0) return "Darmowe";
  else if (number > 0) return number.toFixed(2);
  else return "Brak informacji";
  // else throw new Error("Cost cannot be negative number");
}

export const truncateText = (text: string, maxLength: number) => {
  return text.length > maxLength ? `${text.slice(0, maxLength)}...` : text;
};

export const displayTime = (time: string) => {
  if (time) return time;
  else return "Brak informacji";
};
