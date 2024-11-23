
using TravelBuddyAPI.Models;
using TravelBuddyAPI.DTOs.ConditionProfile;
using Microsoft.AspNetCore.Http.HttpResults;
using TravelBuddyAPI.DTOs.PlaceCondition;
using TravelBuddyAPI.Interfaces;
using System.Security.Claims;

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

    private static async Task<Results<Ok<List<PlaceConditionNodeDTO>>, NotFound<string>>> GetAvailableConditionsAsync(IAvailableOptionsService availableOptionsService)
    {
        var conditions = await availableOptionsService.GetAvailableConditionsAsync();

        if (conditions is not null && conditions.Count > 0)
        {
            return TypedResults.Ok(conditions);
        }

        return TypedResults.NotFound("Available conditions not found");
    }

    private static async Task<Results<Ok<List<ConditionProfileOverviewDTO>>, NotFound<string>>> GetAvailableConditionProfilesAsync(HttpContext httpContext, IConditionProfilesService conditionProfilesService)
    {
        string userId = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? throw new InvalidOperationException("User not found");
        var conditionProfiles = await conditionProfilesService.GetUserConditionProfilesAsync(userId);

        if (conditionProfiles is null || conditionProfiles.Count == 0)
        {
            return TypedResults.NotFound("Condition profiles not found");
        }
        return TypedResults.Ok(conditionProfiles);
    }

    private static async Task<Results<Ok<ConditionProfileDetailsDTO>, NotFound<string>>> GetConditionProfileDetailsAsync(Guid id, HttpContext httpContext, IConditionProfilesService conditionProfilesService)
    {
        string userId = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? throw new InvalidOperationException("User not found");
        
        try {
            var conditionProfileDetails = await conditionProfilesService.GetConditionProfileDetailsAsync(userId, id);
            return TypedResults.Ok(conditionProfileDetails);
        }
        catch (InvalidOperationException e)
        {
            return TypedResults.NotFound(e.Message);
        }
    }

    private static async Task<Results<NoContent, NotFound<string>, BadRequest<string>>> DeleteConditionProfileAsync(Guid id, HttpContext httpContext, IConditionProfilesService conditionProfilesService)
    {
        try
        {
            string userId = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? throw new InvalidOperationException("User not found");
            _ = await conditionProfilesService.DeleteConditionProfileAsync(userId, id);
            return TypedResults.NoContent();
        }
        catch (InvalidOperationException ex) when (ex.Message.Contains(IConditionProfilesService.ErrorMessage.ConditionProfileNotFound))
        {
            return TypedResults.NotFound(ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            return TypedResults.BadRequest(ex.Message);
        }
    }

    private static async Task<Results<Accepted<string>, NotFound<string>, BadRequest<string>>> EditConditionProfileAsync(Guid id, ConditionProfileRequestDTO conditionProfile, HttpContext httpContext, IConditionProfilesService conditionProfilesService)
    {
        try
        {
            var userId = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? throw new InvalidOperationException("User not found");
            await conditionProfilesService.EditConditionProfileAsync(userId, id, conditionProfile);
            return TypedResults.Accepted($"/conditionProfiles/{id}", "Condition profile edited successfully");
        }
        catch (InvalidOperationException ex) when (ex.Message.Contains(IConditionProfilesService.ErrorMessage.ConditionProfileNotFound))
        {
            return TypedResults.NotFound(ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            return TypedResults.BadRequest(ex.Message);
        }
    }

    private static async Task<Results<Created<ConditionProfileDetailsDTO>, BadRequest<string>>> CreateConditionProfileAsync(ConditionProfileRequestDTO conditionProfile, HttpContext httpContext, IConditionProfilesService conditionProfilesService)
    {
        try
        {
            var userId = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? throw new InvalidOperationException("User not found");
            var conditionProfileDetails = await conditionProfilesService.CreateConditionProfileAsync(userId, conditionProfile);
            return TypedResults.Created($"/conditionProfiles/{conditionProfileDetails.Id}", conditionProfileDetails);
        }
        catch (InvalidOperationException ex)
        {
            return TypedResults.BadRequest(ex.Message);
        }
    }
}