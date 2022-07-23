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

        #region Company
        Task<bool> CreateCompanyAsync(Company company);
        Task<Company> FindCompanyById(string id);
        Task<bool> DeleteCompanyById(string id);
        Task<bool> UpdateCompany(string id, Company newCompany);
        #endregion

        #region Bus
        Task<bool> CreateBus(Bus user);
        Task<Bus> GetBus(string Id);
        Task<bool> DeleteBus(string Id);
        Task<bool> EditBus(string userId, Bus user);

        Task<List<Bus>> FindBusByCompany(string companyId);
        Task<List<Bus>> FindBusByStopPlace(string stopPlace);
        #endregion

        #region Occurrence
        Task<bool> CreateOccurrence(Occurrence occurrence);
        Task<Occurrence> GetOccurrence(string id);
        Task<List<Occurrence>> GetAllOccurrenceOfCompany(string comapnyId);
        Task<List<Occurrence>> GetAllOccurrenceOfUser(string userId);
        Task<bool> DeleteOccurrence(string id);
        Task<bool> EditOccurrence(string userId, Occurrence occurrence);
        #endregion
    }
}
