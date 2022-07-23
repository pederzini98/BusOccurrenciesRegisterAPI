using BusOcurrenciesAPI.Entities;

namespace BusOcurrenciesAPI.Business
{
    public interface IUserManager
    {
        Task<bool> CreateUser(User user);
        Task<User> Login(string email, string password);
        Task<User> GetUser(string Id);
        Task<bool> DeleteUser(string Id);
        Task<bool> EditUser(string userId, User user);
    }
}
