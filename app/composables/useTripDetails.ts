import { useState, useEffect } from "react";
import { TripDetails, TripDay } from "@/types/Trip";
import { useAuth } from "@/app/ctx";

const useTripDetails = (tripId: string | null) => {
  const [tripDetails, setTripDetails] = useState<TripDetails | null>(null);
  const [loading, setLoading] = useState<boolean>(true);
  const [error, setError] = useState<string | null>(null);

  const { api } = useAuth();

  useEffect(() => {
    const fetchTripDetails = async () => {
      setLoading(true);
      setError(null);

      try {
        const response = await api!.get<TripDetails>(`/trips/${tripId}`);
        setTripDetails(response.data);
      } catch (err: any) {
        if (err.response && err.response.status === 404) {
          setError("Wycieczka nie została znaleziona.");
        } else {
          setError("Wystąpił błąd podczas pobierania danych.");
        }
      } finally {
        setLoading(false);
      }
    };

    if (tripId) {
      fetchTripDetails();
    }
  }, [tripId]);

  return { tripDetails, loading, error };
};

export default useTripDetails;
