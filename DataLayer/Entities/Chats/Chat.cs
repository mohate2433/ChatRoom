using DataLayer.Entities.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.Chats
{
    public class Chat : BaseEntity
    {
        public string? ChatBody { get; set; }
        public long UserID { get; set; }
        public long ChatGroupID { get; set; }
        public User? User { get; set; }
        public ChatGroup? ChatGroup { get; set; }

    }
}
