using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.DataAccess.Abstract;
using UserManagement.Entities;

namespace UserManagement.DataAccess.Concrete
{
    public class UserRepository : IUserRepository
    {
        UserDbContext context = new UserDbContext();
        public async Task CreateUser(User user)
        {
            context.Users.Add(user);
            await context.SaveChangesAsync();
        }

        public async Task DeleteUser(int id)
        {
            var delete =await GetUser(id);
            context.Users.Remove(delete);
            await context.SaveChangesAsync();
        }

        public async Task<User> GetUser(int id)
        {
            return await context.Users.FindAsync(id);
        }

        public async Task<List<User>> GetUsers()
        {
            return await context.Users.ToListAsync();
        }

        public async Task UpdateUser(User user)
        {
            context.Users.Update(user);
            await context.SaveChangesAsync();
        }
    }
}
