import { Place } from "./Place";

export interface TripRequest {
  id?: string;
  name: string;
  numberOfTravelers: number;
  startDate: string;
  endDate: string;
  destinationPlace: Place;
  budget: number;
  currencyCode: string;
  categoryProfileId: string | null;
  conditionProfileId: string | null;
}

export interface APITrip {
  id: string;
  name: string;
  startDate: string;
  endDate: string;
}

export interface Trip {
  id: string;
  title: string;
  subtitle: string;
  from: string;
  to: string;
  imageUri: string;
  isArchived: boolean;
}

export interface TripDay {
  id: string;
  tripId: string;
  date: string;
}

export interface TripViewModel {
  name: string;
  dateRange: string;
  destination: string;
  numberOfTripPoints: number;
  numberOfTravelers: number;
  predictedCost: string;
  budget: string;
  categoryProfileName: string;
  conditionProfileName: string;
}

export interface TripResponse {
  id: string;
  name: string;
  numberOfTravelers: number;
  startDate: string;
  endDate: string;
  destinationId: string;
  budget: number;
  currencyCode: string;
  categoryProfileId: string | null;
  conditionProfileId: string | null;
  tripDays: TripDay[];
}

export interface TripSummaryPoint {
  name: string;
  predictedSpendings: number;
}

export interface TripSummaryDay {
  date: string;
  tripPoints: TripSummaryPoint[];
}

export interface TripSummary {
  currency: string;
  tripDays: TripSummaryDay[];
}

export interface DateRange {
  startDate?: Date;
  endDate?: Date;
}

export interface TripErrors {
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

export type Condition =
  | "internet_access"
  | "wheelchair"
  | "dogs"
  | "vegetarian"
  | "vegan";

export const ConditionList: Condition[] = [
  "internet_access",
  "wheelchair",
  "dogs",
  "vegetarian",
  "vegan",
];

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

export interface EditTripRequest {
  name: string;
  numberOfTravelers: number;
  startDate: string;
  endDate: string;
  destinationPlace: {
    providerId: string;
    name?: string;
    country?: string;
    city?: string;
    latitude?: number;
    longitude?: number;
  };
  budget: number;
  currencyCode: string;
}
