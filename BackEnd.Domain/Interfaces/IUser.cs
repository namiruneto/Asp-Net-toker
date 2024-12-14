using BackEnd.Entities.Requests.User;
using BackEnd.Entities.Responses;

namespace BackEnd.Domain.Interfaces
{
    /// <summary>
    /// Interface for user-related operations in the domain layer.
    /// </summary>
    public interface IUser
    {
        /// <summary>
        /// Registers a new user.
        /// </summary>
        /// <param name="registerRequest">The user registration information.</param>
        /// <returns>A response indicating the success or failure of the registration.</returns>
        ResponseDto Register(RegisterRequestDto registerRequest);

    }
}
