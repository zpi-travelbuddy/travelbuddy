import { useState, useEffect, useCallback } from "react";
import { TripDetails, TripSummary } from "@/types/Trip";
import { useAuth } from "@/app/ctx";
import { API_TRIPS } from "@/constants/Endpoints";



const useTripDetails = (tripId: string | null) => {
  const [tripDetails, setTripDetails] = useState<TripDetails | undefined>(
    undefined,
  );
  const [tripSummary, setTripSummary] = useState<TripSummary | undefined>(
    undefined,
  );
  const [loading, setLoading] = useState<boolean>(false);
  const [error, setError] = useState<string | null>(null);

  const { api } = useAuth();

  const fetchTripDetails = useCallback(async () => {
    try {
      const response = await api!.get<TripDetails>(`/trips/${tripId}`);
      setTripDetails(response.data);
    } catch (err: any) {
      if (err.response && err.response.status === 404) {
        setError("Wycieczka nie została znaleziona.");
      } else {
        console.log(JSON.stringify(err));
        setError("Wystąpił błąd podczas pobierania danych.");
      }
    }
  }, [api, tripId]);

  // const fetchTripSummary = useCallback(async () => {
  //   try {
  //     const response = await api!.get<TripSummary>(`/trips/summary/${tripId}`);
  //     setTripSummary(response.data);
  //   } catch (err: any) {
  //     setError(
  //       "Wystąpił błąd podczas pobierania podsumowania wycieczki: " +
  //         err.toString(),
  //     );
  //   }
  // }, [api, tripId]);

  const refetch = useCallback(async () => {
    setLoading(true);
    setError(null);
    // await Promise.all([fetchTripDetails(), fetchTripSummary()]);
    await fetchTripDetails();
    setLoading(false);
  }, [fetchTripDetails]);

  useEffect(() => {
    if (tripId) {
      refetch();
    }
  }, [tripId, refetch]);

  return { tripDetails, tripSummary, loading, error, refetch };
};

export default useTripDetails;

export const useEditTripDetails = async (trip: TripDetails) => {
  const { api } = useAuth();
  return await api!.put(API_TRIPS, trip);
};
