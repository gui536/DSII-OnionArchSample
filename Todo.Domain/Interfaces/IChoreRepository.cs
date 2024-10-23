using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IChoreRepository
    {
        Task<Chore?> GetByIdAsync(int? id);
        Task<IEnumerable<Chore?>> GetAll();
        Task<IEnumerable<Chore?>> GetAllByUserId(int? userId);
        Task<int> InsertAsync(Chore chore);
        Task UpdateAsync(Chore chore);
        Task DeleteAsync(Chore chore);
    }
}
