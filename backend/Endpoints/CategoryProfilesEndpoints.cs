
using TravelBuddyAPI.Models;
using TravelBuddyAPI.DTOs.CategoryProfile;
using Microsoft.AspNetCore.Http.HttpResults;
using TravelBuddyAPI.DTOs.PlaceCategory;

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

    private static async Task<Results<Ok<List<PlaceCategoryDTO>>, NotFound<string>>> GetAvailableCategoriesAsync()
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("test");
    }

    private static async Task<Results<Ok<List<CategoryProfileOverviewDTO>>, NotFound<string>>> GetAvailableCategoryProfilesAsync()
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }

    private static async Task<Results<Ok<CategoryProfileDetailsDTO>, NotFound<string>>> GetCategoryProfileDetailsAsync(Guid id)
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }

    private static async Task<Results<NoContent, NotFound<string>>> DeleteCategoryProfileAsync(Guid id)
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }

    private static async Task<Results<Accepted<string>, NotFound<string>>> EditCategoryProfileAsync(Guid id, CategoryProfileRequestDTO categoryProfile)
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }

    private static async Task<Results<Created<CategoryProfileDetailsDTO>, BadRequest<string>>> CreateCategoryProfileAsync(CategoryProfileRequestDTO categoryProfile)
    {
        await Task.CompletedTask;
        return TypedResults.BadRequest("Not implemented");
    }
}