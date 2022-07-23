using BusOcurrenciesAPI.Database;
using BusOcurrenciesAPI.Entities;
using Microsoft.Extensions.Options;

namespace BusOcurrenciesAPI.Business
{
    public class DataAccess : IDataAccess
    {
        private readonly IMongoDbData mongo;
        private readonly UserManager userManager;
        public DataAccess(IMongoDbData mongo)
        {
            this.mongo = mongo;
            userManager = new(mongo.GetUserCollection());
        }

        public bool CheckServer()
        {
            return mongo.ServerState();
        }

        #region User 

        public Task<bool> CreateUserAsync(User user)
        {
            return userManager.CreateUser(user);
        }

        public Task<User> FindUserById(string id)
        {
            return userManager.GetUser(id);
        }
        public Task<bool> DeleteUserById(string id)
        {
            return userManager.DeleteUser(id);
        }
        public Task<User> FindUserByLogin(string email, string password)
        {
            return userManager.Login(email, password);
        }
        public Task<bool> UpdateUser(string userId, User newUser)
        {
            return userManager.EditUser(userId, newUser);
        }
        #endregion
    }
}
