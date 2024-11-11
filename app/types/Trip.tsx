export type Trip = {
  name: string;
  dateFrom: Date;
  dateTo: Date;
};

export interface DateRange {
  startDate?: Date;
  endDate?: Date;
}

export interface TripCreationErrors {
  [key: string]: string | undefined;
}
