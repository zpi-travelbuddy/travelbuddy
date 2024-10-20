
namespace TravelBuddyAPI.Endpoints;

public static class PlacesEndpoints{
    public static WebApplication MapPlacesEndpoints(this WebApplication app){
        var group = app.MapGroup("/places").RequireAuthorization();

        group.MapGet("/details/{id}", GetPlaceDetailsAsync)
            .WithName("GetPlaceDetails");

        group.MapGet("/autocomplete", GetAutocompletePlacesAsync)
            .WithName("GetAutocompletePlaces");

        return app;
    }

    private static async Task GetAutocompletePlacesAsync(string query, decimal? latitude, decimal? longitude)
    {
        throw new NotImplementedException();
    }

    private static async Task<IResult> GetPlaceDetailsAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}
