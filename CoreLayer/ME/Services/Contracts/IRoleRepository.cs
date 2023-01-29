using CoreLayer.Generic.Contract;
using DataLayer.Entities.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Services.Contracts
{
    public interface IRoleRepository : IRepository<long , Role>
    {
    }
}
