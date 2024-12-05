import { Category, Condition } from "./Profile";

export interface PlaceCompact {
  id: string;
  providerId?: string;
  name: string;
  country: string;
  state?: string;
  city: string;
}

export interface PlaceViewModel {
  providerId: string;
  id: string;
  title?: string;
  subtitle?: string;
  imageUrl?: string;
}
export interface Place {
  providerId: string;
  categoryId?: string;
  name: string;
  country: string;
  state?: string;
  city: string;
  street?: string;
  houseNumber?: string;
  latitude?: number;
  longitude?: number;
}

export interface PlaceDetails {
  id: string;
  providerId: string;
  name: string;
  country: string;
  state: string;
  city: string;
  street: string;
  houseNumber: string;
  latitude: number;
  longitude: number;
  averageCostPerPerson: number;
  averageTimeSpent: string;
  averageRating: number;
  conditions: Condition[];
  categories: Category[];
  superCategory: Category;
}
