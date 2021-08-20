using MongoPOC.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MongoPOC.Api.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAsync();

        Task<User> GetByIdAsync(string id);

        Task<Return> InsertAsync(User user);

        Task<Return> UpdateAsync(string id, User user);

        Task<Return> DeleteAsync(string id);
    }
}