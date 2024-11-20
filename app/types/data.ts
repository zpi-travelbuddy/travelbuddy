import { Place } from "./Place";

export interface TripPointCompact {
  id: string;
  name: string;
  startTime: string;
  endTime: string;
  latitude: number | null;
  longitude: number | null;
}

export interface CreateTripPointRequest {
  name: string;
  tripDayId: string;
  place: Place;
  predictedCost: number;
  startTime: string;
  endTime: string;
}

export interface TripDayResponse {
  id: string;
  tripId: string;
  date: string;
  transferPoints: APITransferPoint[];
  tripPoints: TripPointCompact[];
}

export enum TransferType {
  Car = 0,
  Motorbike = 1,
  Bicycle = 2,
  Walk = 3,
}

export interface APITransferPoint {
  id?: string;
  tripDayId: string;
  seconds?: number | null;
  startTime?: string | null;
  mode?: TransferType | null;
  type?: number;
  fromTripPointId: string;
  toTripPointId: string;
}

export interface TransferPoint {
  id: string;
  fromTripPointId: string;
  toTripPointId: string;
  mode: TransferType;
  duration: number; // in seconds0
}

export interface Option {
  icon: string;
  label: string;
  onPress: () => void;
  disabled?: boolean;
}

export const TransferTypeLabels = {
  [TransferType.Car]: "Samochód",
  [TransferType.Motorbike]: "Motocykl",
  [TransferType.Bicycle]: "Rower",
  [TransferType.Walk]: "Chód",
  null: "Ręcznie",
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
