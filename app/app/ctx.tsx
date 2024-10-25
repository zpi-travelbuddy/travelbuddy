import { createContext, useContext, useEffect, useState } from "react";

interface AuthProps {
  authState?: { token: string | null; authenticated: boolean | null };
  onRegister?: (email: string, password: string) => Promise<any>;
  onLogin?: (email: string, password: string) => Promise<any>;
  onLogout?: () => Promise<any>;
}

const AuthContext = createContext<AuthProps>({});

export const useAuth = () => {
  return useContext(AuthContext);
};

export const AuthProvider = ({ children }: any) => {
  const [authState, setAuthState] = useState<{
    token: string | null;
    authenticated: boolean | null;
  }>({
    token: null,
    authenticated: null,
  });

  // TODO: Write onRegister logic
  const onRegister = async (email: string, password: string) => {};

  // TODO: Write onLogin logic
  const onLogin = async (email: string, password: string) => {
    setAuthState({
      token: "PLACEHOLDER_TOKEN",
      authenticated: true,
    });
  };

  // TODO: Write onLogout logic
  const onLogout = async () => {
    setAuthState({
      token: null,
      authenticated: false,
    });
  };

  const value = { onRegister, onLogin, onLogout, authState };

  return <AuthContext.Provider value={value}>{children}</AuthContext.Provider>;
};
