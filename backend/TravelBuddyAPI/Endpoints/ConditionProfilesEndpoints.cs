
using TravelBuddyAPI.Models;
using TravelBuddyAPI.DTOs.ConditionProfile;
using Microsoft.AspNetCore.Http.HttpResults;
using TravelBuddyAPI.DTOs.PlaceCondition;

namespace TravelBuddyAPI.Endpoints;

public static class ConditionProfilesEndpoints // TODO rename parameters names
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

    private static async Task<Results<Ok<List<PlaceConditionDTO>>, NotFound<string>>> GetAvailableConditionsAsync()
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }

    private static async Task<Results<Ok<List<ConditionProfileOverviewDTO>>, NotFound<string>>> GetAvailableConditionProfilesAsync()
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }

    private static async Task<Results<Ok<ConditionProfileDetailsDTO>, NotFound<string>>> GetConditionProfileDetailsAsync(Guid id)
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }

    private static async Task<Results<NoContent, NotFound<string>>> DeleteConditionProfileAsync(Guid id)
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }

    private static async Task<Results<Accepted<string>, NotFound<string>>> EditConditionProfileAsync(Guid id, ConditionProfileRequestDTO conditionProfile)
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }

    private static async Task<Results<Created<ConditionProfileDetailsDTO>, BadRequest<string>>> CreateConditionProfileAsync(ConditionProfileRequestDTO conditionProfile)
    {
        await Task.CompletedTask;
        return TypedResults.BadRequest("Not implemented");
    }
}