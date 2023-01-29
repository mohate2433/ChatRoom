using CoreLayer.New.ViewModels.Auth;
using CoreLayer.Utilities.Security;
using DataLayer.Context;
using DataLayer.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.New.UserServices
{
    public class UserService : BaseService, IUserService
    {
        public UserService(ChatRoomDbContext context) : base(context)
        {
        }

        public async Task<bool> IsUserExists(string username)
        {
            return Table<User>().Any(u => u.UserName == username.ToLower());
        }

        public async Task<bool> IsUserExists(long ID)
        {
            return Table<User>().Any(u => u.ID == ID);
        }

        public async Task<User> LoginUser(LoginViewModel login)
        {
            var user =  Table<User>().FirstOrDefault(f => f.UserName == login.UserName.ToLower());
            if (user == null)
                return null;
            var password = login.Password.EncodePasswordMd5();
            if (password != user.Password)
                return null;
            return user;
        }

        public async Task<bool> RegisterUser(RegisterViewModel register)
        {
            if (await IsUserExists(register.UserName))
                return false;
            if (register.Password != register.RePassword)
                return false;
            var password = register.Password.EncodePasswordMd5();
            var user = new User()
            {
                Avatar = "default.jpg",
                CreateDate = DateTime.Now,
                UserName = register.UserName,
                Password = password
            };
            Insert(user);
            await Save();
            return true;
        }
    }
}
