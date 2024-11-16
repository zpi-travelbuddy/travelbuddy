import { Place } from "./Place";

export interface TripPoint {
  id: string;
  name: string;
  fromTime: string;
  toTime: string;
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

// export interface TripPointResponse {
//   name: string;
//   tripDayId: string;
//   place: Place;
//   predictedCost: number;
//   startTime: string;
//   endTime: string;
// }

export interface Review {
  id: string;
  tripPointId: string;
  placeId: string;
  placeName: string;
  rating: number;
}

export interface Category {
  id: string;
  name: string;
}

export interface TripPointResponse {
  id: string;
  name: string;
  comment: string;
  tripDayId: string;
  predictedCost: number;
  predictedCostPerPerson: number;
  currencyCode: string;
  startTime: string;
  endTime: string;
  openingTime: string;
  closingTime: string;
  status: number;
  placeId: string;
  place: Place;
  review: Review;
  category: Category;
}

export type TransferType =
  | "walk"
  | "bus"
  | "car"
  | "train"
  | "manual"
  | "empty";

export interface TransferPoint {
  id: string;
  fromTripPointId: string;
  toTripPointId: string;
  type: TransferType;
  duration: number;
}

export interface Option {
  icon: string;
  label: string;
  onPress: () => void;
}

export const TransferTypeLabels: Record<string, string> = {
  walk: "Chód",
  bus: "Autobus",
  train: "Pociąg",
  car: "Samochód",
  manual: "Ręcznie",
};

export const reversedTransferTypeLabels = Object.entries(
  TransferTypeLabels,
).reduce(
  (acc, [key, value]) => {
    acc[value] = key;
    return acc;
  },
  {} as Record<string, string>,
);
