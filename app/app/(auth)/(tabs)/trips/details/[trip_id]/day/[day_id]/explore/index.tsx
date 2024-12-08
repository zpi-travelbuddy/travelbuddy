import ExploreView from "@/views/ExploreView";
import { useLocalSearchParams } from "expo-router";

export default function TripExplore() {
  const { trip_id } = useLocalSearchParams();

  return <ExploreView tripId={trip_id as string} />;
}
