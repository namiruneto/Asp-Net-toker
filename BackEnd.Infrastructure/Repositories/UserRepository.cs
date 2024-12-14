using BackEnd.Entities.Requests.User;
using BackEnd.Infrastructure.Interfaces;

namespace BackEnd.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        // In-memory list to store user data.
        private static List<RegisterRequestDto> _users;

        /// <summary>
        /// Sends a welcome notification to the user.
        /// </summary>
        /// <param name="registerRequest">User registration data.</param>
        /// <returns>True if the notification was sent successfully.</returns>
        public bool NotificationUser(RegisterRequestDto registerRequest)
        {
            Console.WriteLine($"Notificación: Usuario {registerRequest.Name}, bienvenido a su aplicación favorita.");
            return true;
        }

        /// <summary>
        /// Saves the user registration data to an in-memory list.
        /// </summary>
        /// <param name="registerRequest">User registration data.</param>
        /// <returns>True if the user was saved successfully.</returns>
        public bool SaveUser(RegisterRequestDto registerRequest)
        {
            if(_users == null)
            {
                _users = new List<RegisterRequestDto>();
            }
            _users.Add(registerRequest);        
            return true;
        }
    }
}
