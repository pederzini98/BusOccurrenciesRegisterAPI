using BusOcurrenciesAPI.Database;
using BusOcurrenciesAPI.Entities;
using Microsoft.Extensions.Options;

namespace BusOcurrenciesAPI.Business
{
    public class DataAccess : IDataAccess
    {
        private readonly IMongoDbData mongo;
        private readonly UserManager userManager;
        private readonly CompanyManager companyManager;
        public DataAccess(IMongoDbData mongo)
        {
            this.mongo = mongo;
            userManager = new(mongo.GetUserCollection());
            companyManager = new(mongo.GetCompanyCollection());
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

        #region Company
        public Task<bool> CreateCompanyAsync(Company company)
        {
            return companyManager.CreateCompany(company);
        }

        public Task<Company> FindCompanyById(string id)
        {
            return companyManager.GetCompany(id);
        }

        public Task<bool> DeleteCompanyById(string id)
        {
            return companyManager.DeleteCompany(id);
        }

        public Task<bool> UpdateCompany(string id, Company newCompany)
        {
            return companyManager.EditCompany(id, newCompany);
        }


        #endregion
    }
}
