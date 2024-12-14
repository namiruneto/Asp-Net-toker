using BackEnd.Entities.Requests.User;
using BackEnd.Entities.Responses;

namespace BackEnd.Application.Interfaces
{
    /// <summary>
    /// Defines the contract for user-related services.
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Registers a new user by processing the registration request.
        /// </summary>
        /// <param name="registerRequest">The user registration data.</param>
        /// <returns>A response indicating the success or failure of the registration process.</returns>
        ResponseDto Register(RegisterRequestDto registerRequest);

    }
}
