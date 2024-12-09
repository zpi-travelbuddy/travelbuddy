import { TripImageContext } from "@/context/TripImageContext";
import { useContext } from "react";

const useTripImageStorage = () => {
  const context = useContext(TripImageContext);

  if (!context) {
    throw new Error(
      "useTripImageStorage must be used within an TripImageProvider",
    );
  }

  return context;
};

export default useTripImageStorage;
