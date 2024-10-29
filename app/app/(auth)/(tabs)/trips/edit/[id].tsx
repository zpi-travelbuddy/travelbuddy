import TripDetailsView from "@/views/TripDetailsView";
import { useLocalSearchParams } from "expo-router";
import { View, Text } from "react-native";

export default function Edit() {
  const params = useLocalSearchParams();
  const { id } = params;
  return (
    <View>
      <Text>TripEditView for ID: {id}</Text>
    </View>
  );
}
