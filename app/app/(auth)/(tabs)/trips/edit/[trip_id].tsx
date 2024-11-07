import TripDetailsView from "@/views/TripDetailsView";
import { useLocalSearchParams } from "expo-router";
import { View, Text } from "react-native";

export default function Edit() {
  const params = useLocalSearchParams();
  const { trip_id } = params;
  return (
    <View>
      <Text>TripEditView for ID: {trip_id}</Text>
    </View>
  );
}
