export type ProfileType = "Category" | "Condition";

export interface Profile {
  id: string;
  name: string;
}

export interface CategoryProfile extends Profile {
  categories?: string[]; // to be updated;
}

export interface ConditionProfile extends Profile {
  conditions?: string[]; // to be updated;
}
