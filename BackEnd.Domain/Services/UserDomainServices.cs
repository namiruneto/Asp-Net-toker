using BackEnd.Domain.Interfaces;
using BackEnd.Entities.Requests.User;
using BackEnd.Entities.Responses;
using BackEnd.Infrastructure.Interfaces;
using BackEnd.Infrastructure.Repositories;

namespace BackEnd.Domain.Services
{
    /// <summary>
    /// Provides services related to user operations in the domain layer.
    /// </summary>
    public class UserDomainServices : IUser
    {
        /// <summary>
        /// Registers a new user by saving their information and sending a notification.
        /// </summary>
        /// <param name="registerRequest">The user registration information.</param>
        /// <returns>A response indicating the success or failure of the registration.</returns>
        public ResponseDto Register(RegisterRequestDto registerRequest)
        {
            IUserRepository _userRepository = new UserRepository();

            bool save = false;
            if (_userRepository.SaveUser(registerRequest)) 
            {
                save = _userRepository.NotificationUser(registerRequest);
            }

            return new ResponseDto
            {
                Success = save,                
            };           
        }
    }
}
