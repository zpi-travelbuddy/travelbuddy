import { useAuth } from "@/app/ctx";
import {
  API_CATEGORY_PROFILES,
  API_CONDITION_PROFILES,
} from "@/constants/Endpoints";
import { CategoryProfile, ConditionProfile } from "@/types/Profile";
import { useState, useCallback, useEffect } from "react";

export const useGetCategoryProfiles = () => {
  const [profiles, setProfiles] = useState<CategoryProfile[]>([]);
  const [loading, setLoading] = useState<boolean>(true);
  const [error, setError] = useState<string | null>(null);

  const { api } = useAuth();

  const fetchCategoryProfiles = useCallback(async () => {
    try {
      setLoading(true);
      setError(null);

      const response = await api!.get<CategoryProfile[]>(API_CATEGORY_PROFILES);
      setProfiles(response.data);
    } catch (err: any) {
      if (err.response && err.response.status === 404) {
        setError("Profile nie zostały znalezione.");
      } else {
        setError("Wystąpił błąd podczas pobierania danych profili.");
      }
    } finally {
      setLoading(false);
    }
  }, [api]);

  useEffect(() => {
    fetchCategoryProfiles();
  }, [fetchCategoryProfiles]);

  return { profiles, loading, error, refetch: fetchCategoryProfiles };
};

export const useGetConditionProfiles = () => {
  const [profiles, setProfiles] = useState<ConditionProfile[]>([]);
  const [loading, setLoading] = useState<boolean>(true);
  const [error, setError] = useState<string | null>(null);

  const { api } = useAuth();

  const fetchConditionProfiles = useCallback(async () => {
    try {
      setLoading(true);
      setError(null);

      const response = await api!.get<ConditionProfile[]>(
        API_CONDITION_PROFILES,
      );
      setProfiles(response.data);
    } catch (err: any) {
      if (err.response && err.response.status === 404) {
        setError("Profile nie zostały znalezione.");
      } else {
        setError("Wystąpił błąd podczas pobierania danych profili.");
      }
    } finally {
      setLoading(false);
    }
  }, [api]);

  useEffect(() => {
    fetchConditionProfiles();
  }, [fetchConditionProfiles]);

  return { profiles, loading, error, refetch: fetchConditionProfiles };
};
