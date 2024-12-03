import { useAuth } from "@/app/ctx";
import { API_ADDING_TRIP_POINT, API_TRIPS } from "@/constants/Endpoints";
import { TripDetails } from "@/types/Trip";
import { TripPointDetails } from "@/types/TripDayData";
import LoadingView from "@/views/LoadingView";
import TripPointDetailsView from "@/views/TripPointDetailsView";
import { useLocalSearchParams } from "expo-router";
import { useEffect, useState } from "react";

export default function TripPoint() {
  const { trip_id, trip_point_id } = useLocalSearchParams();
  const { api } = useAuth();

  const [loading, setLoading] = useState(false);
  const [tripPoint, setTripPoint] = useState<TripPointDetails | null>(null);
  const [trip, setTrip] = useState<TripDetails | null>(null);

  const fetchTripPointData = async () => {
    try {
      const fetchedTripPoint = await api?.get<TripPointDetails>(
        `${API_ADDING_TRIP_POINT}/${trip_point_id}`,
      );
      setTripPoint(fetchedTripPoint?.data || null);
    } catch (error: any) {
      console.error(error.message);
    }
  };

  const fetchTripData = async () => {
    try {
      const fetchedTrip = await api?.get<TripDetails>(
        `${API_TRIPS}/${trip_id}`,
      );
      setTrip(fetchedTrip?.data || null);
    } catch (error: any) {
      console.error(error.message);
    }
  };

  const fetchData = async () => {
    setLoading(true);
    await Promise.all([fetchTripPointData(), fetchTripData()]);
    setLoading(false);
  };

  useEffect(() => {
    fetchData();
  }, [trip_id, trip_point_id]);

  if (loading) {
    return <LoadingView />;
  }

  return <TripPointDetailsView tripPoint={tripPoint} trip={trip} />;
}
