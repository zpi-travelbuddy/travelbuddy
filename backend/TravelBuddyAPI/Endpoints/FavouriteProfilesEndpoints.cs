

using System.Security.Claims;
using Microsoft.AspNetCore.Http.HttpResults;
using TravelBuddyAPI.DTOs.FavouriteProfiles;
using TravelBuddyAPI.Interfaces;

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

    private static async Task<Results<Ok<FavouriteProfilesDTO>, NotFound<string>>> GetFavouriteProfilesAsync(HttpContext httpContext, IFavouritesService favouritesService)
    {
        try
        {
            var userId = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? throw new InvalidOperationException("User not found");
            var favouriteProfilesDTO = await favouritesService.GetFavouriteProfilesAsync(userId);
            return TypedResults.Ok(favouriteProfilesDTO);
        }
        catch (InvalidOperationException ex)
        {
            return TypedResults.NotFound(ex.Message);
        }
    }

    private static async Task<Results<NoContent, NotFound<string>, BadRequest<string>>> RemoveConditionProfileFromFavouritesAsync(Guid id, HttpContext httpContext, IFavouritesService favouritesService)
    {
        try
        {
            var userId = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? throw new InvalidOperationException("User not found");
            await favouritesService.RemoveConditionProfileFromFavouritesAsync(userId, id);
            return TypedResults.NoContent();
        }
        catch (InvalidOperationException ex) when (ex.Message.Contains(IFavouritesService.ErrorMessage.FavouritesProfilesNotFound))
        {
            return TypedResults.NotFound(ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            return TypedResults.BadRequest(ex.Message);
        }
    }

    private static async Task<Results<Created<FavouriteProfilesDTO>, NotFound<string>, BadRequest<string>>> AddConditionProfileToFavouritesAsync(Guid id, HttpContext httpContext, IFavouritesService favouritesService)
    {
        try
        {
            var userId = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? throw new InvalidOperationException("User not found");
            var favouriteProfilesDTO = await favouritesService.AddConditionProfileToFavouritesAsync(userId, id);
            return TypedResults.Created($"/favourites/conditionProfile/{id}", favouriteProfilesDTO);
        }
        catch (InvalidOperationException ex) when (ex.Message.Contains(IFavouritesService.ErrorMessage.CategoryProfileNotFound))
        {
            return TypedResults.NotFound(ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            return TypedResults.BadRequest(ex.Message);
        }
    }

    private static async Task<Results<NoContent, NotFound<string>, BadRequest<string>>> RemoveCategoryProfileFromFavouritesAsync(Guid id, HttpContext httpContext, IFavouritesService favouritesService)
    {
        try
        {
            var userId = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? throw new InvalidOperationException("User not found");
            await favouritesService.RemoveCategoryProfileFromFavouritesAsync(userId, id);
            return TypedResults.NoContent();
        }
        catch (InvalidOperationException ex) when (ex.Message.Contains(IFavouritesService.ErrorMessage.FavouritesProfilesNotFound))
        {
            return TypedResults.NotFound(ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            return TypedResults.BadRequest(ex.Message);
        }
    }

    private static async Task<Results<Created<FavouriteProfilesDTO>, NotFound<string>, BadRequest<string>>> AddCategoryProfileToFavouritesAsync(Guid id, HttpContext httpContext, IFavouritesService favouritesService)
    {
        try
        {
            var userId = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? throw new InvalidOperationException("User not found");
            var favouriteProfilesDTO = await favouritesService.AddCategoryProfileToFavouritesAsync(userId, id);
            return TypedResults.Created($"/favourites/conditionProfile/{id}", favouriteProfilesDTO);
        }
        catch (InvalidOperationException ex) when (ex.Message.Contains(IFavouritesService.ErrorMessage.CategoryProfileNotFound))
        {
            return TypedResults.NotFound(ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            return TypedResults.BadRequest(ex.Message);
        }
    }
}