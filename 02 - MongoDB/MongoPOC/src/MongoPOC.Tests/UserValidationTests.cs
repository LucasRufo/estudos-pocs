using MongoPOC.Api.Models;
using MongoPOC.Api.Validation;
using System.Collections.Generic;
using Xunit;

namespace MongoPOC.Tests
{
    public class UserValidationTests
    {
        private readonly UserValidation _userValidation;

        public UserValidationTests()
        {
            _userValidation = new UserValidation();
        }

        [Fact]
        public void UserValidation_ValidUser_ShouldBeOk()
        {
            //Arrange
            var user = new User()
            {
                Name = "Lucas Rufo de Oliveira",
                Emails = new List<Email>() { new Email() { Address = "email@email.com.br" } },
                Phones = new List<Phone>() { new Phone() { Number = "1199998888", PhoneType = PhoneType.Bussiness } },
                Address = new Address() { Street = "Av Paulista", City = "São Paulo", Country = "Brasil", ZipCode = "99988877" }
            };

            //Act
            var result = _userValidation.Validate(user);

            //Assert
            Assert.True(result.IsValid);
            Assert.Empty(result.Errors);
        }

        [Fact]
        public void UserValidation_EmptyName_ShouldHaveErrors()
        {
            //Arrange
            var user = new User()
            {
                Name = "",
                Emails = new List<Email>() { new Email() { Address = "email@email.com.br" } },
                Phones = new List<Phone>() { new Phone() { Number = "1199998888", PhoneType = PhoneType.Bussiness } },
                Address = new Address() { Street = "Av Paulista", City = "São Paulo", Country = "Brasil", ZipCode = "99988877" }
            };

            //Act
            var result = _userValidation.Validate(user);

            //Assert
            Assert.False(result.IsValid);
            Assert.NotEmpty(result.Errors);
        }

        [Fact]
        public void UserValidation_InvalidName_ShouldHaveErrors()
        {
            //Arrange
            var user = new User()
            {
                Name = new string('a', 101),
                Emails = new List<Email>() { new Email() { Address = "email@email.com.br" } },
                Phones = new List<Phone>() { new Phone() { Number = "1199998888", PhoneType = PhoneType.Bussiness } },
                Address = new Address() { Street = "Av Paulista", City = "São Paulo", Country = "Brasil", ZipCode = "99988877" }
            };

            //Act
            var result = _userValidation.Validate(user);

            //Assert
            Assert.False(result.IsValid);
            Assert.NotEmpty(result.Errors);
        }

        [Fact]
        public void UserValidation_EmptyEmails_ShouldHaveErrors()
        {
            //Arrange
            var user = new User()
            {
                Name = "Lucas Rufo de Oliveira",
                Emails = new List<Email>(),
                Phones = new List<Phone>() { new Phone() { Number = "1199998888", PhoneType = PhoneType.Bussiness } },
                Address = new Address() { Street = "Av Paulista", City = "São Paulo", Country = "Brasil", ZipCode = "99988877" }
            };

            //Act
            var result = _userValidation.Validate(user);

            //Assert
            Assert.False(result.IsValid);
            Assert.NotEmpty(result.Errors);
        }

        [Fact]
        public void UserValidation_InvalidEmails_ShouldHaveErrors()
        {
            //Arrange
            var user = new User()
            {
                Name = "Lucas Rufo de Oliveira",
                Emails = new List<Email>() { new Email() { Address = "" } },
                Phones = new List<Phone>() { new Phone() { Number = "1199998888", PhoneType = PhoneType.Bussiness } },
                Address = new Address() { Street = "Av Paulista", City = "São Paulo", Country = "Brasil", ZipCode = "99988877" }
            };

            //Act
            var result = _userValidation.Validate(user);

            //Assert
            Assert.False(result.IsValid);
            Assert.NotEmpty(result.Errors);
        }

        [Fact]
        public void UserValidation_EmptyPhones_ShouldHaveErrors()
        {
            //Arrange
            var user = new User()
            {
                Name = "Lucas Rufo de Oliveira",
                Emails = new List<Email>() { new Email() { Address = "email@email.com.br" } },
                Phones = new List<Phone>(),
                Address = new Address() { Street = "Av Paulista", City = "São Paulo", Country = "Brasil", ZipCode = "99988877" }
            };

            //Act
            var result = _userValidation.Validate(user);

            //Assert
            Assert.False(result.IsValid);
            Assert.NotEmpty(result.Errors);
        }

        [Fact]
        public void UserValidation_InvalidPhones_ShouldHaveErrors()
        {
            //Arrange
            var user = new User()
            {
                Name = "Lucas Rufo de Oliveira",
                Emails = new List<Email>() { new Email() { Address = "email@email.com.br" } },
                Phones = new List<Phone>() { new Phone() { Number = "", PhoneType = PhoneType.Bussiness } },
                Address = new Address() { Street = "Av Paulista", City = "São Paulo", Country = "Brasil", ZipCode = "99988877" }
            };

            //Act
            var result = _userValidation.Validate(user);

            //Assert
            Assert.False(result.IsValid);
            Assert.NotEmpty(result.Errors);
        }

        [Fact]
        public void UserValidation_EmptyAddress_ShouldHaveErrors()
        {
            //Arrange
            var user = new User()
            {
                Name = "Lucas Rufo de Oliveira",
                Emails = new List<Email>() { new Email() { Address = "email@email.com.br" } },
                Phones = new List<Phone>() { new Phone() { Number = "1199998888", PhoneType = PhoneType.Bussiness } },
                Address = new Address()
            };

            //Act
            var result = _userValidation.Validate(user);

            //Assert
            Assert.False(result.IsValid);
            Assert.NotEmpty(result.Errors);
        }
    }
}