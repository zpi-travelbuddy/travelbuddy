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
}

export interface ConditionProfile extends Profile {
  conditions?: Condition[];
}

export interface Condition {
  id: string;
  name: string;
}

export const CONDITION_NAME_LIST = [
  "internet_access",
  "kosher",
  "egg_free",
  "sugar_free",
  "vegetarian",
  "access",
  "organic",
  "vegan",
  "dogs",
  "soy_free",
  "no-dogs",
  "halal",
  "gluten_free",
  "no_fee",
  "fee",
  "access_limited",
  "named",
  "wheelchair",
];

// export const CONDITION_LIST: Condition[] = [
//   {
//     id: "3b92f090-098c-4538-9ddd-204bffc5e44e",
//     name: "internet_access",
//   },
//   {
//     id: "7706dfd1-e9ce-4214-99b3-2fee4fc51003",
//     name: "kosher",
//   },
//   {
//     id: "9385a302-4fbd-4b26-99d8-3abeaa503177",
//     name: "egg_free",
//   },
//   {
//     id: "e1befcf0-6e2b-4caf-9876-45a8b2c26c1d",
//     name: "sugar_free",
//   },
//   {
//     id: "15c7e04a-722f-4cf3-bbd9-4ca75668d4cf",
//     name: "vegetarian",
//   },
//   {
//     id: "5fe767cd-379a-4749-9fae-660ac179d0a8",
//     name: "access",
//   },
//   {
//     id: "17b35de2-6c0e-4b2c-b10e-79d88ae6a3cd",
//     name: "organic",
//   },
//   {
//     id: "307b93ee-fe43-4036-ac59-81def692efd6",
//     name: "vegan",
//   },
//   {
//     id: "001c0229-da10-4d73-8771-85a0e0576cd5",
//     name: "dogs",
//   },
//   {
//     id: "496dd4fe-1d75-4ef6-bcdf-a388cbc97762",
//     name: "soy_free",
//   },
//   {
//     id: "187d1349-7600-46cf-9649-a7777f0d2774",
//     name: "no-dogs",
//   },
//   {
//     id: "a280fb78-a6e9-426f-a38c-b10f2d4111ca",
//     name: "halal",
//   },
//   {
//     id: "67efb514-c4f9-4da0-8d47-bdee37851157",
//     name: "gluten_free",
//   },
//   {
//     id: "5f6ecfa1-5e4f-45ce-88a0-bee75f0c0cd6",
//     name: "no_fee",
//   },
//   {
//     id: "81399a72-93a9-49ba-bbb5-c58a6caf298a",
//     name: "fee",
//   },
//   {
//     id: "24c5555a-4e95-45e9-bf34-dc48c7ab9939",
//     name: "access_limited",
//   },
//   {
//     id: "967944e4-83e6-441e-86d4-dd1a46872488",
//     name: "named",
//   },
//   {
//     id: "ff87a791-7b77-4e82-8fef-f07b22389963",
//     name: "wheelchair",
//   },
// ];

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
// export const CATEGORY_LIST: Category[] = [
//   {
//     id: "6a5b1b6d-a6f7-41fb-8277-00756aba33bb",
//     name: "activity",
//   },
//   {
//     id: "7c938f9f-4edb-427c-9820-d35cf87d029d",
//     name: "commercial",
//   },
//   {
//     id: "b313ba91-7573-434e-9b17-3afb7f14d2ac",
//     name: "entertainment",
//   },
//   {
//     id: "e1198615-570f-4b90-b9fc-5dbf87925416",
//     name: "heritage",
//   },
//   {
//     id: "077b8a92-baf0-4a35-894e-ea3942cb5412",
//     name: "leisure",
//   },
//   {
//     id: "4b94397a-d6d8-4811-9c00-5b1392618373",
//     name: "natural",
//   },
//   {
//     id: "d0ee8558-9c05-4bf8-a0a3-ad304a3762d3",
//     name: "national_park",
//   },
//   {
//     id: "5021f3f6-7922-4bc2-85a9-a0df2b49d1a9",
//     name: "tourism",
//   },
//   {
//     id: "ee552c9a-2a04-4618-9480-9da2e0652f23",
//     name: "religion",
//   },
//   {
//     id: "3a1a34f2-c8b6-4950-96ad-0c513a972ee9",
//     name: "sport",
//   },
//   {
//     id: "912c5bf7-21e7-4b63-a599-58ed6e860967",
//     name: "catering",
//   },
// ];

export const CategoryIcons: Record<string, string> = {
  activity: "party-popper",
  commercial: "basket",
  entertainment: "drama-masks",
  heritage: "bank",
  leisure: "pine-tree",
  natural: "pine-tree",
  national_park: "pine-tree",
  tourism: "camera",
  religion: "church",
  sport: "soccer",
  catering: "silverware-fork-knife",
  other: "map-marker",
};

export const CategoryLabels: Record<string, string> = {
  activity: "Rozrywka",
  commercial: "Sklep",
  entertainment: "Kultura",
  heritage: "Zabytek",
  leisure: "Natura",
  natural: "Natura",
  national_park: "Natura",
  tourism: "Atrakcja",
  religion: "Kult",
  sport: "Sport",
  catering: "Jedzenie",
  other: "Inne",
};

export const OTHER_CATEGORY_NAME = "other";
export const DEFAULT_CATEGORY_NAME = "tourism";

// export const getCategoryByName = (name: string): Category | undefined => {
//   return CATEGORY_LIST.find((category) => category.name === name);
// };

// const categoryNameToIdMap = new Map(
//   CATEGORY_LIST.map((category) => [category.name, category.id]),
// );
// const categoryIdToNameMap = new Map(
//   CATEGORY_LIST.map((category) => [category.id, category.name]),
// );

// export const getCategoryNames = (): string[] => {
//   return CATEGORY_LIST.map((category) => category.name);
// };

// export const getCategoryIdByName = (name: string): string => {
//   return categoryNameToIdMap.get(name) ?? OTHER_CATEGORY.id;
// };

// export const getCategoryNameById = (id: string): string => {
//   return categoryIdToNameMap.get(id) ?? OTHER_CATEGORY.name;
// };
