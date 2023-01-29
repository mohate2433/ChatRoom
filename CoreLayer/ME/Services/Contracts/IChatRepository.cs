using CoreLayer.Generic.Contract;
using DataLayer.Entities.Chats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Services.Contracts
{
    public interface IChatRepository : IRepository<long, Chat>
    {
    }
}
