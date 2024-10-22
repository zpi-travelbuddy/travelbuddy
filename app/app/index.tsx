import { TripCard } from "@/components/TripCard";
import { View } from "react-native";
import { Provider } from "react-native-paper";
import { useTheme } from "react-native-paper";

export default function Index() {
  const theme = useTheme();

  return (
    <Provider theme={theme}>
      <View
        style={{
          flex: 1,
          justifyContent: "center",
          alignItems: "center",
        }}
      >
        <TripCard
          title="Wycieczka do Milicza"
          subtitle="10.06.2024 - 15.06.2024"
          imageUri="https://picsum.photos/888"
        />
      </View>
    </Provider>
  );
}
