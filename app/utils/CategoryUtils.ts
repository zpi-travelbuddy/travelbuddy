import { PlaceDetails } from "@/types/Place";
import { CATEGORY_NAME_LIST, DEFAULT_CATEGORY_NAME } from "@/types/Profile";

export const findAttractionCategory = (placeDetails: PlaceDetails) => {
  if (placeDetails.superCategory) return placeDetails.superCategory.name;

  const category = placeDetails.categories.find((category) =>
    CATEGORY_NAME_LIST.includes(category.name),
  );
  return category?.name ?? DEFAULT_CATEGORY_NAME;
};
