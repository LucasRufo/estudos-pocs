using Microsoft.AspNetCore.Mvc;
using MongoPOC.Api.Controllers;
using MongoPOC.Api.Models;
using MongoPOC.Api.Repository.Interfaces;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace MongoPOC.Tests
{
    public class UserControllerTests
    {
        private readonly UserController _userController;
        private readonly Mock<IUserRepository> _mockUserRepository;

        public UserControllerTests()
        {
            _mockUserRepository = new Mock<IUserRepository>();
            _userController = new UserController(_mockUserRepository.Object);
        }

        [Fact]
        public async Task Get_ShouldBeOk()
        {
            //Arrange
            IEnumerable<User> list = new List<User>();
            _mockUserRepository.Setup(m => m.GetAsync()).Returns(Task.FromResult(list));

            //Act
            var actionResult = await _userController.Get();
            var result = actionResult as OkObjectResult;

            //Assert
            Assert.Equal(200, result.StatusCode);
        }

        [Fact]
        public async Task GetById_ShouldBeOk()
        {
            //Arrange
            User user = new();
            _mockUserRepository.Setup(m => m.GetByIdAsync(It.IsAny<string>())).Returns(Task.FromResult(user));

            //Act
            var actionResult = await _userController.Get(It.IsAny<string>());
            var result = actionResult as OkObjectResult;

            //Assert
            Assert.Equal(200, result.StatusCode);
        }

        [Fact]
        public async Task GetById_NonExistingUser_ShouldHaveError()
        {
            //Arrange
            User user = null;
            _mockUserRepository.Setup(m => m.GetByIdAsync(It.IsAny<string>())).Returns(Task.FromResult(user));

            //Act
            var actionResult = await _userController.Get(It.IsAny<string>());
            var result = actionResult as NotFoundResult;

            //Assert
            Assert.Equal(404, result.StatusCode);
        }

        [Fact]
        public async Task Post_ShouldBeOk()
        {
            //Arrange
            Return ret = new();
            _mockUserRepository.Setup(m => m.InsertAsync(It.IsAny<User>())).Returns(Task.FromResult(ret));

            //Act
            var actionResult = await _userController.Post(It.IsAny<User>());
            var result = actionResult as OkObjectResult;

            //Assert
            Assert.Equal(200, result.StatusCode);
        }

        [Fact]
        public async Task Post_InvalidUser_ShouldHaveError()
        {
            //Arrange
            Return ret = new("Error", "Error message");
            _mockUserRepository.Setup(m => m.InsertAsync(It.IsAny<User>())).Returns(Task.FromResult(ret));

            //Act
            var actionResult = await _userController.Post(It.IsAny<User>());
            var result = actionResult as BadRequestObjectResult;

            //Assert
            Assert.Equal(400, result.StatusCode);
        }

        [Fact]
        public async Task Put_ShouldBeOk()
        {
            //Arrange
            Return ret = new();
            User user = new() { Id = "abc" };
            _mockUserRepository.Setup(m => m.UpdateAsync(It.IsAny<string>(), It.IsAny<User>())).Returns(Task.FromResult(ret));

            //Act
            var actionResult = await _userController.Put("abc", user);
            var result = actionResult as OkObjectResult;

            //Assert
            Assert.Equal(200, result.StatusCode);
        }

        [Fact]
        public async Task Put_InvalidId_ShouldHaveError()
        {
            //Arrange
            User user = new() { Id = "xyz" };

            //Act
            var actionResult = await _userController.Put("abc", user);
            var result = actionResult as BadRequestResult;

            //Assert
            Assert.Equal(400, result.StatusCode);
        }

        [Fact]
        public async Task Put_InvalidUser_ShouldHaveError()
        {
            //Arrange
            Return ret = new("Error", "Error message");
            User user = new() { Id = "abc" };
            _mockUserRepository.Setup(m => m.UpdateAsync(It.IsAny<string>(), It.IsAny<User>())).Returns(Task.FromResult(ret));

            //Act
            var actionResult = await _userController.Put("abc", user);
            var result = actionResult as BadRequestObjectResult;

            //Assert
            Assert.Equal(400, result.StatusCode);
        }

        [Fact]
        public async Task Delete_ShouldHaveError()
        {
            //Arrange
            Return ret = new();
            _mockUserRepository.Setup(m => m.DeleteAsync(It.IsAny<string>())).Returns(Task.FromResult(ret));

            //Act
            var actionResult = await _userController.Delete("abc");
            var result = actionResult as OkObjectResult;

            //Assert
            Assert.Equal(200, result.StatusCode);
        }

        [Fact]
        public async Task Delete_UserNotFound_ShouldHaveError()
        {
            //Arrange
            Return ret = new("Error", "Error message");
            _mockUserRepository.Setup(m => m.DeleteAsync(It.IsAny<string>())).Returns(Task.FromResult(ret));

            //Act
            var actionResult = await _userController.Delete("abc");
            var result = actionResult as BadRequestObjectResult;

            //Assert
            Assert.Equal(400, result.StatusCode);
        }
    }
}