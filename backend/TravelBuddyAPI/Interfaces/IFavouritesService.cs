using TravelBuddyAPI.DTOs.FavouriteProfiles;

namespace TravelBuddyAPI.Interfaces;

/// <summary>
/// Interface for managing favourite profiles.
/// </summary>
public interface IFavouritesService
{
    public static class ErrorMessage
    {
        public const string FavouritesProfilesNotFound = "Favourite profiles not found.";
        public const string CategoryProfileNotFound = "Category profile not found.";
        public const string ConditionProfileNotFound = "Condition profile not found.";
        public const string NoFavouriteCategoryProfile = "Favourite category profile does not exist.";
        public const string NoFavouriteConditionProfile = "Favourite condition profile does not exist.";

    }

    /// <summary>
    /// Adds a category profile to the user's favourites.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="profileId">The ID of the profile to add.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the updated favourite profiles.</returns>
    Task<FavouriteProfilesDTO> AddCategoryProfileToFavouritesAsync(string userId, Guid profileId);

    /// <summary>
    /// Removes a category profile from the user's favourites.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="profileId">The ID of the profile to remove.</param>
    /// <returns>A task that represents the asynchronous operation. The task result indicates whether the removal was successful.</returns>
    Task<bool> RemoveCategoryProfileFromFavouritesAsync(string userId, Guid profileId);

    /// <summary>
    /// Adds a condition profile to the user's favourites.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="profileId">The ID of the profile to add.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the updated favourite profiles.</returns>
    Task<FavouriteProfilesDTO> AddConditionProfileToFavouritesAsync(string userId, Guid profileId);

    /// <summary>
    /// Removes a condition profile from the user's favourites.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="profileId">The ID of the profile to remove.</param>
    /// <returns>A task that represents the asynchronous operation. The task result indicates whether the removal was successful.</returns>
    Task<bool> RemoveConditionProfileFromFavouritesAsync(string userId, Guid profileId);

    /// <summary>
    /// Gets the user's favourite profiles.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the user's favourite profiles.</returns>
    Task<FavouriteProfilesDTO> GetFavouriteProfilesAsync(string userId);
}