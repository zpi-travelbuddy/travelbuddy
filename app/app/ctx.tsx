import { createContext, useContext, useEffect, useState } from "react";
import { AuthProps, Credentials } from "@/types/auth";
import { Amplify, Auth } from "aws-amplify";
import { amplifyConfig } from "@/config/amplifyConfig";
import axios from "axios";

Amplify.configure(amplifyConfig);

// axios
const api = axios.create({
  baseURL: process.env.EXPO_PUBLIC_API_URL,
});

// cache
let cachedAccessToken: string | null = null;
let tokenExpiration: number = 0;

const AuthContext = createContext<AuthProps>({});

export const useAuth = () => {
  return useContext(AuthContext);
};

export const AuthProvider = ({ children }: any) => {
  const [isLoading, setIsLoading] = useState<boolean>(false);
  const [isAuthenticated, setIsAuthenticated] = useState<boolean>(false);

  const signIn = async (credentials: Credentials) => {
    const { email, password } = credentials;
    try {
      const response = await Auth.signIn({
        username: email,
        password,
      });
      setIsAuthenticated(true);
      return response;
    } catch (error) {
      console.error("Sign in error:", error);
      throw error;
    }
  };

  const signOut = async () => {
    try {
      const response = await Auth.signOut();
      cachedAccessToken = null;
      setIsAuthenticated(false);
      return response;
    } catch (error) {
      console.error("Sign out error:", error);
      throw error;
    }
  };

  const getAccessToken = async () => {
    const bufferTime = 5 * 60 * 1000; // Refresh 5 minutes before expiration

    if (cachedAccessToken && Date.now() < tokenExpiration - bufferTime) {
      setIsAuthenticated(true);
      return cachedAccessToken;
    }

    try {
      const session = await Auth.currentSession();
      cachedAccessToken = session.getAccessToken().getJwtToken();
      tokenExpiration = session.getAccessToken().getExpiration() * 1000;
      setIsAuthenticated(true);
      return cachedAccessToken;
    } catch (error) {
      cachedAccessToken = null;
      setIsAuthenticated(false);
      return null;
    }
  };

  useEffect(() => {
    const initializeAuth = async () => {
      setIsLoading(true);
      try {
        const fetchedToken = await getAccessToken();
        if (fetchedToken) {
          setIsAuthenticated(true);
        } else {
          setIsAuthenticated(false);
        }
      } catch (error) {
        console.error("Auth initialization error:", error);
        setIsAuthenticated(false);
      } finally {
        setIsLoading(false);
      }
    };
    // check if user is authenticated
    initializeAuth();

    // set up axios
    api.interceptors.request.use(
      async (config) => {
        try {
          const token = await getAccessToken();
          console.log("Token found, appending to headers");
          if (token) {
            config.headers.Authorization = `Bearer ${token}`;
          }
        } catch (error) {
          console.warn("Token not found:", error);
        }
        return config;
      },
      (error) => {
        console.error("Axios request error:", error);
        return Promise.reject(error);
      },
    );
  }, []);

  const value = { isLoading, isAuthenticated, signIn, signOut, api };

  return <AuthContext.Provider value={value}>{children}</AuthContext.Provider>;
};
