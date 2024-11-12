import { PlaceDetails } from "@/types/Place";
import { TripDetails, TripSummary, TripViewModel } from "@/types/Trip";
import { getMoneyWithCurrency } from "@/utils/CurrencyUtils";
import { formatDateRange } from "@/utils/TimeUtils";

// Temporary mocked functions
function getCategoryProfileName(categoryProfileId: string): string {
  return "Zwiedzanie i jedzenie";
}

function getConditionProfileName(conditionProfileId: string): string {
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
  let totalSpendings = 0;
  let totalTripPoints = 0;

  tripSummary.tripDays.forEach((day) => {
    day.tripPoints.forEach((point) => {
      totalSpendings += point.totalSpendings;
      totalTripPoints += 1;
    });
  });

  return {
    totalSpendings,
    totalTripPoints,
  };
};

export function convertTripDetailsToViewModel(
  tripDetails: TripDetails | undefined,
  tripSummary: TripSummary | undefined,
  destinationDetails: PlaceDetails | undefined,
): TripViewModel {
  if (!tripDetails) throw new Error("Trip details are undefined.");
  const { totalSpendings, totalTripPoints } = tripSummary
    ? calculateTripSummary(tripSummary)
    : { totalSpendings: 0, totalTripPoints: tripDetails.tripDays.length }; // temporary
  return {
    name: tripDetails.name,
    dateRange: formatDateRange(
      new Date(tripDetails.startDate),
      new Date(tripDetails.endDate),
    ),
    destination: getDestinationName(destinationDetails),
    numberOfTripPoints: totalTripPoints,
    numberOfTravelers: tripDetails.numberOfTravelers,
    cost: getMoneyWithCurrency(totalSpendings, tripDetails.currencyCode),
    budget: getMoneyWithCurrency(tripDetails.budget, tripDetails.currencyCode),
    categoryProfileName: getCategoryProfileName(tripDetails.categoryProfileId),
    conditionProfileName: getConditionProfileName(
      tripDetails.conditionProfileId,
    ),
  };
}
