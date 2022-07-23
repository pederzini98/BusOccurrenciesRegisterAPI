using BusOcurrenciesAPI.Entities;
using MongoDB.Driver;

namespace BusOcurrenciesAPI.Business
{
    public class CompanyManager : ICompanyManager
    {
        private readonly IMongoCollection<Company> collection;
        public CompanyManager(IMongoCollection<Company> collection)
        {
            this.collection = collection;
        }
        public async Task<bool> CreateCompany(Company company)
        {
            try
            {
                await collection.InsertOneAsync(company);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> DeleteCompany(string id)
        {
            try
            {
                await collection.FindOneAndDeleteAsync(x => x.Id == id);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> EditCompany(string companyId, Company company)
        {
            try
            {
                await collection.DeleteOneAsync(x => x.Id == companyId);
                await CreateCompany(company);

                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<Company> GetCompany(string id)
        {
            try
            {
                IAsyncCursor<Company> cursor = await collection.FindAsync(x => x.Id == id);
                Company company = await cursor.FirstAsync();
                return company;

            }
            catch (Exception)
            {

                return new Company();
            }
        }
    }
}
