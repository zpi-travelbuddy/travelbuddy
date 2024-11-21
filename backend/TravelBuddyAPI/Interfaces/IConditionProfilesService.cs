using TravelBuddyAPI.DTOs.ConditionProfile;

namespace TravelBuddyAPI.Interfaces;

/// <summary>
/// Interface for managing condition profiles.
/// </summary>
public interface IConditionProfilesService
{
    public static class ErrorMessage
    {
        public const string ConditionProfileNotFound = "Condition profile not found.";
    }

    /// <summary>
    /// Creates a new condition profile for a user.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="conditionProfile">The condition profile data to create.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the details of the created condition profile.</returns>
    Task<ConditionProfileDetailsDTO> CreateConditionProfileAsync(string userId, ConditionProfileRequestDTO conditionProfile);

    /// <summary>
    /// Edits an existing condition profile for a user.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="profileId">The ID of the condition profile to edit.</param>
    /// <param name="conditionProfile">The updated condition profile data.</param>
    /// <returns>A task that represents the asynchronous operation. The task result indicates whether the edit was successful.</returns>
    Task<bool> EditConditionProfileAsync(string userId, Guid profileId, ConditionProfileRequestDTO conditionProfile);

    /// <summary>
    /// Deletes a condition profile for a user.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="profileId">The ID of the condition profile to delete.</param>
    /// <returns>A task that represents the asynchronous operation. The task result indicates whether the deletion was successful.</returns>
    Task<bool> DeleteConditionProfileAsync(string userId, Guid profileId);
    /// /// /// /// /// 
    /// <summary>
    /// Gets the details of a specific condition profile for a user.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="profileId">The ID of the condition profile to retrieve.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the details of the condition profile.</returns>
    Task<ConditionProfileDetailsDTO> GetConditionProfileDetailsAsync(string userId, Guid profileId);
    /// /// /// /// /// 
    /// <summary>
    /// Gets an overview of all condition profiles for a user.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains an overview of the user's condition profiles.</returns>
    Task<List<ConditionProfileOverviewDTO>> GetUserConditionProfilesAsync(string userId);
}