// import { useAuth } from "@/app/ctx";
// import { PlaceDetails } from "@/types/Place";
import { useAuth } from "@/app/ctx";
import { API_ADDING_TRIP_POINT } from "@/constants/Endpoints";
import { CreateTripPointRequest, TripPointResponse } from "@/types/data";
import { TripErrors } from "@/types/Trip";
import { useState, useCallback, useEffect } from "react";

export const useCreateTripPoint = () => {
  const [loading, setLoading] = useState<boolean>(false);
  const [error, setError] = useState<string | null>(null);
  const [data, setData] = useState<TripPointResponse | null>(null);

  const { api } = useAuth();

  const createTripPoint = async (request: CreateTripPointRequest) => {
    try {
      setLoading(true);
      setError(null);
      setData(null);

      const response = await api!.post<TripPointResponse>(
        API_ADDING_TRIP_POINT,
        request,
      );
      setData(response.data);
    } catch (err: any) {
      if (err.response && err.response.status === 400) {
        setError("Nie dodano punktu wycieczki.");
      } else {
        setError("Wystąpił błąd podczas dodawania punktu wycieczki.");
      }
    } finally {
      setLoading(false);
    }
  };

  return {
    createTripPoint,
    loading,
    error,
    data,
  };
};
