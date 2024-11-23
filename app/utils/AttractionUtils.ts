import { PlaceDetails, PlaceCategory } from "@/types/Place";
import { TripPointType } from "@/types/Trip";

const map: Record<string, TripPointType> = {
  activity: "culture",
  commercial: "shop",
  enterainment: "culture",
  heritage: "culture",
  leisure: "park",
  natural: "park",
  national_park: "park",
  religion: "religion",
  sport: "other",
  catering: "food",
};

export const getAttractionType = (place: PlaceDetails): TripPointType => {
  return (
    place.categories
      .map((category) => map[category.name])
      .find((tripPointType) => tripPointType !== undefined) || "other"
  );
};
