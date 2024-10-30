using TravelBuddyAPI.DTOs.CategoryProfile;

namespace TravelBuddyAPI.Interfaces;

/// <summary>
/// Interface for managing category profiles.
/// </summary>
public interface ICategoryProfilesService
{
    /// <summary>
    /// Creates a new category profile.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation. The task result contains the details of the created category profile.</returns>
    Task<CategoryProfileDetailsDTO> CreateCategoryProfileAsync(string userId, CategoryProfileRequestDTO categoryProfile);

    /// <summary>
    /// Edits an existing category profile.
    /// </summary>
    /// <param name="userId">The ID of the user who owns the profile.</param>
    /// <param name="profileId">The ID of the profile to edit.</param>
    /// <param name="categoryProfile">The updated category profile data.</param>
    /// <returns>A task that represents the asynchronous operation. The task result indicates whether the edit was successful.</returns>
    Task<bool> EditCategoryProfileAsync(string userId, Guid profileId, CategoryProfileRequestDTO categoryProfile);

    /// <summary>
    /// Deletes a category profile.
    /// </summary>
    /// <param name="userId">The ID of the user who owns the profile.</param>
    /// <param name="profileId">The ID of the profile to delete.</param>
    /// <returns>A task that represents the asynchronous operation. The task result indicates whether the deletion was successful.</returns>
    Task<bool> DeleteCategoryProfileAsync(string userId, Guid profileId);

    /// <summary>
    /// Gets the details of a specific category profile.
    /// </summary>
    /// <param name="userId">The ID of the user who owns the profile.</param>
    /// <param name="profileId">The ID of the profile to retrieve.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the details of the requested category profile.</returns>
    Task<CategoryProfileDetailsDTO> GetCategoryProfileDetailsAsync(string userId, Guid profileId);

    /// <summary>
    /// Gets an overview of all category profiles for a specific user.
    /// </summary>
    /// <param name="userId">The ID of the user whose profiles to retrieve.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains an overview of the user's category profiles.</returns>
    Task<List<CategoryProfileOverviewDTO>> GetUserCategoryProfilesAsync(string userId);
}