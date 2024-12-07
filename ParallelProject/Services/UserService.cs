using Microsoft.EntityFrameworkCore;
using ParallelProject.Data;
using ParallelProject.Models;
using ParallelProject.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelProject.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<bool> AuthenticateAsync(string username, string password)
        {
            return await _context.Users.AnyAsync(u => u.Name == username && u.Password == password);
        }

        public async Task RegisterAsync(User user)
        {

            Console.WriteLine($"Registering user {user.Name} on thread {Thread.CurrentThread.ManagedThreadId}");
            user.RoleId = 2;
                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();
            Console.WriteLine($"User {user.Name} registered successfully on thread {Thread.CurrentThread.ManagedThreadId}");
        }


    }

}
