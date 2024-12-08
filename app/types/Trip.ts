export interface TripDay {
  id: string;
  tripId: string;
  date: string;
}

export interface TripCompact {
  id: string;
  name: string;
  startDate: string;
  endDate: string;
  isArchived: boolean; // these 2 are not included in API data
  imageUri?: string;
}

export interface TripViewModel {
  name: string;
  dateRange: string;
  destination: string;
  numberOfTripPoints: number;
  numberOfTravelers: number;
  predictedCost: string;
  budget: string;
  categoryProfileName: string;
  conditionProfileName: string;
}

export interface TripRequest {
  id: string;
  name: string;
  numberOfTravelers: number;
  startDate: string;
  endDate: string;
  destinationProviderId: string;
  budget: number;
  currencyCode: string;
  categoryProfileId?: string | null;
  conditionProfileId?: string | null;
}

export interface TripDetails extends TripRequest {
  destinationId: string;
  tripDays: TripDay[];
  isArchived?: boolean;
}

export interface TripSummaryPoint {
  name: string;
  predictedSpendings: number;
}

export interface TripSummaryDay {
  date: string;
  tripPoints: TripSummaryPoint[];
}

export interface TripSummary {
  currency: string;
  tripDays: TripSummaryDay[];
}

export interface DateRange {
  startDate?: Date;
  endDate?: Date;
}

export interface TripErrors {
  [key: string]: string | undefined;
}
