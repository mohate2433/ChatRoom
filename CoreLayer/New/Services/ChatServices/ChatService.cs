using DataLayer.Context;
using DataLayer.Entities.Chats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.New.ChatServices
{
    public class ChatService : BaseService, IChatService
    {
        public ChatService(ChatRoomDbContext context) : base(context)
        {
        }

        public async Task SendMessage(Chat chat)
        {
            Insert(chat);
            await Save();
        }
    }
}
