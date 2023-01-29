using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.Roles
{
    public class Role : BaseEntity
    {
        [MaxLength(50)]
        public string? Title { get; set; }
    }
}
