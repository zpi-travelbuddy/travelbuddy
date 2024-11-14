export interface TripPoint {
  id: string;
  name: string;
  fromTime: string;
  toTime: string;
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
