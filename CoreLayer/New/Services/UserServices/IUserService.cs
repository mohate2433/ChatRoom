using CoreLayer.New.ViewModels.Auth;
using DataLayer.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.New.UserServices
{
    public interface IUserService
    {
        Task<bool> IsUserExists(string username);
        Task<bool> IsUserExists(long ID);
        Task<bool> RegisterUser(RegisterViewModel register);
        Task<User> LoginUser(LoginViewModel login);
    }
}
