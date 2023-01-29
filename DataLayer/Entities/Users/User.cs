using DataLayer.Entities.Chats;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.Users
{
    public class User:BaseEntity
    {
        [MaxLength(50)]
        public string? UserName { get; set; }
        [MinLength(6)]
        [MaxLength(50)]
        public string? Password { get; set; }
        [MaxLength(110)]
        public string? Avatar { get; set; }

        public ICollection<ChatGroup>? ChatGroups { get; set; }
        public ICollection<Chat>? Chats { get; set; }
        public ICollection<UserRole>? UserRoles { get; set; }
    }
}
