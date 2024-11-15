type Trip = {
  name: string;
  dateFrom: Date;
  dateTo: Date;
};

export type TripPointType =
  | "attraction"
  | "food"
  | "culture"
  | "museum"
  | "shop"
  | "park"
  | "religion"
  | "music"
  | "other";

export type Condition =
  | "internet_access"
  | "wheelchair"
  | "dogs"
  | "vegetarian"
  | "vegan";

export const AttractionTypeIcons: Record<TripPointType, string> = {
  attraction: "camera",
  food: "silverware-fork-knife",
  culture: "drama-masks",
  museum: "bank",
  shop: "basket",
  park: "pine-tree",
  religion: "church",
  music: "music-note",
  other: "map-marker",
};

export const AttractionTypeLabels: Record<TripPointType, string> = {
  attraction: "Atrakcja",
  food: "Jedzenie",
  culture: "Kultura",
  museum: "Muzeum",
  shop: "Sklep",
  park: "Park",
  religion: "Kult",
  music: "Muzyka",
  other: "Inne",
};
