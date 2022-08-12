using BusOcurrenciesAPI.Entities;

namespace BusOcurrenciesAPI.Business
{
    public interface IBusManager
    {
        Task<bool> CreateBus(Bus user);
        Task<Bus> GetBus(int number);
        Task<bool> DeleteBus(string Id);
        Task<bool> EditBus(string userId, Bus user);

        Task<List<Bus>> FindBusByCompany(string companyId);
        Task<List<Bus>> FindBusByStopPlace(string stopPlace);

    }
}
