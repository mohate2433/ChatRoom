using CoreLayer.Generic.Contract;
using DataLayer.Entities.Users;

namespace CoreLayer.Services.Contracts
{
    public interface IUserRepository : IRepository<long, User>
    {
    }
}
