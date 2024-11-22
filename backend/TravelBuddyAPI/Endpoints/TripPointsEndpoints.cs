
using TravelBuddyAPI.Models;
using TravelBuddyAPI.DTOs.TripPoint;
using TravelBuddyAPI.DTOs.TripPointReview;
using Microsoft.AspNetCore.Http.HttpResults;
using TravelBuddyAPI.DTOs.PlaceCategory;
using TravelBuddyAPI.Interfaces;
using System.Security.Claims;

namespace TravelBuddyAPI.Endpoints;

public static class TripPointsEndpoints
{
    public static WebApplication MapTripPointsEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/tripPoints").RequireAuthorization();

        group.MapPost("", CreateTripPointAsync)
            .WithName("CreateTripPoint");

        group.MapPut("/{id}", EditTripPointAsync)
            .WithName("EditTripPoint");

        group.MapPost("/submitReview", ReviewTripPointAsync)
            .WithName("SubmitTripPointReview");

        group.MapGet("/reviews", GetTripPointsReviewsAsync)
            .WithName("GetTripPointsReviews");

        group.MapDelete("/{id}", DeleteTripPointAsync)
            .WithName("DeleteTripPoint");

        group.MapGet("/{id}", GetTripPointDetailsAsync)
            .WithName("GetTripPointDetails");

        group.MapGet("/supercategories", GetAvailableSupercategoriesAsync)
            .WithName("GetAvailableSupercategories");

        return app;
    }

    private static async Task<Results<Ok<List<PlaceCategoryDTO>>, NotFound<string>>> GetAvailableSupercategoriesAsync(IAvailableOptionsService availableOptionsService)
    {
        var supercategories = await availableOptionsService.GetAvailableSupercategoriesAsync();

        if (supercategories is not null && supercategories.Count > 0)
        {
            return TypedResults.Ok(supercategories);
        }

        return TypedResults.NotFound("Available supercategories not found");
    }

    private static async Task<Results<Ok<List<TripPointReviewOverviewDTO>>, NotFound<string>>> GetTripPointsReviewsAsync()
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }

    private static async Task<Results<Created<TripPointDetailsDTO>, BadRequest<string>>> ReviewTripPointAsync(TripPointReviewRequestDTO tripPointReview)

    {
        await Task.CompletedTask;
        return TypedResults.BadRequest("Not implemented");
    }

    private static async Task<Results<Ok<TripPointDetailsDTO>, NotFound<string>>> GetTripPointDetailsAsync(Guid id, ITripPointsService tripPointsService, HttpContext httpContext)
    {
        try
        {
            var userId = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? throw new InvalidOperationException("User not found");
            var tripPointDetails = await tripPointsService.GetTripPointDetailsAsync(userId, id);
            return TypedResults.Ok(tripPointDetails);
        }
        catch (InvalidOperationException ex)
        {
            return TypedResults.NotFound(ex.Message);
        }
    }

    private static async Task<Results<NoContent, NotFound<string>>> DeleteTripPointAsync(Guid id, ITripPointsService tripPointsService, HttpContext httpContext)
    {
        try
        {
            string userId = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? throw new InvalidOperationException("User not found");
            _ = await tripPointsService.DeleteTripPointAsync(userId, id);
            return TypedResults.NoContent();
        }
        catch (InvalidOperationException ex)
        {
            return TypedResults.NotFound(ex.Message);
        }
    }

    private static async Task<Results<Accepted<string>, NotFound<string>, BadRequest<string>>> EditTripPointAsync(Guid id, TripPointRequestDTO tripPoint)
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }

    private static async Task<Results<Created<TripPointDetailsDTO>, BadRequest<string>>> CreateTripPointAsync(TripPointRequestDTO tripPoint, ITripPointsService tripPointsService, HttpContext httpContext)
    {
        try
        {
            string userId = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? throw new InvalidOperationException("User not found");
            var tripPointDetails = await tripPointsService.CreateTripPointAsync(userId, tripPoint);
            string uri = $"/tripPoints/{tripPointDetails.Id}";
            return TypedResults.Created(uri, tripPointDetails);
        }
        catch (InvalidOperationException ex)
        {
            return TypedResults.BadRequest(ex.Message);
        }
    }
}