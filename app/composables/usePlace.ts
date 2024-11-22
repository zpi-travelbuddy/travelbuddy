import { useAuth } from "@/app/ctx";
import { PlaceCategory, PlaceCondition, PlaceDetails } from "@/types/Place";
import { useState, useCallback, useEffect } from "react";

const usePlaceDetails = (
  placeId: string | undefined,
  endpoint: string = "/places",
) => {
  const [placeDetails, setPlaceDetails] = useState<PlaceDetails | undefined>(
    undefined,
  );
  const [loading, setLoading] = useState<boolean>(true);
  const [error, setError] = useState<string | null>(null);

  const { api } = useAuth();

  const fetchPlaceDetails = useCallback(async () => {
    if (!placeId) return;
    try {
      const response = await api!.get<PlaceDetails>(`${endpoint}/${placeId}`);
      setPlaceDetails({
        ...response.data,
        conditions: response.data.conditions
          ? response.data.conditions
          : ([] as PlaceCondition[]),
        categories: response.data.categories
          ? response.data.categories
          : ([] as PlaceCategory[]),
      });
      // eslint-disable-next-line @typescript-eslint/no-explicit-any
    } catch (err: any) {
      console.log(err.response.data);
      if (err.response && err.response.status === 404) {
        setError("Miejsce nie zostało znalezione.");
      } else {
        setError("Wystąpił błąd podczas pobierania danych miejsca.");
      }
    }
  }, [api, placeId]);

  const refetch = useCallback(async () => {
    setLoading(true);
    setError(null);
    await fetchPlaceDetails();
    setLoading(false);
  }, [fetchPlaceDetails]);

  useEffect(() => {
    if (placeId) {
      refetch();
    }
  }, [placeId, refetch]);

  return { placeDetails, loading, error, refetch };
};

export const useAttractionDetails = (providerId: string | undefined) => {
  return usePlaceDetails(providerId, "/places/provider");
};

export default usePlaceDetails;
