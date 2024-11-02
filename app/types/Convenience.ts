import {
  DOG_ICON,
  HUMAN_DISABLE_ICON,
  VEGAN_ICON,
  VEGE_ICON,
} from "@/constants/Icons";

export type ConvenienceType =
  | "dog_allowed"
  | "adapted_for_disabled_people"
  | "vegan"
  | "vegetarian";

export const ConevienceIcons: Record<ConvenienceType, string> = {
  dog_allowed: DOG_ICON,
  adapted_for_disabled_people: HUMAN_DISABLE_ICON,
  vegan: VEGAN_ICON,
  vegetarian: VEGE_ICON,
};
