import { PlaceDetails } from "@/types/Place";
import { Condition } from "@/types/Trip";

const conditionsMap: Record<string, Condition> = {
  internet_access: "internet_access",
  wheelchair: "wheelchair",
  dogs: "dogs",
  vegetarian: "vegetarian",
  vegan: "vegan",
};

export const getConditions = (place: PlaceDetails): Condition[] => {
  return (place.conditions || [])
    .map((condition) => conditionsMap[condition.name])
    .filter((condition): condition is Condition => condition !== undefined);
};
