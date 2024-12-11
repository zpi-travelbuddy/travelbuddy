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
  isArchived: boolean;
}

export interface TripViewModel {
  name: string;
  dateRange: string;
  destination: string;
  numberOfTripPoints: number;
  numberOfTravelers: number;
  predictedCost: string;
  actualCost: string;
  budget: string;
  categoryProfileName: string;
  conditionProfileName: string;
}

export interface CreateTripRequest {
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

export interface TripRequest extends CreateTripRequest {
  id: string;
}

export interface TripDetails extends TripRequest {
  destinationId: string;
  predictedCost: number;
  actualCost: number;
  tripDays: TripDay[];
  isArchived?: boolean;
}

export interface TripSummaryPoint {
  name: string;
  totalSpendings: number;
}

export interface TripSummaryDay {
  date: string;
  tripPoints: TripSummaryPoint[];
}

export interface TripSummary {
  currencyCode: string;
  tripDays: TripSummaryDay[];
}

export interface DateRange {
  startDate?: Date;
  endDate?: Date;
}

export interface TripErrors {
  [key: string]: string | undefined;
}
