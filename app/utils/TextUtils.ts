export function formatAddress(address: Address): string {
  return `${address.city}, ${address.country}`;
}

export function displayCost(number: number): string {
  if (number === 0) return "Darmowe";
  else if (number > 0) return number.toFixed(2);
  else throw new Error("Cost cannot be negative number");
}
