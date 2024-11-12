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
  signUp?: (credentials: Credentials) => Promise<any>;
  resendSignUp?: (credentials: Credentials) => Promise<any>;
  confirmSignUp?: (email: string, code: string) => Promise<any>;
  signIn?: (credentials: Credentials) => Promise<any>;
  signOut?: () => Promise<any>;
  api?: AxiosInstance;
}

export interface AuthErrors {
  email: string;
  password: string;
}
