import { useState, useEffect, useCallback } from "react";
import { TripResponse, TripSummary, TripRequest } from "@/types/Trip";
import { useAuth } from "@/app/ctx";
import { API_TRIPS } from "@/constants/Endpoints";

const useTripDetails = (tripId: string | null) => {
  const [tripDetails, setTripDetails] = useState<TripResponse | undefined>(
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
      const response = await api!.get<TripResponse>(`/trips/${tripId}`);
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

export interface UseApiOptions {
  immediate?: boolean;
}

export const useEditTripDetails = (
  trip: TripRequest,
  options: UseApiOptions = { immediate: true },
) => {
  const { api } = useAuth();
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState<string | null>(null);
  const [success, setSuccess] = useState<boolean | null>(null);

  const editTrip = useCallback(async () => {
    setLoading(true);
    setError(null);
    setSuccess(null);

    try {
      const { id, ...tripData } = trip;
      await api!.put(`${API_TRIPS}/${id}`, tripData);
      setSuccess(true);
    } catch (err: any) {
      setError(JSON.stringify(err) || "Wystąpił błąd");
      setSuccess(false);
    } finally {
      setLoading(false);
    }
  }, [api, trip]);

  useEffect(() => {
    if (options.immediate) {
      editTrip();
    }
  }, [editTrip, options.immediate]);

  return { editTrip, loading, error, success };
};
