

using Microsoft.AspNetCore.Http.HttpResults;
using TravelBuddyAPI.DTOs.FavouriteProfiles;

namespace TravelBuddyAPI.Endpoints;

public static class FavouriteProfilesEndpoints
{
    public static WebApplication MapFavouriteProfilesEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/favourites").RequireAuthorization();

        group.MapPost("/categoryProfile/{id}", AddCategoryProfileToFavouritesAsync)
            .WithName("AddCategoryProfileToFavourites");

        group.MapDelete("/categoryProfile/{id}", RemoveCategoryProfileFromFavouritesAsync)
            .WithName("RemoveCategoryProfileFromFavourites");

        group.MapPost("/conditionProfile/{id}", AddConditionProfileToFavouritesAsync)
            .WithName("AddConditionProfileToFavourites");

        group.MapDelete("/conditionProfile/{id}", RemoveConditionProfileFromFavouritesAsync)
            .WithName("RemoveConditionProfileFromFavourites");

        group.MapGet("", GetFavouriteProfilesAsync)
            .WithName("GetFavouriteProfiles");

        return app;
    }

    private static async Task<Results<Ok<FavouriteProfilesDTO>, NotFound<string>>> GetFavouriteProfilesAsync()
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }

    private static async Task<Results<NoContent, NotFound<string>, BadRequest<string>>> RemoveConditionProfileFromFavouritesAsync(Guid id)
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }

    private static async Task<Results<Created<FavouriteProfilesDTO>, NotFound<string>, BadRequest<string>>> AddConditionProfileToFavouritesAsync(Guid id)
    {
        await Task.CompletedTask;
        return TypedResults.BadRequest("Not implemented");
    }

    private static async Task<Results<NoContent, NotFound<string>, BadRequest<string>>> RemoveCategoryProfileFromFavouritesAsync(Guid id)
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }

    private static async Task<Results<Created<FavouriteProfilesDTO>, NotFound<string>, BadRequest<string>>> AddCategoryProfileToFavouritesAsync(Guid id)
    {
        await Task.CompletedTask;
        return TypedResults.BadRequest("Not implemented");
    }
}