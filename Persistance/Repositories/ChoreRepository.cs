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
    public class ChoreRepository : IChoreRepository
    {
        private ApplicationDbContext _choreContext;

        public ChoreRepository(ApplicationDbContext choreContext)
        {
            _choreContext = choreContext;
        }

        public async Task DeleteAsync(Chore chore)
        {
            _choreContext.Remove(chore);
            await _choreContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Chore?>> GetAll()
        {
            return await _choreContext.Chores.ToListAsync<Chore>();
        }

        public async Task<IEnumerable<Chore?>> GetAllByUserId(int? userId)
        {
            return await _choreContext.Chores
                .Where(chore => chore.AssignedToId == userId)
                .ToListAsync();
        }

        public async Task<Chore?> GetByIdAsync(int? id)
        {
            return await _choreContext.Chores.FindAsync(id);
        }

        public async Task<int> InsertAsync(Chore chore)
        {
            _choreContext.Add(chore);
            var result = await _choreContext.SaveChangesAsync();
            return chore.Id;
        }

        public async Task UpdateAsync(Chore chore)
        {
            _choreContext.Update(chore);
            await _choreContext.SaveChangesAsync();
        }
    }
}
