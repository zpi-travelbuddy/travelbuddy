import { TripPointType } from "./Trip";

export type AttractionViewModel = {
  name: string;
  address: Address;
  attractionType: TripPointType;
  conveniences: string[]; // TODO: changing to special enum
  rating: number;
  averageCostPerPerson: number;
  averageVisitTime: number;
  latitude: number;
  longitude: number;
  imageUrl?: string;
};
