using BackEnd.Domain.Services;
using BackEnd.Entities.Requests.User;
using BackEnd.Entities.Responses;
using BackEnd.Infrastructure.Interfaces;
using Moq;
using Xunit;
using FluentAssertions;

namespace BackEnd.Domain.Tests
{
    public class UserDomainServicesTests
    {
        private readonly Mock<IUserRepository> _mockUserRepository;
        private readonly UserDomainServices _userDomainServices;

        public UserDomainServicesTests()
        {
            _mockUserRepository = new Mock<IUserRepository>();
            _userDomainServices = new UserDomainServices();
        }

        [Fact]
        public void Register_ShouldReturnSuccess_WhenUserSavedSuccessfully()
        {
            // Arrange
            var registerRequest = new RegisterRequestDto { Name = "John", Phone = "123456789" };
            var expectedResponse = new ResponseDto { Success = true };

            _mockUserRepository.Setup(r => r.SaveUser(registerRequest)).Returns(true);
            _mockUserRepository.Setup(r => r.NotificationUser(registerRequest)).Returns(true);

            // Act
            var result = _userDomainServices.Register(registerRequest);

            // Assert
            result.Success.Should().BeTrue();
        }        
    }
}
