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
  conditions?: Condition[];
}

export interface Condition {
  id: string;
  name: string;
  subConditions: Condition[];
}

export interface CreateProfileRequest {
  name: string;
  profileType: ProfileType;
  conditionIds?: string[];
  categoryIds?: string[];
}

export interface ProfileDetails {
  id: string;
  name: string;
  categories?: Category[];
  conditions?: Condition[];
}
