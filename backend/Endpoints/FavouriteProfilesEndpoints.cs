

namespace TravelBuddyAPI.Endpoints;

public static class FavouriteProfilesEndpoints
{
    public static WebApplication MapFavouriteProfilesEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/favourites").RequireAuthorization();

        group.MapGet("/categoryProfile/add/{id}", AddCategoryProfileToFavouritesAsync)
            .WithName("AddCategoryProfileToFavourites");

        group.MapGet("/categoryProfile/remove/{id}", RemoveCategoryProfileFromFavouritesAsync)
            .WithName("RemoveCategoryProfileFromFavourites");

        group.MapGet("/conditionProfile/add/{id}", AddConditionProfileToFavouritesAsync)
            .WithName("AddConditionProfileToFavourites");

        group.MapGet("/conditionProfile/remove/{id}", RemoveConditionProfileFromFavouritesAsync)
            .WithName("RemoveConditionProfileFromFavourites");

        group.MapGet("", GetFavouriteProfilesAsync)
            .WithName("GetFavouriteProfiles");

        return app;
    }
    
    private static async Task<IResult> GetFavouriteProfilesAsync()
    {
        throw new NotImplementedException();
    }

    private static async Task<IResult> RemoveConditionProfileFromFavouritesAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    private static async Task<IResult> AddConditionProfileToFavouritesAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    private static async Task<IResult> RemoveCategoryProfileFromFavouritesAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    private static async Task<IResult> AddCategoryProfileToFavouritesAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}