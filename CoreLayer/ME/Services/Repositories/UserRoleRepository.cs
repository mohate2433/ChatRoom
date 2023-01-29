using CoreLayer.Generic.GenericRepository;
using CoreLayer.Services.Contracts;
using DataLayer.Context;
using DataLayer.Entities.Users;

namespace CoreLayer.Services.Repositories
{
    public class UserRoleRepository : Repository<long, UserRole>, IUserRoleRepository
    {
        private readonly ChatRoomDbContext _context;

        public UserRoleRepository(ChatRoomDbContext context) : base(context)
        {
            _context = context;
        }
    }

}
