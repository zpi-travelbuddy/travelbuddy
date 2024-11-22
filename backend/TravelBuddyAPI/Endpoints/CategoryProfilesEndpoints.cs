
using TravelBuddyAPI.Models;
using TravelBuddyAPI.DTOs.CategoryProfile;
using Microsoft.AspNetCore.Http.HttpResults;
using TravelBuddyAPI.DTOs.PlaceCategory;
using TravelBuddyAPI.Interfaces;
using System.Security.Claims;

namespace TravelBuddyAPI.Endpoints;

public static class CategoryProfilesEndpoints
{
    public static WebApplication MapCategoryProfilesEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/categoryProfiles").RequireAuthorization();

        group.MapPost("", CreateCategoryProfileAsync)
            .WithName("CreateCategoryProfile");

        group.MapPut("/{id}", EditCategoryProfileAsync)
            .WithName("EditCategoryProfile");

        group.MapDelete("/{id}", DeleteCategoryProfileAsync)
            .WithName("DeleteCategoryProfile");

        group.MapGet("/{id}", GetCategoryProfileDetailsAsync)
            .WithName("GetCategoryProfileDetails");

        group.MapGet("", GetAvailableCategoryProfilesAsync)
            .WithName("GetAvailableCategoryProfiles");

        group.MapGet("/categories", GetAvailableCategoriesAsync)
            .WithName("GetAvailableCategories");

        return app;
    }

    private static async Task<Results<Ok<List<PlaceCategoryNodeDTO>>, NotFound<string>>> GetAvailableCategoriesAsync(IAvailableOptionsService availableOptionsService)
    {
        var categories = await availableOptionsService.GetAvailableCategoriesAsync();

        if (categories is not null && categories.Count > 0)
        {
            return TypedResults.Ok(categories);
        }

        return TypedResults.NotFound("Available categories not found");
    }

    private static async Task<Results<Ok<List<CategoryProfileOverviewDTO>>, NotFound<string>>> GetAvailableCategoryProfilesAsync(HttpContext httpContext, ICategoryProfilesService categoryProfilesService)
    {

        string userId = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? throw new InvalidOperationException("User not found");
        var categoryProfiles = await categoryProfilesService.GetUserCategoryProfilesAsync(userId);

        if (categoryProfiles is null || categoryProfiles.Count == 0)
        {
            return TypedResults.NotFound("Category profiles not found");
        }
        return TypedResults.Ok(categoryProfiles);

    }

    private static async Task<Results<Ok<CategoryProfileDetailsDTO>, NotFound<string>>> GetCategoryProfileDetailsAsync(Guid id, HttpContext httpContext, ICategoryProfilesService categoryProfilesService)
    {
        string userId = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? throw new InvalidOperationException("User not found");
        
        try {
            var categoryProfileDetails = await categoryProfilesService.GetCategoryProfileDetailsAsync(userId, id);
            return TypedResults.Ok(categoryProfileDetails);
        }
        catch (InvalidOperationException e)
        {
            return TypedResults.NotFound(e.Message);
        }
    }

    private static async Task<Results<NoContent, NotFound<string>, BadRequest<string>>> DeleteCategoryProfileAsync(Guid id, HttpContext httpContext, ICategoryProfilesService categoryProfilesService)
    {
        try
        {
            string userId = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? throw new InvalidOperationException("User not found");
            _ = await categoryProfilesService.DeleteCategoryProfileAsync(userId, id);
            return TypedResults.NoContent();
        }
        catch (InvalidOperationException ex) when (ex.Message.Contains(ICategoryProfilesService.ErrorMessage.CategoryProfileNotFound))
        {
            return TypedResults.NotFound(ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            return TypedResults.BadRequest(ex.Message);
        }
    }

    private static async Task<Results<Accepted<string>, NotFound<string>, BadRequest<string>>> EditCategoryProfileAsync(Guid id, CategoryProfileRequestDTO categoryProfile, HttpContext httpContext, ICategoryProfilesService categoryProfilesService)
    {
        try
        {
            var userId = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? throw new InvalidOperationException("User not found");
            await categoryProfilesService.EditCategoryProfileAsync(userId, id, categoryProfile);
            return TypedResults.Accepted($"/categoryProfiles/{id}", "Category profile edited successfully");
        }
        catch (InvalidOperationException ex) when (ex.Message.Contains(ICategoryProfilesService.ErrorMessage.CategoryProfileNotFound))
        {
            return TypedResults.NotFound(ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            return TypedResults.BadRequest(ex.Message);
        }
    }

    private static async Task<Results<Created<CategoryProfileDetailsDTO>, BadRequest<string>>> CreateCategoryProfileAsync(CategoryProfileRequestDTO categoryProfile, HttpContext httpContext, ICategoryProfilesService categoryProfilesService)
    {
        try
        {
            var userId = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? throw new InvalidOperationException("User not found");
            var categoryProfileDetails = await categoryProfilesService.CreateCategoryProfileAsync(userId, categoryProfile);
            return TypedResults.Created($"/categoryProfiles/{categoryProfileDetails.Id}", categoryProfileDetails);
        }
        catch (InvalidOperationException ex)
        {
            return TypedResults.BadRequest(ex.Message);
        }
    }
}