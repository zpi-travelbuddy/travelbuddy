import { useState, useEffect, useCallback } from "react";
import { useAuth } from "@/app/ctx";
import {
  TransferPoint,
  TripPointCompact,
  TripDayDetails,
} from "@/types/TripDayData";
import { TripDay } from "@/types/Trip";

const useTripDayDetails = (tripDayId: string | null) => {
  const [transferPoints, setTransferPoints] = useState<TransferPoint[]>([]);
  const [tripPoints, setTripPoints] = useState<TripPointCompact[]>([]);
  const [tripDay, setTripDay] = useState<TripDay | undefined>(undefined);
  const [loading, setLoading] = useState<boolean>(true);
  const [error, setError] = useState<string | null>(null);

  const { api } = useAuth();

  const fetchTripDayDetails = useCallback(async () => {
    try {
      const response = await api!.get<TripDayDetails>(
        `/trips/tripDay/${tripDayId}`,
      );

      setTransferPoints(
        response.data.transferPoints ? response.data.transferPoints : [],
      );
      setTripPoints(response.data.tripPoints ? response.data.tripPoints : []);
      setTripDay(
        response.data
          ? ({
              id: response.data.id,
              tripId: response.data.tripId,
              date: response.data.date,
            } as TripDay)
          : undefined,
      );
      // eslint-disable-next-line @typescript-eslint/no-explicit-any
    } catch (err: any) {
      if (err.response && err.response.status === 404) {
        setError("Dzień wycieczki nie został znaleziony.");
      } else {
        setError("Wystąpił błąd podczas pobierania danych.");
      }
    }
  }, [api, tripDayId]);

  const refetch = useCallback(async () => {
    setLoading(true);
    setError(null);
    await fetchTripDayDetails();
    setLoading(false);
  }, [fetchTripDayDetails]);

  const refetchNoLoading = useCallback(async () => {
    setError(null);
    await fetchTripDayDetails();
  }, [fetchTripDayDetails]);

  useEffect(() => {
    if (tripDayId) {
      refetch();
    }
  }, [tripDayId, refetch]);

  return {
    transferPoints,
    tripPoints,
    tripDay,
    loading,
    error,
    refetch,
    refetchNoLoading,
  };
};

export default useTripDayDetails;
