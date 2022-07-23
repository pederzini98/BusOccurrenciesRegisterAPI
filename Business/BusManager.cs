using BusOcurrenciesAPI.Entities;

namespace BusOcurrenciesAPI.Business
{
    public class BusManager : IBusManager
    {
        public Task<bool> CreateBus(Bus user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteBus(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditBus(string userId, Bus user)
        {
            throw new NotImplementedException();
        }

        public Task<Bus> GetBus(string Id)
        {
            throw new NotImplementedException();
        }
    }
}
