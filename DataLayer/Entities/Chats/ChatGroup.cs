using DataLayer.Entities.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.Chats
{
    public class ChatGroup : BaseEntity
    {
        [MaxLength(100)]
        public string? GroupTitle { get; set; }
        [MaxLength(110)]
        public string? GroupToken { get; set; }
        public long OwnerID { get; set; }
        public User? User { get; set; }
        public ICollection<Chat>? Chats { get; set; }
    }
}
