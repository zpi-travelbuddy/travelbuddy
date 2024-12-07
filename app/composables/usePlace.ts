/* eslint-disable @typescript-eslint/no-explicit-any */
import { useAuth } from "@/app/ctx";
import { PlaceDetails } from "@/types/Place";
import { useState, useCallback, useEffect } from "react";
import { UseApiOptions } from "./useTripDetails";
import { Category, Condition } from "@/types/Profile";

const usePlaceDetails = (
  placeId: string | undefined,
  endpoint: string = "/places",
  options: UseApiOptions = { immediate: true },
) => {
  const [placeDetails, setPlaceDetails] = useState<PlaceDetails | undefined>(
    undefined,
  );
  const [loading, setLoading] = useState<boolean>(true);
  const [error, setError] = useState<string | null>(null);
  const [success, setSuccess] = useState<boolean>(false);

  const { api } = useAuth();

  const fetchPlaceDetails = useCallback(async () => {
    if (!placeId) return;
    setLoading(true);
    setError(null);
    setSuccess(false);
    try {
      const response = await api!.get<PlaceDetails>(`${endpoint}/${placeId}`);
      setPlaceDetails({
        ...response.data,
        conditions: response.data.conditions
          ? response.data.conditions
          : ([] as Condition[]),
        categories: response.data.categories
          ? response.data.categories
          : ([] as Category[]),
      });
      setSuccess(true);
    } catch (err: any) {
      setSuccess(false);
      if (err.response && err.response.status === 404) {
        setError("Miejsce nie zostało znalezione.");
      } else {
        setError("Wystąpił błąd podczas pobierania danych miejsca.");
      }
    } finally {
      setLoading(false);
    }
  }, [api, endpoint, placeId]);

  const refetch = useCallback(fetchPlaceDetails, [fetchPlaceDetails]);

  useEffect(() => {
    if (placeId && options.immediate) {
      refetch();
    }
  }, [placeId, options.immediate, refetch]);

  return { placeDetails, loading, error, success, refetch };
};

export const useAttractionDetails = (
  providerId: string | undefined,
  options: UseApiOptions = { immediate: true },
) => {
  return usePlaceDetails(providerId, "/places/provider", options);
};

export default usePlaceDetails;
