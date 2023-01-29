using DataLayer.Entities.Chats;
using DataLayer.Entities.Roles;
using DataLayer.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Context
{
    public class ChatRoomDbContext : DbContext
    {
        public ChatRoomDbContext(DbContextOptions<ChatRoomDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<ChatGroup> ChatGroups { get; set; }
    }
}
