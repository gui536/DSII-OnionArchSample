using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories
{
    public class UserRepository : IUserRepository
    {
        private ApplicationDbContext _userContext;

        public UserRepository(ApplicationDbContext userContext)
        {
            _userContext = userContext;
        }

        public async Task DeleteAsync(User user)
        {
            _userContext.Remove(user);
            await _userContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<User?>> GetAll()
        {
            return await _userContext.Users.ToListAsync<User>();
        }

        public async Task<User?> GetByIdAsync(int? id)
        {
            return await _userContext.Users.FindAsync(id);
        }

        public async Task UpdateAsync(User user)
        {
            _userContext.Update(user);
            await _userContext.SaveChangesAsync();
        }
        
        public async Task<int>InsertAsync(User user)
        {
            _userContext.Add(user);
            await _userContext.SaveChangesAsync();
            return user.Id;
        }
    }
}
