export interface APIDestination {
  city: string;
  country: string;
  id: string | null;
  name: string | null;
  providerId: string;
  state: string;
}

export interface Destination {
  id: string;
  name: string;
  country: string;
}
