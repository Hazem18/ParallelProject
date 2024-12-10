using ParallelProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;
using ParallelProject.Data;
using ParallelProject.Services.IServices;

namespace ParallelProject.Services
{
    public class UserService : IUserService
    {
        private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

        public UserService(IDbContextFactory<ApplicationDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task RegisterAsync(User user)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                var existingUser = await context.Users.FirstOrDefaultAsync(u => u.Name == user.Name);
                if (existingUser != null)
                {
                    throw new Exception("User with this name already exists.");
                }

                context.Users.Add(user);
                await context.SaveChangesAsync();
            }
        }

        public async Task<bool> AuthenticateAsync(string name, string password)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                var user = await context.Users.FirstOrDefaultAsync(u => u.Name == name && u.Password == password);
                return user != null;
            }
        }

        public async Task<User> GetUserByIdAsync(int userId)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                return await context.Users.FindAsync(userId);
            }
        }

        // New method to fetch all users
        public async Task<List<User>> GetAllUsersAsync()
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                // Execute the query and return the result as a list to avoid issues with deferred execution
                return await context.Users.ToListAsync();
            }
        }

    }
}
