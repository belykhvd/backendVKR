using System;
using System.Threading.Tasks;
using Contracts.User;

namespace Urfu.Learn.Backend.Services
{
    public interface IUserService
    {
        Task<Guid> Save(User user);
        Task<User> Get(Guid id);
    }
}