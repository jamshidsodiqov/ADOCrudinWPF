using ADOCrud.Domain.Users;

namespace ADOCrud.Data.IRepositories
{
    internal interface IUserRepository
    {
        Task CreateAsync(User user);

        Task UpdateAsync(User user);

        Task DeleteAsync(int id);

        Task<IList<User>> GetAllAsync();

        Task<User> GetAsync(int id);
    }
}
