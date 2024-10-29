using TravelBuddyAPI.DTOs.TransferPoint;

namespace TravelBuddyAPI.Interfaces;

/// <summary>
/// Interface for managing transfer points.
/// </summary>
public interface ITransferPointsService
{
    /// <summary>
    /// Creates a new transfer point.
    /// </summary>
    /// <param name="userId">The ID of the user creating the transfer point.</param>
    /// <param name="transferPoint">The transfer point data to be created.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the created transfer point.</returns>
    Task<TransferPointDTO> CreateTransferPointAsync(string userId, TransferPointDTO transferPoint);

    /// <summary>
    /// Edits an existing transfer point.
    /// </summary>
    /// <param name="userId">The ID of the user editing the transfer point.</param>
    /// <param name="transferPoint">The transfer point data to be edited.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the edited transfer point.</returns>
    Task<TransferPointDTO> EditTransferPointAsync(string userId, TransferPointDTO transferPoint);

    /// <summary>
    /// Deletes a transfer point.
    /// </summary>
    /// <param name="userId">The ID of the user deleting the transfer point.</param>
    /// <param name="transferPointId">The ID of the transfer point to be deleted.</param>
    /// <returns>A task that represents the asynchronous operation. The task result indicates whether the deletion was successful.</returns>
    Task<bool> DeleteTransferPointAsync(string userId, Guid transferPointId);
}