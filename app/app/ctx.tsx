import { createContext, useContext, useState } from "react";
import { AuthProps, AuthState, Credentials } from "@/types/auth";

const AuthContext = createContext<AuthProps>({});

export const useAuth = () => {
  return useContext(AuthContext);
};

export const AuthProvider = ({ children }: any) => {
  const [authState, setAuthState] = useState<AuthState>({
    token: null,
    authenticated: null,
  });

  // TODO: Write onRegister logic
  const onRegister = async (credentials: Credentials) => {};

  // TODO: Write onLogin logic
  const onLogin = async (credentials: Credentials) => {
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
