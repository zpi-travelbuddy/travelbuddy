import {
  useState,
  useEffect,
  useCallback,
  createContext,
  ReactNode,
} from "react";
import AsyncStorage from "@react-native-async-storage/async-storage";

interface TripImageContextType {
  saveImage: (tripId: string, imageName: string) => Promise<void>;
  removeImage: (tripId: string) => Promise<void>;
  getImageName: (tripId: string) => Promise<string | null>;
}

const TRIP_IMAGE_MAP_KEY = "trip_image_map";

export const TripImageContext = createContext<TripImageContextType | undefined>(
  undefined,
);

export const TripImageContextProvider: React.FC<{ children: ReactNode }> = ({
  children,
}) => {
  const [tripImageMap, setTripImageMap] = useState<Record<string, string>>({});
  useEffect(() => {
    const loadTripImageMap = async () => {
      try {
        const storedMap = await AsyncStorage.getItem(TRIP_IMAGE_MAP_KEY);
        if (storedMap) {
          setTripImageMap(JSON.parse(storedMap));
        }
      } catch (error) {
        console.error("Failed to load trip image map:", error);
      }
    };

    loadTripImageMap();
  }, []);

  // Save the mapping to AsyncStorage whenever it changes.
  const saveTripImageMap = async (map: Record<string, string>) => {
    try {
      await AsyncStorage.setItem(TRIP_IMAGE_MAP_KEY, JSON.stringify(map));
      setTripImageMap(map);
    } catch (error) {
      console.error("Failed to save trip image map:", error);
    }
  };

  // Save a new trip ID and image name to the map.
  const saveImage = useCallback(
    async (tripId: string, imageName: string) => {
      const updatedMap = { ...tripImageMap, [tripId]: imageName };
      await saveTripImageMap(updatedMap);
    },
    [tripImageMap],
  );

  const removeImage = useCallback(
    async (tripId: string) => {
      const { [tripId]: _, ...updatedMap } = tripImageMap;
      await saveTripImageMap(updatedMap);
    },
    [tripImageMap],
  );

  // Retrieve the image name by trip ID.
  const getImageName = useCallback(
    async (tripId: string): Promise<string | null> => {
      return tripImageMap[tripId] || null;
    },
    [tripImageMap],
  );

  return (
    <TripImageContext.Provider value={{ saveImage, removeImage, getImageName }}>
      {children}
    </TripImageContext.Provider>
  );
};
