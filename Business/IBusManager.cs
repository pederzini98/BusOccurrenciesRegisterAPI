using BusOcurrenciesAPI.Entities;

namespace BusOcurrenciesAPI.Business
{
    public interface IBusManager
    {
        Task<bool> CreateBus(Bus user);
        Task<Bus> GetBus(string Id);
        Task<bool> DeleteBus(string Id);
        Task<bool> EditBus(string userId, Bus user);
    }
}
