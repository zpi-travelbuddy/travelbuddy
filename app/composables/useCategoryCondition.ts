/* eslint-disable @typescript-eslint/no-explicit-any */
import { useAuth } from "@/app/ctx";
import { API_CATEGORIES, API_CONDITIONS } from "@/constants/Endpoints";
import { Category, Condition, ProfileType } from "@/types/Profile";
import { useState, useCallback, useEffect } from "react";

const errorMessages: Record<ProfileType, Record<string, string>> = {
  Category: {
    NotFound: "Preferencje nie zostały znalezione.",
    Error: "Wystąpił błąd podczas pobierania danych preferencji.",
  },
  Condition: {
    NotFound: "Udogodnienia nie zostały znalezione.",
    Error: "Wystąpił błąd podczas pobierania danych udogodnień.",
  },
};

export const useGetItems = <T>(profileType: ProfileType) => {
  const [items, setItems] = useState<T[]>([]);
  const [loading, setLoading] = useState<boolean>(true);
  const [error, setError] = useState<string | null>(null);

  const { api } = useAuth();

  const fetchItems = useCallback(async () => {
    try {
      setLoading(true);
      setError(null);
      const endpoint =
        profileType === "Category" ? API_CATEGORIES : API_CONDITIONS;

      const response = await api!.get<T[]>(endpoint);
      setItems(response.data);
    } catch (err: any) {
      if (err.response && err.response.status === 404) {
        setError(errorMessages[profileType]["NotFound"]);
      } else {
        setError(errorMessages[profileType]["Error"]);
      }
    } finally {
      setLoading(false);
    }
  }, [api]);

  useEffect(() => {
    fetchItems();
  }, [fetchItems]);

  return { items, loading, error, refetch: fetchItems };
};

export const useGetCategories = () => {
  return useGetItems<Category>("Category");
};

export const useGetConditions = () => {
  return useGetItems<Condition>("Condition");
};
