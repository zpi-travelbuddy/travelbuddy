/* eslint-disable @typescript-eslint/no-explicit-any */
import { useAuth } from "@/app/ctx";
import {
  API_CATEGORY_PROFILES,
  API_CONDITION_PROFILES,
  API_FAVOURITE_PROFILES,
} from "@/constants/Endpoints";
import {
  CategoryProfile,
  ConditionProfile,
  EditProfileRequest,
  Profile,
  ProfileType,
} from "@/types/Profile";
import { useState, useCallback, useEffect } from "react";
import { UseApiOptions } from "./useTripDetails";

interface UseGetProfilesResult<T> {
  profiles: T[];
  loading: boolean;
  error: string | null;
  refetch: () => Promise<void>;
}
export const useGetProfiles = <T>(
  endpoint: string,
  options: UseApiOptions = { immediate: true },
  notFoundMessage: string = "Profile nie zostały znalezione.",
  generalErrorMessage: string = "Wystąpił błąd podczas pobierania danych profili.",
): UseGetProfilesResult<T> => {
  const [profiles, setProfiles] = useState<T[]>([]);
  const [loading, setLoading] = useState<boolean>(true);
  const [error, setError] = useState<string | null>(null);

  const { api } = useAuth();

  const fetchProfiles = useCallback(async () => {
    try {
      setLoading(true);
      setError(null);

      const response = await api!.get<T[]>(endpoint);
      setProfiles(response.data);
    } catch (err: any) {
      if (err.response && err.response.status === 404) {
        setError(notFoundMessage);
        setProfiles([]);
      } else {
        setError(generalErrorMessage);
      }
    } finally {
      setLoading(false);
    }
  }, [api, endpoint, notFoundMessage, generalErrorMessage]);

  useEffect(() => {
    if (options.immediate) fetchProfiles();
  }, [fetchProfiles]);

  return { profiles, loading, error, refetch: fetchProfiles };
};

export const useDynamicProfiles = (
  profileType: ProfileType,
  options: UseApiOptions = { immediate: true },
) => {
  if (profileType === "Category") return { ...useGetCategoryProfiles(options) };
  else return { ...useGetConditionProfiles(options) };
};

export const useGetCategoryProfiles = (
  options: UseApiOptions = { immediate: true },
) => {
  return { ...useGetProfiles<CategoryProfile>(API_CATEGORY_PROFILES, options) };
};

export const useGetConditionProfiles = (
  options: UseApiOptions = { immediate: true },
) => {
  return {
    ...useGetProfiles<ConditionProfile>(API_CONDITION_PROFILES, options),
  };
};

interface UseProfileByIdResult<T extends Profile> {
  profile: T | null;
  loading: boolean;
  error: string | null;
  refetch: () => Promise<void>;
}

export const useGetProfile = <T extends Profile>(
  profileType: ProfileType,
  id?: string,
  options: UseApiOptions = { immediate: true },
): UseProfileByIdResult<T> => {
  const [profile, setProfile] = useState<T | null>(null);
  const [loading, setLoading] = useState<boolean>(true);
  const [error, setError] = useState<string | null>(null);

  const { api } = useAuth();

  const endpoint =
    profileType === "Category"
      ? `${API_CATEGORY_PROFILES}/${id}`
      : `${API_CONDITION_PROFILES}/${id}`;

  const fetchProfile = useCallback(async () => {
    try {
      setLoading(true);
      setError(null);

      const response = await api!.get<T>(endpoint);
      setProfile(response.data);
    } catch (err: any) {
      if (err.response && err.response.status === 404) {
        setError("Profil nie został znaleziony.");
      } else {
        setError("Wystąpił błąd podczas pobierania danych profilu.");
      }
    } finally {
      setLoading(false);
    }
  }, [id, api, endpoint]);

  useEffect(() => {
    if (id && id.length > 0 && options.immediate) {
      fetchProfile();
    }
  }, [id, fetchProfile, options.immediate]);

  return { profile, loading, error, refetch: fetchProfile };
};

type ProfileDictionary = Record<ProfileType, string | null>;

interface FavouriteProfilesResponse {
  categoryProfileId: string | null;
  conditionProfileId: string | null;
}

export const useGetFavouriteProfiles = (
  options: UseApiOptions = { immediate: true },
) => {
  const [favouriteProfiles, setFavouriteProfiles] = useState<ProfileDictionary>(
    { Category: null, Condition: null },
  );
  const [loading, setLoading] = useState<boolean>(false);
  const [error, setError] = useState<string | null>(null);
  const { api } = useAuth();

  const fetchProfiles = useCallback(async () => {
    try {
      setLoading(true);
      setError(null);

      const response = await api!.get<FavouriteProfilesResponse>(
        API_FAVOURITE_PROFILES,
      );
      setFavouriteProfiles({
        Category: response.data.categoryProfileId,
        Condition: response.data.conditionProfileId,
      });
    } catch (err: any) {
      console.error(err.response.data);
      if (err.response && err.response.status !== 404) {
        setError("Wystąpił błąd podczas pobierania ulubionych profili.");
      }
    } finally {
      setLoading(false);
    }
  }, [api]);

  useEffect(() => {
    if (options.immediate) fetchProfiles();
  }, [fetchProfiles]);

  return { favouriteProfiles, loading, error, refetch: fetchProfiles };
};

export const useEditProfile = (
  editRequest: EditProfileRequest,
  options: UseApiOptions = { immediate: true },
) => {
  const { api } = useAuth();
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState<string | null>(null);
  const [success, setSuccess] = useState<boolean | null>(null);

  const editProfile = useCallback(async () => {
    setLoading(true);
    setError(null);
    setSuccess(null);

    const { profileType, ...request } = editRequest;

    const endpoint =
      profileType === "Category"
        ? `${API_CATEGORY_PROFILES}/${request.id}`
        : `${API_CONDITION_PROFILES}/${request.id}`;

    try {
      await api!.put(endpoint, request);
      setSuccess(true);
    } catch (err: any) {
      setError(JSON.stringify(err) || "Wystąpił błąd");
      setSuccess(false);
    } finally {
      setLoading(false);
    }
  }, [api, editRequest]);

  useEffect(() => {
    if (options.immediate) {
      editProfile();
    }
  }, [editProfile, options.immediate]);

  return { editProfile, loading, error, success };
};
