using CoreLayer.Generic.GenericRepository;
using CoreLayer.Services.Contracts;
using DataLayer.Context;
using DataLayer.Entities.Chats;

namespace CoreLayer.Services.Repositories
{
    public class ChatGroupRepository : Repository<long, ChatGroup>, IChatGroupRepository
    {
        private readonly ChatRoomDbContext _context;

        public ChatGroupRepository(ChatRoomDbContext context) : base(context)
        {
            _context = context;
        }
    }

}
