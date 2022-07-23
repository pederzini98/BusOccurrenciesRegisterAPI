using BusOcurrenciesAPI.Entities;
using MongoDB.Driver;

namespace BusOcurrenciesAPI.Business
{
    public class BusManager : IBusManager
    {
        private readonly IMongoCollection<Bus> collection;
        public BusManager(IMongoCollection<Bus> collection)
        {
            this.collection = collection;
        }
        public async Task<bool> CreateBus(Bus bus)
        {
            try
            {
                await collection.InsertOneAsync(bus);
                return true;
            }
            catch (Exception)
            {

                return false;
            };
        }

        public async Task<bool> DeleteBus(string id)
        {
            try
            {
                await collection.FindOneAndDeleteAsync(X => X.Id == id);
                return true;
            }
            catch (Exception)
            {

                return false;

            };
        }

        public async Task<bool> EditBus(string userId, Bus bus)
        {
            try
            {
                await DeleteBus(userId);
                return await CreateBus(bus);
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<Bus> GetBus(string id)
        {
            try
            {
                IAsyncCursor<Bus> cursor = await collection.FindAsync(x => x.Id == id);
                Bus bus = await cursor.FirstAsync();
                return bus;
            }
            catch (Exception)
            {

                return new Bus();
            };
        }
        public async Task<List<Bus>> FindBusByCompany(string companyId)
        {
            try
            {
                var result = await collection.FindAsync(x => x.CompanyId == companyId).GetAwaiter().GetResult().ToListAsync();
                return result;
            }
            catch (Exception)
            {

                return new List<Bus>();
            }
        }
        public async Task<List<Bus>> FindBusByStopPlace(string stopPlace)
        {
            try
            {
                List<Bus> buses = new();
                var result = await collection.FindAsync(x => x.CompanyId == stopPlace).GetAwaiter().GetResult().ToListAsync();

                foreach (var item in result)
                {
                    if ((item.StopPlaces is not null) && (item.StopPlaces.Any() && item.StopPlaces.Contains(stopPlace)))
                    {
                        buses.Add(item);
                    }
                }
                return buses;
            }
            catch (Exception)
            {

                return new List<Bus>();
            }
        }
    }
}
