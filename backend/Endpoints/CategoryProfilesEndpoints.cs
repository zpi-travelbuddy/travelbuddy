
using TravelBuddyAPI.Models;
using TravelBuddyAPI.ViewModels.CategoryProfile;

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

    private static async Task<IResult> EditCategoryProfileAsync(CategoryProfileModificationViewModel categoryProfile)
    {
        throw new NotImplementedException();
    }

    private static async Task<IResult> CreateCategoryProfileAsync(CategoryProfileCreationViewModel categoryProfile)
    {
        throw new NotImplementedException();
    }
}