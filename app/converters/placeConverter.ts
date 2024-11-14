import { PlaceDetails } from "@/types/Place";
import { TripPointType } from "@/types/Trip";
import { formatMinutesInWords } from "@/utils/TimeUtils";

export const convertToPlaceViewModel = (place: PlaceDetails) => {
  const result = {
    name: place.name,
    address: getAddress(place),
    attractionType: getAttractionType(place),
    conveniences: getConveniences(place), // TODO: changing to special enum
    rating: place.averageRating,
    averageCostPerPerson: place.averageCostPerPerson,
    averageVisitTime: place.averageTimeSpent,
    latitude: place.latitude,
    longitude: place.longitude,
    imageUrl:
      "https://upload.wikimedia.org/wikipedia/commons/1/1a/Big_Ben..JPG",
  };

  return result;
};

const getAddress = (place: PlaceDetails) => {
  return {
    street: place.street,
    number: place.houseNumber,
    city: place.city,
    country: place.country,
  };
};

const getAttractionType = (place: PlaceDetails) => {
  console.log(place.categories);
  return "other" as TripPointType;
};

const getConveniences = (place: PlaceDetails) => {
  console.log(place.conditions);
  return [];
};
