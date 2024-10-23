using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    internal interface IChoreService
    {
        Task<IEnumerable<ChoreDTO>> GetChores();
        Task<ChoreDTO> GetById(int? id);
        Task<IEnumerable<ChoreDTO>> GetByUserId(int? UserId);
        Task Add(ChoreDTO chore);
        Task Update(ChoreDTO chore);
        Task Remove(ChoreDTO chore);
    }
}
