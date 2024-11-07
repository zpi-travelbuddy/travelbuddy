import TripDetailsView from "@/views/TripDetailsView";
import { useLocalSearchParams, useRouter } from "expo-router";

export default function Details() {
  const params = useLocalSearchParams();
  const { trip_id } = params;
  console.log(`Trip ID: ${trip_id}`);
  return <TripDetailsView />;
}
