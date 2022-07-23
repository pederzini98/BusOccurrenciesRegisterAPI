using BusOcurrenciesAPI.Entities;

namespace BusOcurrenciesAPI.Business
{
    public interface IDataAccess
    {
        #region User

        bool CheckServer();
        Task<bool> CreateUserAsync(User user);
        Task<User> FindUserById(string id);
        Task<bool> DeleteUserById(string id);
        Task<User> FindUserByLogin(string email, string password);
        Task<bool> UpdateUser(string userId, User newUser);
        #endregion
    }
}
