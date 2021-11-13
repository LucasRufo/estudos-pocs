using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;
using MongoPOC.Api.Extensions;
using MongoPOC.Api.Models;
using MongoPOC.Api.Repository.Interfaces;
using MongoPOC.Api.Validation;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MongoPOC.Api.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IMongoCollection<User> _usersCollection;

        public UserRepository(IMongoClient client)
        {
            var camelCaseConvention = new ConventionPack { new CamelCaseElementNameConvention() };
            ConventionRegistry.Register("CamelCase", camelCaseConvention, type => true);

            _usersCollection = client.GetDatabase("pocs").GetCollection<User>("users");
        }

        private IFindFluent<User, User> Get()
        {
            var filter = Builders<User>.Filter.Eq(m => m.IsActive, true);

            return _usersCollection.Find(filter);
        }

        public async Task<IEnumerable<User>> GetAsync()
        {
            return await Get().ToListAsync();
        }

        public async Task<User> GetByIdAsync(string id)
        {
            var filter = Builders<User>.Filter.Eq(m => m.Id, id);

            return await Get().FirstOrDefaultAsync();
        }

        public async Task<Return> InsertAsync(User user)
        {
            var validation = new UserValidation();
            var validationResult = validation.Validate(user);

            if (validationResult.IsValid == false)
                return new Return(validationResult.Errors.ToDictionary());

            user.IsActive = true;
            user.CreatedAt = DateTime.Now;

            await _usersCollection.InsertOneAsync(user);

            return new Return(await GetByIdAsync(user.Id));
        }

        public async Task<Return> UpdateAsync(string id, User user)
        {
            var validation = new UserValidation();
            var validationResult = validation.Validate(user);

            if (validationResult.IsValid == false)
                return new Return(validationResult.Errors.ToDictionary());

            var filter = Builders<User>.Filter.Eq(m => m.Id, id);

            var update = Builders<User>.Update
                .Set(m => m.Name, user.Name)
                .Set(m => m.Emails, user.Emails)
                .Set(m => m.Phones, user.Phones)
                .Set(m => m.Address, user.Address)
                .Set(m => m.UpdateAt, DateTime.Now);

            await _usersCollection.UpdateOneAsync(filter, update, new UpdateOptions());

            return new Return(await GetByIdAsync(user.Id));
        }

        public async Task<Return> DeleteAsync(string id)
        {
            if (string.IsNullOrEmpty(id))
                return new Return("Id", "User not found");

            var filter = Builders<User>.Filter.Eq(m => m.Id, id);

            var update = Builders<User>.Update
                .Set(m => m.IsActive, false)
                .Set(m => m.UpdateAt, DateTime.Now);

            //Example: Exclusion
            //await _usersCollection.DeleteOneAsync(filter);

            //Logical Exclusion
            await _usersCollection.UpdateOneAsync(filter, update, new UpdateOptions());

            return new Return(id);
        }
    }
}