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
  id: string;
  providerId: string;
  superCategoryId?: string;
  name: string;
  country?: string;
  state?: string;
  city: string;
  street?: string;
  houseNumber?: string;
  latitude?: number;
  longitude?: number;
}

export interface PlaceOverview {
  id?: string;
  providerId?: string;
  name: string;
  country?: string;
  state?: string;
  city?: string;
  street?: string;
  houseNumber?: string;
  superCategory: Category;
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
