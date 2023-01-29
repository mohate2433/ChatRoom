using CoreLayer.Generic.GenericRepository;
using CoreLayer.Services.Contracts;
using DataLayer.Context;
using DataLayer.Entities.Roles;

namespace CoreLayer.Services.Repositories
{
    public class RoleRepository : Repository<long, Role> , IRoleRepository
    {
        private readonly ChatRoomDbContext _context;

        public RoleRepository(ChatRoomDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
