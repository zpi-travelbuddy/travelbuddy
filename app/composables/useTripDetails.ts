/* eslint-disable @typescript-eslint/no-explicit-any */
import { useState, useEffect, useCallback } from "react";
import { TripSummary, TripRequest, TripDetails } from "@/types/Trip";
import { useAuth } from "@/app/ctx";
import { API_TRIPS } from "@/constants/Endpoints";
import { CategoryProfile, ConditionProfile } from "@/types/Profile";
import { useGetProfile } from "./useProfiles";

export const useTripDetails = (
  tripId: string | null,
  options: UseApiOptions = { immediate: true },
) => {
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
    if (tripId && options.immediate) {
      refetch();
    }
  }, [tripId, refetch, options.immediate]);

  return { tripDetails, tripSummary, loading, error, refetch };
};

export interface UseApiOptions {
  immediate?: boolean;
}

export const useEditTripDetails = (
  id: string,
  request: TripRequest,
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
      await api!.put(`${API_TRIPS}/${id}`, request);
      setSuccess(true);
    } catch (err: any) {
      setError(JSON.stringify(err) || "Wystąpił błąd");
      setSuccess(false);
    } finally {
      setLoading(false);
    }
  }, [api, request]);

  useEffect(() => {
    if (options.immediate) {
      editTrip();
    }
  }, [editTrip, options.immediate]);

  return { editTrip, loading, error, success };
};

export const useTripDetailsWithProfiles = (
  tripId: string | null,
  options: UseApiOptions = { immediate: true },
) => {
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

  const fetchTripSummary = useCallback(async () => {
    try {
      const response = await api!.get<TripSummary>(`/trips/summary/${tripId}`);
      setTripSummary(response.data);
    } catch (err: any) {
      setError(
        "Wystąpił błąd podczas pobierania podsumowania wycieczki: " +
          err.toString(),
      );
    }
  }, [api, tripId]);

  // Profile hooks
  const {
    profile: categoryProfile,
    loading: categoryLoading,
    error: categoryError,
  } = useGetProfile<CategoryProfile>(
    "Category",
    tripDetails?.categoryProfileId || "",
  );
  const {
    profile: conditionProfile,
    loading: conditionLoading,
    error: conditionError,
  } = useGetProfile<ConditionProfile>(
    "Condition",
    tripDetails?.conditionProfileId || "",
  );

  const refetch = useCallback(async () => {
    setLoading(true);
    setError(null);

    try {
      await Promise.all([fetchTripDetails(), fetchTripSummary()]);
    } catch (e: any) {
      console.error("Error during refetch", e);
    } finally {
      setLoading(false);
    }
  }, [fetchTripDetails, fetchTripSummary]);

  useEffect(() => {
    if (tripId && options.immediate) {
      refetch();
    }
  }, [tripId, refetch, options.immediate]);

  return {
    tripDetails,
    tripSummary,
    categoryProfile,
    conditionProfile,
    loading: loading || categoryLoading || conditionLoading,
    error: error || categoryError || conditionError,
    refetch,
  };
};
