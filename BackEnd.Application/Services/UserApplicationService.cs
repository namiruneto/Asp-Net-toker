using BackEnd.Application.Interfaces;
using BackEnd.Application.Validator;
using BackEnd.Domain.Interfaces;
using BackEnd.Entities.Requests.User;
using BackEnd.Entities.Responses;

namespace BackEnd.Application.Services
{
    public class UserApplicationService : IUserService
    {
        private readonly Lazy<IUser> _userDomain;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserApplicationService"/> class.
        /// </summary>
        /// <param name="userRepository">The user domain service injected via Lazy for deferred loading.</param>
        public UserApplicationService(Lazy<IUser> userRepository)
        {
            _userDomain = userRepository;
        }

        /// <summary>
        /// Registers a new user by validating the request and calling the domain service.
        /// </summary>
        /// <param name="registerRequest">The user registration data.</param>
        /// <returns>A response indicating the success or failure of the registration process.</returns>
        public ResponseDto Register(RegisterRequestDto registerRequest)
        {
            UserValidator validator = new();
            var resultValidation = validator.Validate(registerRequest);
            if (!resultValidation.IsValid)
            {
                return new ResponseDto
                {
                    Success = false,
                    Message = string.Join("\n", resultValidation.Errors.Select(e => e.ErrorMessage))
                };
            }

            var user = _userDomain.Value;
            ResponseDto result = user.Register(registerRequest);
            result.Message = result.Success ? "Se ha guardado los datos correctamente" : "Fallo al guardar los datos";
           
            return result;
        }

    }
}
