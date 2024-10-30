type Trip = {
  name: string;
  dateFrom: Date;
  dateTo: Date;
};

type TripPointType =
  | "attraction"
  | "food"
  | "culture"
  | "museum"
  | "shop"
  | "park"
  | "religion"
  | "music"
  | "other";
