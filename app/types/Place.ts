export interface Place {
  id?: string;
  providerId?: string;
  categoryId?: string;
  name?: string;
  country?: string;
  state?: string;
  city?: string;
  street?: string;
  houseNumber?: string;
  latitude?: number;
  longitude?: number;
}

export interface PlaceCondition {
  id: string;
  name: string;
}

export interface PlaceCategory {
  id: string;
  name: string;
}

export interface PlaceSuperCategory {
  id: string;
  name: string;
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
  conditions: PlaceCondition[];
  categories: PlaceCategory[];
  superCategory: PlaceSuperCategory;
}
