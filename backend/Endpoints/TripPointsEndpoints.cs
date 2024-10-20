
using TravelBuddyAPI.Models;

namespace TravelBuddyAPI.Endpoints;

public static class TripPointsEndpoints{
    public static WebApplication MapTripPointsEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/tripPoints").RequireAuthorization();

        group.MapPost("/create", CreateTripPointAsync)
            .WithName("CreateTripPoint");

        group.MapPost("/edit", EditTripPointAsync)
            .WithName("EditTripPoint");

        group.MapPost("/submitReview", ReviewTripPointAsync)
            .WithName("SubmitTripPointReview");

        group.MapGet("/reviews", GetTripPointsReviewsAsync)
            .WithName("GetTripPointsReviews");

        group.MapGet("/delete/{id}", DeleteTripPointAsync)
            .WithName("DeleteTripPoint");

        group.MapGet("/details/{id}", GetTripPointDetailsAsync)
            .WithName("GetTripPointDetails");

        return app;
    }

    private static async Task<IResult> GetTripPointsReviewsAsync()
    {
        throw new NotImplementedException();
    }

    private static async Task<IResult> ReviewTripPointAsync(TripPointReview tripPointReview)
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

    private static async Task<IResult> EditTripPointAsync(TripPoint tripPoint)
    {
        throw new NotImplementedException();
    }

    private static async Task<IResult> CreateTripPointAsync(TripPoint tripPoint)
    {
        throw new NotImplementedException();
    }
}