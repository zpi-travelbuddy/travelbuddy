
using TravelBuddyAPI.Models;

namespace TravelBuddyAPI.Endpoints;

public static class ConditionProfilesEndpoints
{
    public static WebApplication MapConditionProfilesEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/conditionProfiles").RequireAuthorization();

        group.MapPost("/create", CreateConditionProfileAsync)
            .WithName("CreateConditionProfile");

        group.MapPost("/edit", EditConditionProfileAsync)
            .WithName("EditConditionProfile");

        group.MapGet("/delete/{id}", DeleteConditionProfileAsync)
            .WithName("DeleteConditionProfile");

        group.MapGet("/details/{id}", GetConditionProfileDetailsAsync)
            .WithName("GetConditionProfileDetails");

        group.MapGet("", GetAvailableConditionProfilesAsync)
            .WithName("GetAvailableConditionProfiles");

        group.MapGet("/conditions", GetAvailableConditionsAsync)
            .WithName("GetAvailableConditions");

        return app;
    }

    private static async Task GetAvailableConditionsAsync()
    {
        throw new NotImplementedException();
    }

    private static async Task GetAvailableConditionProfilesAsync()
    {
        throw new NotImplementedException();
    }

    private static async Task GetConditionProfileDetailsAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    private static async Task DeleteConditionProfileAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    private static async Task EditConditionProfileAsync(ConditionProfile categoryProfile)
    {
        throw new NotImplementedException();
    }

    private static async Task CreateConditionProfileAsync(ConditionProfile categoryProfile)
    {
        throw new NotImplementedException();
    }
}