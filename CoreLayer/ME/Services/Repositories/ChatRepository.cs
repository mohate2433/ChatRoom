using CoreLayer.Generic.GenericRepository;
using CoreLayer.Services.Contracts;
using DataLayer.Context;
using DataLayer.Entities.Chats;

namespace CoreLayer.Services.Repositories
{
    public class ChatRepository : Repository<long, Chat>, IChatRepository
    {
        private readonly ChatRoomDbContext _context;

        public ChatRepository(ChatRoomDbContext context) : base(context)
        {
            _context = context;
        }
    }

}
