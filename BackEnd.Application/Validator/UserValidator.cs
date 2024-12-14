using BackEnd.Entities.Requests.User;
using FluentValidation;

namespace BackEnd.Application.Validator
{
    /// <summary>
    /// Validator for the user registration DTO.
    /// Inherits from <see cref="AbstractValidator{T}"/> to define validation rules for <see cref="RegisterRequestDto"/>.
    /// </summary>
    internal class UserValidator : AbstractValidator<RegisterRequestDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserValidator"/> class.
        /// Defines the validation rules for the user registration DTO.
        /// </summary>
        public UserValidator()
        {
            // Regla de validación para el campo Name.
            RuleFor(user => user.Name)
              .NotNull()
              .NotEmpty();

            // Regla de validación para el campo Phone.
            RuleFor(user => user.Phone)
              .NotNull()
              .NotEmpty();

        }
    }
}
