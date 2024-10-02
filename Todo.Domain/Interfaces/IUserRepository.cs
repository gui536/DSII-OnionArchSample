using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetByIdAsync(int id);
        Task<int> InsertAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync(int id);
    }
}
