using DataLayer.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.Roles
{
    public class RolePermission : BaseEntity
    {
        public long RoleID { get; set; }
        public Permission? Permission { get; set; }
        public Role? Role { get; set; }

    }
}
