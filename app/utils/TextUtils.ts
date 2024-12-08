import { Place, PlaceDetails, PlaceOverview } from "@/types/Place";

export function formatAddress(
  place: PlaceDetails | Place | PlaceOverview,
  compact: boolean = true,
): string {
  if (!place) return "";

  let addressLine = "";
  let cityLine = "";

  if (!compact && place.street) {
    addressLine =
      place.street + (place.houseNumber ? ` ${place.houseNumber}` : "") + "\n";
  }

  if (place.city) {
    cityLine = [place.city, place.state, place.country]
      .filter(Boolean)
      .join(", ");
  }

  return addressLine + cityLine;
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
