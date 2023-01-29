using DataLayer.Entities.Chats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.New.ChatServices
{
    public interface IChatService
    {
        Task SendMessage(Chat chat);
    }
}
