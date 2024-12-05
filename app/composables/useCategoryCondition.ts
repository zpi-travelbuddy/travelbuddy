/* eslint-disable @typescript-eslint/no-explicit-any */
import { useAuth } from "@/app/ctx";
import { API_CATEGORIES, API_CONDITIONS } from "@/constants/Endpoints";
import { Category, Condition } from "@/types/Profile";
import { useState, useCallback, useEffect } from "react";

export const useGetCategories = () => {
  const [categories, setCategories] = useState<Category[]>([]);
  const [loading, setLoading] = useState<boolean>(true);
  const [error, setError] = useState<string | null>(null);

  const { api } = useAuth();

  const fetchCategories = useCallback(async () => {
    try {
      setLoading(true);
      setError(null);

      const response = await api!.get<Category[]>(API_CATEGORIES);
      setCategories(response.data);
    } catch (err: any) {
      if (err.response && err.response.status === 404) {
        setError("Kategorie nie zostały znalezione.");
      } else {
        setError("Wystąpił błąd podczas pobierania danych kategorii.");
      }
    } finally {
      setLoading(false);
    }
  }, [api]);

  useEffect(() => {
    fetchCategories();
  }, [fetchCategories]);

  return { categories, loading, error, refetch: fetchCategories };
};

export const useGetConditions = () => {
  const [conditions, setConditions] = useState<Condition[]>([]);
  const [loading, setLoading] = useState<boolean>(true);
  const [error, setError] = useState<string | null>(null);

  const { api } = useAuth();

  const fetchConditions = useCallback(async () => {
    try {
      setLoading(true);
      setError(null);

      const response = await api!.get<Condition[]>(API_CONDITIONS);
      setConditions(response.data);
    } catch (err: any) {
      if (err.response && err.response.status === 404) {
        setError("Udogodnienia nie zostały znalezione.");
      } else {
        setError("Wystąpił błąd podczas pobierania danych udogodnień.");
      }
    } finally {
      setLoading(false);
    }
  }, [api]);

  useEffect(() => {
    fetchConditions();
  }, [fetchConditions]);

  return { conditions, loading, error, refetch: fetchConditions };
};
