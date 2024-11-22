import { Place, PlaceDetails } from "@/types/Place";

export function formatAddress(place: PlaceDetails): string {
  if (!place) return "";
  return `${place.city}, ${place.country}`;
}

export function displayCost(number: number): string {
  if (number === 0) return "Darmowe";
  else if (number > 0) return number.toFixed(2);
  else return "Brak informacji";
  // else throw new Error("Cost cannot be negative number");
}

export const truncateText = (text: string = "", maxLength: number) => {
  if (!text) return "";
  return text.length > maxLength ? `${text.slice(0, maxLength)}...` : text;
};

export const displayTime = (time: string) => {
  if (time) return time;
  else return "Brak informacji";
};

export const getDisplayPlace = (place: Place | null) => {
  if (place) return `${place.city}, ${place.country}`;
  else return "";
};
