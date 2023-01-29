using DataLayer.Entities.Roles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.Users
{
    public class UserRole : BaseEntity
    {
        public long UserID { get; set; }
        public long RoleID { get; set; }
        public User? User { get; set; }
        public Role? Role { get; set; }
    }
}
