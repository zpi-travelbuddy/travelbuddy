
using TravelBuddyAPI.Models;

namespace TravelBuddyAPI.Endpoints;

public static class CategoryProfilesEndpoints
{
    public static WebApplication MapCategoryProfilesEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/categoryProfiles").RequireAuthorization();

        group.MapPost("/create", CreateCategoryProfileAsync)
            .WithName("CreateCategoryProfile");

        group.MapPost("/edit", EditCategoryProfileAsync)
            .WithName("EditCategoryProfile");

        group.MapGet("/delete/{id}", DeleteCategoryProfileAsync)
            .WithName("DeleteCategoryProfile");

        group.MapGet("/details/{id}", GetCategoryProfileDetailsAsync)
            .WithName("GetCategoryProfileDetails");

        group.MapGet("", GetAvailableCategoryProfilesAsync)
            .WithName("GetAvailableCategoryProfiles");

        group.MapGet("/categories", GetAvailableCategoriesAsync)
            .WithName("GetAvailableCategories");

        return app;
    }

    private static async Task GetAvailableCategoriesAsync()
    {
        throw new NotImplementedException();
    }

    private static async Task GetAvailableCategoryProfilesAsync()
    {
        throw new NotImplementedException();
    }

    private static async Task GetCategoryProfileDetailsAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    private static async Task DeleteCategoryProfileAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    private static async Task EditCategoryProfileAsync(CategoryProfile categoryProfile)
    {
        throw new NotImplementedException();
    }

    private static async Task CreateCategoryProfileAsync(CategoryProfile categoryProfile)
    {
        throw new NotImplementedException();
    }
}