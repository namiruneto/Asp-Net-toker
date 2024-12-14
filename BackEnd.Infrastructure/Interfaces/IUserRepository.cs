using BackEnd.Entities.Requests.User;

namespace BackEnd.Infrastructure.Interfaces
{
    /// <summary>
    /// Interface for user repository operations.
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Saves user registration data.
        /// </summary>
        /// <param name="registerRequest">User registration data.</param>
        /// <returns>True if the user was saved successfully.</returns>
        bool SaveUser(RegisterRequestDto registerRequest);

        /// <summary>
        /// Sends a welcome notification to the user.
        /// </summary>
        /// <param name="registerRequest">User registration data.</param>
        /// <returns>True if the notification was sent successfully.</returns>
        bool NotificationUser(RegisterRequestDto registerRequest);
    }
}
