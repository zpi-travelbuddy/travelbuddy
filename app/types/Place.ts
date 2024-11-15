import { Condition, TripPointType } from "./Trip";

export type PlaceView = {
  id: string;
  title: string;
  subtitle: string;
  imageUrl?: string;
};

export interface PlaceCondition {
  id: string;
  name: string;
}

export interface PlaceCategory {
  id: string;
  name: string;
}

export interface PlaceSuperCategory {
  id: string;
  name: string;
}

export interface PlaceDetails {
  id: string;
  providerId: string;
  name: string;
  country: string;
  state: string;
  city: string;
  street: string;
  houseNumber: string;
  latitude: number;
  longitude: number;
  averageCostPerPerson: number;
  averageTimeSpent: string;
  averageRating: number;
  conditions: PlaceCondition[];
  categories: PlaceCategory[];
  superCategory: PlaceSuperCategory;
}

export interface PlaceViewModel {
  id: string;
  name: string;
  address: Address;
  attractionType: TripPointType;
  conditions: Condition[];
  rating: number;
  averageCostPerPerson: number;
  averageVisitTime: string;
  latitude: number;
  longitude: number;
  imageUrl?: string;
}
