using ADOCrud.Data.Contexts;
using ADOCrud.Data.IRepositories;
using ADOCrud.Domain.Users;

namespace ADOCrud.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DbContext dbContext;
        public UserRepository()
        {
            dbContext = new DbContext();
        }
        public async Task CreateAsync(User user)
        {
            await dbContext.ConnectionAsync($"INSERT INTO \"users\" (\"firstname\", \"lastname\", \"email\",\"password\" ) " +
                $"VALUES ('{user.FirstName}', '{user.LastName}', '{user.Email}','{user.Password}')");
        }


        public async Task DeleteAsync(int id)
        {
            await dbContext.ConnectionAsync($"DELETE FROM \"users\" WHERE id = {id};");
        }

        public async Task<IList<User>> GetAllAsync()
        {
            IList<User> users = new List<User>();
            var reader = await dbContext.ConnectionAsync("SELECT * FROM users;");

            while (reader.Read())
            {
                users.Add(new User
                {
                    Id = reader.GetInt32(0),
                    FirstName = reader.GetString(1),
                    LastName = reader.GetString(2),
                    Email = reader.GetString(3),
                    Password = reader.GetString(4),
                });
            }

            return users;
        }

        public async Task<User> GetAsync(int id)

        {
            User user = new User();

            var reader = await dbContext.ConnectionAsync($"SELECT * FROM users WHERE id = {id};");

            while (reader.Read())
            {
                user.Id = reader.GetInt32(0);
                user.FirstName = reader.GetString(1);
                user.LastName = reader.GetString(2);
                user.Email = reader.GetString(3);
                user.Password = reader.GetString(4);
            }

            return user;
        }

        public async Task UpdateAsync(User user)
        {
            await dbContext.ConnectionAsync($"UPDATE \"users\" SET" +
                $"\"firstname\" = '{user.FirstName}', " +
                $"\"lastname\" = '{user.LastName}', " +
                $"\"password\" = '{user.Password}', " +
                $"\"email\" = '{user.Email}' WHERE \"id\" = {user.Id}");

        }

        public async Task TruncateAsync()
        {
            string query = "TRUNCATE TABLE \"users\" ";
            await dbContext.ConnectionAsync(query);
        }
    }
}
