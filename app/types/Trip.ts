export interface TripDay {
  id: string;
  tripId: string;
  date: string;
}

export interface TripDetails {
  id: string;
  name: string;
  numberOfTravelers: number;
  startDate: string;
  endDate: string;
  destinationId: string;
  budget: number;
  currencyCode: string;
  categoryProfileId: string;
  conditionProfileId: string;
  tripDays: TripDay[];
}

export interface DateRange {
  startDate?: Date;
  endDate?: Date;
}

export interface TripCreationErrors {
  [key: string]: string | undefined;
}

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
