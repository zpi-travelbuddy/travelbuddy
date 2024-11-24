export type ProfileType = "Category" | "Condition";

export interface Profile {
  id: string;
  name: string;
}

export interface CategoryProfile extends Profile {
  categories?: Category[];
}

export interface Category {
  id: string;
  name: string;
  subCategories: Category[];
}

export interface ConditionProfile extends Profile {
  conditions?: string[]; // to be updated;
}
