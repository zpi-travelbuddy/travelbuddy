import { AxiosInstance } from "axios";

export enum FieldType {
  EMAIL = "email",
  PASSWORD = "password",
}

export interface Credentials {
  email: string;
  password: string;
}

export interface AuthProps {
  isLoading?: boolean;
  isAuthenticated?: boolean;
  signIn?: (credentials: Credentials) => Promise<any>;
  signOut?: () => Promise<any>;
  api?: AxiosInstance;
}

export interface AuthErrors {
  email: string;
  password: string;
}
