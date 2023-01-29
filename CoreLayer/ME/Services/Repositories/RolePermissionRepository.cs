using CoreLayer.Generic.GenericRepository;
using CoreLayer.Services.Contracts;
using DataLayer.Context;
using DataLayer.Entities.Roles;

namespace CoreLayer.Services.Repositories
{
    public class RolePermissionRepository : Repository<long, RolePermission>, IRolePermissionRepository
    {
        private readonly ChatRoomDbContext _context;

        public RolePermissionRepository(ChatRoomDbContext context) : base(context)
        {
            _context = context;
        }
    }

}
