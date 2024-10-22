
using TravelBuddyAPI.Models;
using TravelBuddyAPI.DTOs.TripPoint;
using TravelBuddyAPI.DTOs.TripPointReview;
using Microsoft.AspNetCore.Http.HttpResults;

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

    private static async Task<IResult> GetAvailableSupercategoriesAsync() // TODO
    {
        await Task.CompletedTask;
        return TypedResults.BadRequest("Not implemented");
    }

    private static async Task<Results<Ok<List<TripPointOverviewDTO>>, NotFound<string>>> GetTripPointsReviewsAsync()
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }

    private static async Task<Results<Created<TripPointReviewRequestDTO>, BadRequest<string>>> ReviewTripPointAsync(TripPointReviewRequestDTO tripPointReview)
    {
        await Task.CompletedTask;
        return TypedResults.BadRequest("Not implemented");
    }

    private static async Task<Results<Ok<TripPointDetailsDTO>, NotFound<string>>> GetTripPointDetailsAsync(Guid id)
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }

    private static async Task<Results<NoContent, NotFound<string>>> DeleteTripPointAsync(Guid id)
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }

    private static async Task<Results<Accepted<string>, NotFound<string>>> EditTripPointAsync(Guid id, DTOs.TripPoint.TripPointRequestDTO tripPoint)
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }

    private static async Task<Results<Created<TripPointRequestDTO>, BadRequest<string>>> CreateTripPointAsync(DTOs.TripPoint.TripPointRequestDTO tripPoint)
    {
        await Task.CompletedTask;
        return TypedResults.BadRequest("Not implemented");
    }
}