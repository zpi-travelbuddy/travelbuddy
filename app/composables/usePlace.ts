import { useAuth } from "@/app/ctx";
import { PlaceDetails } from "@/types/Place";
import { useState, useCallback, useEffect } from "react";

const usePlaceDetails = (placeId: string | undefined) => {
  const [placeDetails, setPlaceDetails] = useState<PlaceDetails | undefined>(
    undefined,
  );
  const [loading, setLoading] = useState<boolean>(true);
  const [error, setError] = useState<string | null>(null);

  const { api } = useAuth();

  const fetchPlaceDetails = useCallback(async () => {
    if (!placeId) return;
    try {
      setLoading(true);
      setError(null);

      const response = await api!.get<PlaceDetails>(`/places/${placeId}`);
      // const updatedPlaceDetails = {
      //   ...response.data,
      //   providerId:
      //     "51fd2488049d5ac0bf59e23f38faf3c04940f00103f901ffa4010000000000c0020792030b5743324e203544582b6762",
      // };
      // setPlaceDetails(updatedPlaceDetails);
      setPlaceDetails(response.data);
    } catch (err: any) {
      if (err.response && err.response.status === 404) {
        setError("Miejsce nie zostało znalezione.");
      } else {
        setError("Wystąpił błąd podczas pobierania danych miejsca.");
      }
    } finally {
      setLoading(false);
    }
  }, [api, placeId]);

  useEffect(() => {
    if (placeId) {
      fetchPlaceDetails();
    } else {
      setLoading(false);
    }
  }, [placeId, fetchPlaceDetails]);

  return { placeDetails, loading, error, refetch: fetchPlaceDetails };
};

export default usePlaceDetails;
