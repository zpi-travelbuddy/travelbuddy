import { View, Text } from "react-native";
import { useLocalSearchParams, useRouter } from "expo-router";

const TripDetailsView = () => {
  const params = useLocalSearchParams();
  const { id } = params;
  return (
    <View>
      <Text>Details for Trip ID {id}</Text>
    </View>
  );
};

export default TripDetailsView;
