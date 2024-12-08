/* eslint-disable @typescript-eslint/no-explicit-any */
import { useAuth } from "@/app/ctx";
import { API_TRIP_POINT } from "@/constants/Endpoints";
import { TripPointRequest, TripPointDetails } from "@/types/TripDayData";
import { useState, useCallback, useEffect } from "react";

// Maybe for future refactor
export const useCreateTripPoint = () => {
  const [loading, setLoading] = useState<boolean>(false);
  const [error, setError] = useState<string | null>(null);
  const [data, setData] = useState<TripPointDetails | null>(null);

  const { api } = useAuth();

  const createTripPoint = useCallback(
    async (request: TripPointRequest) => {
      try {
        setLoading(true);
        setError(null);
        setData(null);
        const response = await api!.post<TripPointDetails>(
          API_TRIP_POINT,
          request,
        );
        setData(response.data as TripPointDetails);
      } catch (err: any) {
        if (err.response && err.response.status === 400) {
          setError("Nie dodano punktu wycieczki. " + err.response.data);
        } else {
          setError("Wystąpił błąd podczas dodawania punktu wycieczki.");
        }
      } finally {
        setLoading(false);
      }
    },
    [api, error, data],
  );

  return {
    createTripPoint,
    loading,
    error,
    data,
  };
};

export const useGetTripPoint = (tripPointId: string | null) => {
  const [tripPointDetails, setTripPointDetails] = useState<
    TripPointDetails | undefined
  >();
  const [loading, setLoading] = useState<boolean>(false);
  const [error, setError] = useState<string | null>(null);

  const { api } = useAuth();

  const fetchTripPointDetails = useCallback(async () => {
    try {
      const response = await api!.get<TripPointDetails>(
        `/tripPoints/${tripPointId}`,
      );
      setTripPointDetails(response.data);
    } catch (err: any) {
      if (err.response && err.response.status === 404) {
        setError("Punkt wycieczki nie został znaleziony.");
      } else {
        setError("Wystąpił błąd podczas pobierania danych.");
      }
    }
  }, [api, tripPointId]);

  const refetch = useCallback(async () => {
    setLoading(true);
    setError(null);
    await fetchTripPointDetails();
    setLoading(false);
  }, [fetchTripPointDetails]);

  useEffect(() => {
    if (tripPointId) {
      refetch();
    }
  }, [tripPointId, refetch]);

  return {
    tripPointDetails,
    loading,
    error,
    refetch,
  };
};

export const useDeleteTripPoint = () => {
  const [loading, setLoading] = useState<boolean>(false);
  const [error, setError] = useState<string | null>(null);

  const { api } = useAuth();

  const deleteTripPoint = useCallback(
    async (tripPointId: string | undefined) => {
      if (!tripPointId) return;
      try {
        setLoading(true);
        setError(null);
        await api!.delete(`/tripPoints/${tripPointId}`);
      } catch (err: any) {
        if (err.response && err.response.status === 400) {
          setError("Nie usunięto punktu wycieczki. " + err.response.data);
        } else {
          setError("Wystąpił błąd podczas usuwania punktu wycieczki.");
        }
      } finally {
        setLoading(false);
      }
    },
    [api, error],
  );

  return {
    deleteTripPoint,
    loading,
    error,
  };
};
