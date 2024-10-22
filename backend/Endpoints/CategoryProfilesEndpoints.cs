
using TravelBuddyAPI.Models;
using TravelBuddyAPI.DTOs.CategoryProfile;

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

    private static async Task<IResult> GetAvailableCategoriesAsync()
    {
        throw new NotImplementedException();
    }

    private static async Task<IResult> GetAvailableCategoryProfilesAsync()
    {
        throw new NotImplementedException();
    }

    private static async Task<IResult> GetCategoryProfileDetailsAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    private static async Task<IResult> DeleteCategoryProfileAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    private static async Task<IResult> EditCategoryProfileAsync(Guid id, CategoryProfileDTO categoryProfile)
    {
        throw new NotImplementedException();
    }

    private static async Task<IResult> CreateCategoryProfileAsync(CategoryProfileDTO categoryProfile)
    {
        throw new NotImplementedException();
    }
}