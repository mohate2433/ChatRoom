using CoreLayer.Generic.GenericRepository;
using CoreLayer.Services.Contracts;
using DataLayer.Context;
using DataLayer.Entities.Users;

namespace CoreLayer.Services.Repositories
{
    public class UserRepository : Repository<long, User>, IUserRepository
    {
        private readonly ChatRoomDbContext _context;

        public UserRepository(ChatRoomDbContext context) : base(context)
        {
            _context = context;
        }
    }

}
