export interface Credentials {
  email: string;
  password: string;
}

export interface AuthErrors {
  email: string;
  password: string;
}

export interface AuthState {
  token: string | null;
  authenticated: boolean | null;
}

export interface AuthProps {
  onRegister?: (credentials: Credentials) => Promise<void>;
  onLogin?: (credentials: Credentials) => Promise<void>;
  onLogout?: () => Promise<void>;
  authState?: AuthState;
}
