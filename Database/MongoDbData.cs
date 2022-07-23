using BusOcurrenciesAPI.Entities;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core.Servers;

namespace BusOcurrenciesAPI.Database
{
    public class MongoDbData : IMongoDbData
    {

        private readonly MongoClient client;
        private readonly IMongoDatabase? database;
        private readonly IMongoCollection<User> userCollection;
        private readonly IMongoCollection<Bus> busCollection;
        private readonly IMongoCollection<Company> companyCollection;
        private readonly IMongoCollection<Occurrence> occurrenceCollection;

        public MongoDbData(IOptions<APIOptions> options)
        {
            client = new MongoClient(options.Value.ConnectionString);
            database = client.GetDatabase("test");
            userCollection = database.GetCollection<User>("user");
            busCollection = database.GetCollection<Bus>("bus");
            companyCollection = database.GetCollection<Company>("company");
            occurrenceCollection = database.GetCollection<Occurrence>("occurrence");

        }
        public bool ServerState()
        {

            database?.RunCommandAsync((Command<BsonDocument>)"{ping:1}")
                    .Wait();
            return true;
        }
        public IMongoCollection<Bus> GetBusCollection()
        {
            return busCollection;
        }
        public IMongoCollection<Company> GetCompanyCollection()
        {
            return companyCollection;
        }
        public IMongoCollection<User> GetUserCollection()
        {
            return userCollection;
        }
        public IMongoCollection<Occurrence> GetOccurrenceCollection()
        {
            return occurrenceCollection;
        }

    }
}
