
using TravelBuddyAPI.Models;

namespace TravelBuddyAPI.Endpoints;

public static class TransferPointsEndpoints
{
    public static void MapTransferPointsEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/transferPoints").RequireAuthorization();

        group.MapPost("/create", CreateTransferPointAsync)
            .WithName("CreateTransferPoint");

        group.MapPost("/edit", EditTransferPointAsync)
            .WithName("EditTransferPoint");

        group.MapGet("/delete/{id}", DeleteTransferPointAsync)
            .WithName("DeleteTransferPoint");  
    }

    private static async Task<IResult> CreateTransferPointAsync(TransferPoint transferPoint)
    {
        throw new NotImplementedException();
    }

    private static async Task EditTransferPointAsync(TransferPoint transferPoint)
    {
        throw new NotImplementedException();
    }

    private static async Task DeleteTransferPointAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}