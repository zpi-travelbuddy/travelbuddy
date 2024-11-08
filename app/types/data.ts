export interface TripPoint {
  id: string;
  name: string;
  fromTime: string;
  toTime: string;
}

export type TransferType = "walk" | "bus" | "car" | "manual";

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
