import { useAuth } from "@/app/ctx";
import { API_ADDING_TRIP_POINT } from "@/constants/Endpoints";
import { CreateTripPointRequest, TripPointDetails } from "@/types/TripDayData";
import { useState, useCallback } from "react";

// Maybe for future refactor
export const useCreateTripPoint = () => {
  const [loading, setLoading] = useState<boolean>(false);
  const [error, setError] = useState<string | null>(null);
  const [data, setData] = useState<TripPointDetails | null>(null);

  const { api } = useAuth();

  const createTripPoint = useCallback(
    async (request: CreateTripPointRequest) => {
      try {
        setLoading(true);
        setError(null);
        setData(null);
        const response = await api!.post<TripPointDetails>(
          API_ADDING_TRIP_POINT,
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
