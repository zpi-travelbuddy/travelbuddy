export type ProfileType = "Category" | "Condition";

export interface Profile {
  id: string;
  name: string;
}

export interface CategoryProfile extends Profile {
  categories?: Category[];
}

export interface Category {
  id: string;
  name: string;
  subCategories: Category[];
}

export interface ConditionProfile extends Profile {
  conditions?: Condition[];
}

export interface ProfileRequest {
  name: string;
  profileType: ProfileType;
  conditionIds?: string[];
  categoryIds?: string[];
}
export interface EditProfileRequest extends ProfileRequest {
  id: string;
}

export interface ProfileDetails {
  id: string;
  name: string;
  categories?: Category[];
  conditions?: Condition[];
}

export interface FavouriteProfileRequest {
  id: string;
  profileType: ProfileType;
}

export interface Condition {
  id: string;
  name: string;
  subConditions: Condition;
}

export const CONDITION_NAME_LIST = [
  "internet_access",
  "kosher",
  "egg_free",
  "sugar_free",
  "vegetarian",
  "organic",
  "vegan",
  "dogs",
  "soy_free",
  "no-dogs",
  "halal",
  "gluten_free",
  "no_fee",
  "wheelchair",
];

export const CATEGORY_NAME_LIST: string[] = [
  "activity",
  "commercial",
  "entertainment",
  "heritage",
  "leisure",
  "natural",
  "national park",
  "tourism",
  "religion",
  "sport",
  "catering",
];

export const CategoryLabelsForProfiles: Record<string, string> = {
  activity: "Rozrywka",
  commercial: "Sklepy",
  entertainment: "Kultura",
  heritage: "Zabytki",
  leisure: "Natura",
  natural: "Natura",
  "national park": "Parki narodowe",
  tourism: "Atrakcje",
  religion: "Miejsca kultu",
  sport: "Sport",
  catering: "Restauracje",
};

export const ConditionLabels: Record<string, string> = {
  dogs: "Psy dozwolone",
  "no-dogs": "Psy niedozwolone",
  egg_free: "Bez jajek",
  gluten_free: "Bez glutenu",
  halal: "Halal",
  internet_access: "Dostęp do internetu",
  kosher: "Koszerne",
  no_dogs: "Bez psów",
  no_fee: "Bez opłat",
  organic: "Ekologiczne",
  soy_free: "Bez soi",
  sugar_free: "Bez cukru",
  vegetarian: "Wegetariańskie",
  vegan: "Wegańskie",
  wheelchair: "Dostępne dla wózków",
};

export const OTHER_CATEGORY_NAME = "other";
export const DEFAULT_CATEGORY_NAME = "tourism";
