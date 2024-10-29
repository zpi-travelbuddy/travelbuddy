import { View, Text } from "react-native";
import { useRouter } from "expo-router";

const TripDetails = () => {
  const router = useRouter();

  return (
    <View>
      <Text>Details for Trip ID</Text>
    </View>
  );
};

export default TripDetails;
