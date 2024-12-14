using BackEnd.Infrastructure.Repositories;
using BackEnd.Entities.Requests.User;
using Xunit;
using FluentAssertions;

namespace BackEnd.Infrastructure.Tests
{
    public class UserRepositoryTests
    {
        private readonly UserRepository _userRepository;

        public UserRepositoryTests()
        {
            _userRepository = new UserRepository();
        }

        [Fact]
        public void SaveUser_ShouldReturnTrue_WhenUserIsSaved()
        {
            // Arrange
            var registerRequest = new RegisterRequestDto { Name = "John", Phone = "123456789" };

            // Act
            var result = _userRepository.SaveUser(registerRequest);

            // Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void NotificationUser_ShouldReturnTrue_WhenUserIsNotified()
        {
            // Arrange
            var registerRequest = new RegisterRequestDto { Name = "John", Phone = "123456789" };

            // Act
            var result = _userRepository.NotificationUser(registerRequest);

            // Assert
            result.Should().BeTrue();
        }
    }
}
