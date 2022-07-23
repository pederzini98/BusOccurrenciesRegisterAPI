using BusOcurrenciesAPI.Entities;

namespace BusOcurrenciesAPI.Business
{
    public interface ICompanyManager
    {
        Task<bool> CreateCompany(Company user);
        Task<Company> GetCompany(string Id);
        Task<bool> DeleteCompany(string Id);
        Task<bool> EditCompany(string companyId, Company user);
    }
}
