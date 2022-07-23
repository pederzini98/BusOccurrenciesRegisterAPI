using BusOcurrenciesAPI.Entities;
using MongoDB.Driver;

namespace BusOcurrenciesAPI.Business
{
    public class UserManager : IUserManager
    {
        private readonly IMongoCollection<User> collection;
        public UserManager(IMongoCollection<User> collection)
        {
            this.collection = collection;
        }

        public async Task<bool> CreateUser(User user)
        {
            try
            {
                await collection.InsertOneAsync(user);
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }
        public async Task<User> Login(string email, string password)
        {
            IAsyncCursor<User> cursor = await collection.FindAsync(user => user.Email == email && user.Password == password);
            User user = await cursor.FirstAsync();
            return user;
        }

        public async Task<User> GetUser(string Id)
        {
            IAsyncCursor<User> cursor = await collection.FindAsync(user => user.Id == Id);
            User user = await cursor.FirstAsync();
            return user;
        }
        public async Task<bool> DeleteUser(string Id)
        {
            await collection.FindOneAndDeleteAsync(user => user.Id == Id);

            return true;
        }
        public async Task<bool> EditUser(string userId, User user)
        {
            //  await _users.ReplaceOneAsync(x => x.Id == userId, user); --> Serialize Problem
            await collection.DeleteOneAsync(x => x.Id == userId);
            await CreateUser(user);

            return true;
        }
    }
}
