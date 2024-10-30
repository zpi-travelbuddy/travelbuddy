using System.Reflection.Metadata;

namespace TravelBuddyAPI.Data.Messages;

public static class Error{
    public const string EmptyRequest = "Request body was empty.";
    public const string CreateTrip = "Error creating trip:";
    public const string RetriveExchangeRate = "Could not retrive exchange rate.";
}