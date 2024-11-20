// import { useAuth } from "@/app/ctx";
// import { PlaceDetails } from "@/types/Place";
import { useAuth } from "@/app/ctx";
import { API_ADDING_TRIP_POINT } from "@/constants/Endpoints";
import { CreateTripPointRequest, TripPointResponse } from "@/types/data";
import { TripErrors } from "@/types/Trip";
import { delay } from "@/utils/TimeUtils";
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
      console.log("Create trip point: " + JSON.stringify(request));
      const response = await api!.post<TripPointResponse>(
        API_ADDING_TRIP_POINT,
        request,
      );
      console.log("Response: " + JSON.stringify(response))
      setData(response.data as TripPointResponse);
    } catch (err: any) {
      console.log("Error response: " + JSON.stringify(err.response.data))
      if (err.response && err.response.status === 400) {
        setError("Nie dodano punktu wycieczki. " + err.response.data);
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
