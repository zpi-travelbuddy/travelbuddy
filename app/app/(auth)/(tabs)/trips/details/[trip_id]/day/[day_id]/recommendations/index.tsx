import RecommendationsView from "@/views/RecommendationsView";
import { useLocalSearchParams } from "expo-router";

export default function TripExplore() {
  const { trip_id } = useLocalSearchParams();

  return <RecommendationsView tripId={trip_id as string} />;
}
