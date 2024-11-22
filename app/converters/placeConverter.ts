import { PlaceCondition, PlaceDetails } from "@/types/Place";
import { Condition, ConditionList, TripPointType } from "@/types/Trip";
import { getConditions } from "@/utils/ConditionsUtils";

export const convertToPlaceViewModel = (place: PlaceDetails) => {
  const result = {
    id: place.id,
    name: place.name,
    address: getAddress(place),
    attractionType: getAttractionType(place),
    conditions: getConditions(place),
    rating: place.averageRating,
    averageCostPerPerson: place.averageCostPerPerson,
    averageVisitTime: place.averageTimeSpent,
    latitude: place.latitude,
    longitude: place.longitude,
    imageUrl:
      "https://upload.wikimedia.org/wikipedia/commons/1/1a/Big_Ben..JPG",
  };

  return result;
};

const getAddress = (place: PlaceDetails) => {
  return {
    street: place.street,
    number: place.houseNumber,
    city: place.city,
    country: place.country,
  };
};

const getAttractionType = (place: PlaceDetails) => {
  console.log(place.categories);
  return "other" as TripPointType;
};

const ConditionIconMap: Partial<Record<Condition, string>> = {
  wheelchair: "human-wheelchair",
  internet_access: "wifi",
  dogs: "dog-side",
  vegetarian: "food-drumstick-off",
  vegan: "leaf",
  "no-dogs": "dog-side-off",
  halal: "food-halal",
  kosher: "food-kosher",
  organic: "bio",
  egg_free: "egg-off-outline",
};

export const convertConditions = (
  placeConditions?: PlaceCondition[],
): string[] => {
  if (!placeConditions) return [];

  return placeConditions
    .map((condition) => condition.name)
    .filter((name): name is Condition =>
      ConditionList.includes(name as Condition),
    )
    .map((conditionName) => ConditionIconMap[conditionName as Condition] || "");
};
