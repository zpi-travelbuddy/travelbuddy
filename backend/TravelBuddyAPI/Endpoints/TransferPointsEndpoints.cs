
using Sprache;
using TravelBuddyAPI.Models;
using TravelBuddyAPI.DTOs.TransferPoint;
using Microsoft.AspNetCore.Http.HttpResults;
using TravelBuddyAPI.Interfaces;
using System.Security.Claims;

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

    private static async Task<Results<Created<TransferPointDTO>,BadRequest<string>>> CreateTransferPointAsync(TransferPointDTO transferPoint, ITransferPointsService transferPointsService, HttpContext httpContext)
    {
        try {
            var userId = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? throw new InvalidOperationException("User not found");
            var transferPointDetails = await transferPointsService.CreateTransferPointAsync(userId, transferPoint);
            return TypedResults.Created($"/transferPoints/{transferPointDetails}", transferPointDetails);
        } catch (InvalidOperationException ex) {
            return TypedResults.BadRequest(ex.Message);
        }
    }

    private static async Task<Results<Accepted<string>,NotFound<string>>> EditTransferPointAsync(Guid id, TransferPointDTO transferPoint, ITransferPointsService transferPointsService, HttpContext httpContext)
    {
        try {
            var userId = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? throw new InvalidOperationException("User not found");
            var transferPointEdited = await transferPointsService.EditTransferPointAsync(userId, id, transferPoint) ? "Transfer point edited successfully" : throw new InvalidOperationException("Failed to edit transfer point");
            return TypedResults.Accepted($"/transferPoints/{transferPointEdited}", transferPointEdited);
        } catch (InvalidOperationException ex) {
            return TypedResults.NotFound(ex.Message);
        }
    }

    private static async Task<Results<NoContent,NotFound<string>>> DeleteTransferPointAsync(Guid id, ITransferPointsService transferPointsService, HttpContext httpContext)
    {
        try {
            var userId = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? throw new InvalidOperationException("User not found");
            var transferPointDeleted = await transferPointsService.DeleteTransferPointAsync(userId, id) ? "Transfer point edited successfully" : throw new InvalidOperationException("Failed to edit transfer point");
            return TypedResults.NoContent();
        } catch (InvalidOperationException ex) {
            return TypedResults.NotFound(ex.Message);
        }
    }
}