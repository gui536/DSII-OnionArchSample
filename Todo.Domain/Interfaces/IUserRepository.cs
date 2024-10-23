using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetByIdAsync(int? id);
        Task<IEnumerable<User?>> GetAll();
        Task<int> InsertAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync(User user);
    }
}
