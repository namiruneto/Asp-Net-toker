using Microsoft.AspNetCore.Mvc;
using BackEnd.Application.Interfaces;
using BackEnd.Entities.Requests.User;

namespace BackEnd.SocialClick.Presentation.Controllers
{
    /// <summary>
    /// Controller to manage user-related operations.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _authService;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserController"/> class.
        /// </summary>
        /// <param name="authService">The user authentication and registration service.</param>
        public UserController(IUserService authService)
        {
            _authService = authService;
        }

        /// <summary>
        /// Register user.
        /// </summary>
        /// <param name="registerRequest">The user registration data.</param>
        /// <returns>The authentication result.</returns>
        [HttpPost("Resgiter")]
        public IActionResult Resgiter([FromBody] RegisterRequestDto registerRequest)
        {
            if (registerRequest == null)
            {
                return BadRequest("Los datos de inicio de sesión son requeridos.");
            }

            var result = _authService.Register(registerRequest);
            if (result.Success)
            {
                return Ok(result);
            }
            return Unauthorized(result.Message);
        }
    }
}
