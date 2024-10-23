
using Sprache;
using TravelBuddyAPI.Models;
using TravelBuddyAPI.DTOs.TransferPoint;
using Microsoft.AspNetCore.Http.HttpResults;

namespace TravelBuddyAPI.Endpoints;

public static class TransferPointsEndpoints
{
    public static void MapTransferPointsEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/transferPoints").RequireAuthorization();

        group.MapPost("", CreateTransferPointAsync)
            .WithName("CreateTransferPoint");

        group.MapPut("/{id}", EditTransferPointAsync)
            .WithName("EditTransferPoint");

        group.MapDelete("/{id}", DeleteTransferPointAsync)
            .WithName("DeleteTransferPoint");  
    }

    private static async Task<Results<Created<TransferPointDTO>,BadRequest<string>>> CreateTransferPointAsync(TransferPointDTO transferPoint)
    {
        await Task.CompletedTask;
        return TypedResults.BadRequest("Not implemented");
    }

    private static async Task<Results<Accepted<string>,NotFound<string>>> EditTransferPointAsync(Guid id, TransferPointDTO transferPoint)
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }

    private static async Task<Results<NoContent,NotFound<string>>> DeleteTransferPointAsync(Guid id)
    {
        await Task.CompletedTask;
        return TypedResults.NotFound("Not implemented");
    }
}