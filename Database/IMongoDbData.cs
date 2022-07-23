using BusOcurrenciesAPI.Entities;
using MongoDB.Driver;

namespace BusOcurrenciesAPI.Database
{
    public interface IMongoDbData
    {
        bool ServerState();
        IMongoCollection<Bus> GetBusCollection();
        IMongoCollection<Company> GetCompanyCollection();
        IMongoCollection<User> GetUserCollection();
        IMongoCollection<Occurrence> GetOccurrenceCollection();
    }
}
