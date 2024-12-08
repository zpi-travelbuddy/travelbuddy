import { TransferType } from "@/types/TripDayData";

// For Google Maps travel mode
export const TRANSFER_TYPE_MAP_GOOGLE = {
  [TransferType.Car]: "driving",
  [TransferType.Motorbike]: "driving",
  [TransferType.Bicycle]: "bicycling",
  [TransferType.Walk]: "walking",
  null: "driving",
};
