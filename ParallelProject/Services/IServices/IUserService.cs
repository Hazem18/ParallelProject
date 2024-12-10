using ParallelProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelProject.Services.IServices
{
    public interface IUserService
    {
        Task RegisterAsync(User user);
        Task<bool> AuthenticateAsync(string email, string password);
        Task<User> GetUserByIdAsync(int userId);
        Task<List<User>> GetAllUsersAsync();
    }
}
