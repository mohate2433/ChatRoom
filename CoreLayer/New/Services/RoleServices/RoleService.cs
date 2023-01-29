using DataLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.New.RoleServices
{
    public class RoleService : BaseService, IRoleService
    {
        public RoleService(ChatRoomDbContext context) : base(context)
        {
        }
    }
}
