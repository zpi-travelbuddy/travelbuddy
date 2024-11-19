import { PlaceDetails } from "@/types/Place";
import {
  TripCompact,
  TripDetails,
  TripSummary,
  TripViewModel,
} from "@/types/Trip";
import { getMoneyWithCurrency } from "@/utils/CurrencyUtils";
import { formatDateFromISO, formatDateRange } from "@/utils/TimeUtils";

const RANDOM_IMAGE = "https://picsum.photos/891";

// Temporary mocked functions
function getCategoryProfileName(
  categoryProfileId?: string | null | undefined,
): string {
  if (!categoryProfileId) return "";
  return "Zwiedzanie i jedzenie";
}

function getConditionProfileName(
  conditionProfileId?: string | null | undefined,
): string {
  if (!conditionProfileId) return "";
  return "Potrzebuję internetu dla psa";
}

function getDestinationName(
  destinationDetails: PlaceDetails | undefined,
): string {
  return destinationDetails
    ? `${destinationDetails.city}, ${destinationDetails.country}`
    : "";
}

export const calculateTripSummary = (tripSummary: TripSummary) => {
  let predictedSpendings = 0;
  let totalTripPoints = 0;

  tripSummary.tripDays.forEach((day) => {
    day.tripPoints.forEach((point) => {
      predictedSpendings += point.predictedSpendings;
      totalTripPoints += 1;
    });
  });

  return {
    predictedSpendings,
    totalTripPoints,
  };
};

export function convertTripDetailsToViewModel(
  tripDetails: TripDetails | undefined,
  tripSummary: TripSummary | undefined,
  destinationDetails: PlaceDetails | undefined,
): TripViewModel {
  if (!tripDetails) throw new Error("Trip details are undefined.");
  const { predictedSpendings, totalTripPoints } = tripSummary
    ? calculateTripSummary(tripSummary)
    : { predictedSpendings: 0, totalTripPoints: tripDetails.tripDays.length }; // temporary
  return {
    name: tripDetails.name,
    dateRange: formatDateRange(
      new Date(tripDetails.startDate),
      new Date(tripDetails.endDate),
    ),
    destination: getDestinationName(destinationDetails),
    numberOfTripPoints: totalTripPoints,
    numberOfTravelers: tripDetails.numberOfTravelers,
    predictedCost: getMoneyWithCurrency(
      predictedSpendings,
      tripDetails.currencyCode,
    ),
    budget: getMoneyWithCurrency(tripDetails.budget, tripDetails.currencyCode),
    categoryProfileName: getCategoryProfileName(tripDetails?.categoryProfileId),
    conditionProfileName: getConditionProfileName(
      tripDetails?.conditionProfileId,
    ),
  };
}

export const convertTripsFromAPI = (
  trips: TripCompact[],
  isArchived = false,
): TripCompact[] => {
  return trips.map((trip) => ({
    id: trip.id,
    name: trip.name,
    startDate: formatDateFromISO(trip.startDate),
    endDate: formatDateFromISO(trip.endDate),
    imageUri: RANDOM_IMAGE,
    isArchived: isArchived,
  }));
};
