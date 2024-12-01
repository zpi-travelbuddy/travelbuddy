export interface ReviewRequest {
  tripPointId: string;
  placeId: string;
  actualCost?: number;
  currencyCode?: string;
  actualTimeSpent?: number;
  rating?: number;
}
