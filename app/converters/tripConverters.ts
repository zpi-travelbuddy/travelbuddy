import { Place, PlaceDetails } from "@/types/Place";
import {
  TripRequest,
  TripDay,
  TripResponse,
  TripSummary,
  TripViewModel,
  EditTripRequest,
} from "@/types/Trip";
import { getMoneyWithCurrency } from "@/utils/CurrencyUtils";
import { formatDateRange } from "@/utils/TimeUtils";

// Temporary mocked functions
function getCategoryProfileName(categoryProfileId: string | null): string {
  if (!categoryProfileId) return "";
  return "Zwiedzanie i jedzenie";
}

function getConditionProfileName(conditionProfileId: string | null): string {
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

export function convertTripResponseToViewModel(
  tripDetails: TripResponse | undefined,
  tripSummary: TripSummary | undefined,
  destinationDetails: PlaceDetails | undefined,
): TripViewModel {
  if (!tripDetails) throw new Error("Trip details are undefined.");
  if (!destinationDetails)
    throw new Error("Destination details are undefined.");
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
    categoryProfileName: getCategoryProfileName(tripDetails.categoryProfileId),
    conditionProfileName: getConditionProfileName(
      tripDetails.conditionProfileId,
    ),
  };
}

export function convertTripRequestToTripResponse(
  request: TripRequest,
  id: string,
  destinationId: string,
  tripDays: TripDay[] = [],
): TripResponse {
  return {
    id,
    name: request.name,
    numberOfTravelers: request.numberOfTravelers,
    startDate: request.startDate,
    endDate: request.endDate,
    destinationId,
    budget: request.budget,
    currencyCode: request.currencyCode,
    categoryProfileId: request.categoryProfileId,
    conditionProfileId: request.conditionProfileId,
    tripDays,
  };
}

export function convertTripResponseToEditTripRequest(
  response: TripResponse,
  destination: Place,
): EditTripRequest {
  const editTripRequest: EditTripRequest = {
    name: response.name,
    numberOfTravelers: response.numberOfTravelers,
    startDate: response.startDate,
    endDate: response.endDate,
    destinationPlace: {
      providerId: destination.providerId || "",
      name: destination.name || "",
      country: destination.country || "",
      city: destination.city || "",
      latitude: destination.latitude || 0,
      longitude: destination.longitude || 0,
    },
    budget: response.budget,
    currencyCode: response.currencyCode,
  };

  return editTripRequest;
}
