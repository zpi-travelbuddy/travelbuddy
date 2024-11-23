import { Place } from "./Place";

export interface TripPointCompact {
  id: string;
  name: string;
  tripDayId: string;
  startTime: string;
  endTime: string;
  latitude?: number;
  longitude?: number;
}

export interface CreateTripPointRequest {
  name: string;
  comment?: string;
  tripDayId: string;
  place: Place;
  predictedCost: number;
  startTime: string;
  endTime: string;
}

export interface Category {
  id: string;
  name: string;
}

export interface Review {
  id: string;
  tripPointId: string;
  placeId: string;
  placeName: string;
  rating: number;
}

export interface TripPointDetails {
  id: string;
  name: string;
  comment: string;
  tripDayId: string;
  predictedCost: number;
  predictedCostPerPerson?: number;
  currencyCode: string;
  startTime: string;
  endTime: string;
  openingTime?: string;
  closingTime?: string;
  status?: number;
  placeId: string;
  place?: Place;
  review?: Review;
  category?: Category;
}

export interface TripDayDetails {
  id: string;
  tripId: string;
  date: string;
  transferPoints: TransferPoint[];
  tripPoints: TripPointCompact[];
}

export interface TransferPoint {
  id: string;
  tripDayId: string;
  seconds?: number;
  mode?: TransferType;
  fromTripPointId: string;
  toTripPointId: string;
}

export interface CreateTransferPointRequest {
  tripDayId: string;
  seconds: number;
  mode: TransferType;
  fromTripPointId: string;
  toTripPointId: string;
}

export interface Option {
  icon: string;
  label: string;
  onPress: () => void;
  disabled?: boolean;
  isDelete?: boolean;
}

export enum TransferType {
  Car = 0,
  Motorbike = 1,
  Bicycle = 2,
  Walk = 3,
}

export const TransferTypeLabels = {
  [TransferType.Car]: "Samochód",
  [TransferType.Motorbike]: "Motocykl",
  [TransferType.Bicycle]: "Rower",
  [TransferType.Walk]: "Chód",
  null: "Ręcznie",
};

// export const reversedTransferTypeLabels = Object.fromEntries(
//   Object.entries(TransferTypeLabels).map(([key, value]) => [value, key]),
// ) as Record<string, TransferType>;
