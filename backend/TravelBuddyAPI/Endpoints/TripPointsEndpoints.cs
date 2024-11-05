
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

    private static async Task<Results<Ok<List<PlaceCategoryDTO>>, NotFound<string>>> GetAvailableSupercategoriesAsync()
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
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
        try {
            var userId = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? throw new InvalidOperationException("User not found");
            var tripPointDetails = await tripPointsService.GetTripPointDetailsAsync(userId, id);
            return TypedResults.Ok(tripPointDetails);
        } catch (InvalidOperationException ex) {
            return TypedResults.NotFound(ex.Message);
        }
    }

    private static async Task<Results<NoContent, NotFound<string>>> DeleteTripPointAsync(Guid id)
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }

    private static async Task<Results<Accepted<string>, NotFound<string>>> EditTripPointAsync(Guid id, TripPointRequestDTO tripPoint)
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }

    private static async Task<Results<Created<TripPointDetailsDTO>, BadRequest<string>>> CreateTripPointAsync(TripPointRequestDTO tripPoint)

    {
        await Task.CompletedTask;
        return TypedResults.BadRequest("Not implemented");
    }
}