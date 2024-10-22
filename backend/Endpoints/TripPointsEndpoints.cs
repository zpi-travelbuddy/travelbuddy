
using TravelBuddyAPI.Models;
using TravelBuddyAPI.DTOs.TripPoint;
using TravelBuddyAPI.DTOs.TripPointReview;

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

    private static async Task<IResult> GetAvailableSupercategoriesAsync()
    {
        throw new NotImplementedException();
    }

    private static async Task<IResult> GetTripPointsReviewsAsync()
    {
        throw new NotImplementedException();
    }

    private static async Task<IResult> ReviewTripPointAsync(DTOs.TripPointReview.TripPointReviewDTO tripPointReview)
    {
        throw new NotImplementedException();
    }

    private static async Task<IResult> GetTripPointDetailsAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    private static async Task<IResult> DeleteTripPointAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    private static async Task<IResult> EditTripPointAsync(Guid id, DTOs.TripPoint.TripPointDTO tripPoint)
    {
        throw new NotImplementedException();
    }

    private static async Task<IResult> CreateTripPointAsync(DTOs.TripPoint.TripPointDTO tripPoint)
    {
        throw new NotImplementedException();
    }
}