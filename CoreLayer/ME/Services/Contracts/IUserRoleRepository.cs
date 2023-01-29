using CoreLayer.Generic.Contract;
using DataLayer.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Services.Contracts
{
    public interface IUserRoleRepository : IRepository<long, UserRole>
    {
    }
}
