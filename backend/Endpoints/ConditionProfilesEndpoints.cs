
using TravelBuddyAPI.Models;
using TravelBuddyAPI.ViewModels.ConditionProfile;

namespace TravelBuddyAPI.Endpoints;

public static class ConditionProfilesEndpoints
{
    public static WebApplication MapConditionProfilesEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/conditionProfiles").RequireAuthorization();

        group.MapPost("", CreateConditionProfileAsync)
            .WithName("CreateConditionProfile");

        group.MapPut("/{id}", EditConditionProfileAsync)
            .WithName("EditConditionProfile");

        group.MapDelete("/{id}", DeleteConditionProfileAsync)
            .WithName("DeleteConditionProfile");

        group.MapGet("/{id}", GetConditionProfileDetailsAsync)
            .WithName("GetConditionProfileDetails");

        group.MapGet("", GetAvailableConditionProfilesAsync)
            .WithName("GetAvailableConditionProfiles");

        group.MapGet("/conditions", GetAvailableConditionsAsync)
            .WithName("GetAvailableConditions");

        return app;
    }

    private static async Task<IResult> GetAvailableConditionsAsync()
    {
        throw new NotImplementedException();
    }

    private static async Task<IResult> GetAvailableConditionProfilesAsync()
    {
        throw new NotImplementedException();
    }

    private static async Task<IResult> GetConditionProfileDetailsAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    private static async Task<IResult> DeleteConditionProfileAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    private static async Task<IResult> EditConditionProfileAsync(Guid id, ConditionProfileModificationViewModel categoryProfile)
    {
        throw new NotImplementedException();
    }

    private static async Task<IResult> CreateConditionProfileAsync(ConditionProfileCreationViewModel categoryProfile)
    {
        throw new NotImplementedException();
    }
}