using BusOcurrenciesAPI.Entities;
using MongoDB.Driver;

namespace BusOcurrenciesAPI.Business
{
    public class OccurrenceManager : IOccurrenceManager
    {
        IMongoCollection<Occurrence> collection;
        public OccurrenceManager(IMongoCollection<Occurrence> collection)
        {
            this.collection = collection;
        }
        public async Task<bool> CreateOccurrence(Occurrence occurrence)
        {
            try
            {
                await collection.InsertOneAsync(occurrence);
                return true;
            }
            catch (Exception)
            {

                return false;

            };
        }

        public async Task<bool> DeleteOccurrence(string id)
        {
            try
            {
                await collection.DeleteOneAsync(x => x.Id == id);
                return true;
            }
            catch (Exception)
            {

                return false;
            };
        }

        public async Task<bool> EditOccurrence(string occurrenceId, Occurrence occurrence)
        {
            try
            {
                await DeleteOccurrence(occurrenceId);
                await CreateOccurrence(occurrence);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<Occurrence>> GetAllOccurrenceOfCompany(string comapnyId)
        {
            try
            {
                return await collection.FindAsync(x => x.IdCompany == comapnyId).GetAwaiter().GetResult().ToListAsync();
            }
            catch (Exception)
            {

                return new List<Occurrence>();
            };
        }

        public async Task<List<Occurrence>> GetAllOccurrenceOfUser(string userId)
        {
            try
            {
                return await collection.FindAsync(x => x.IdUsusario == userId).GetAwaiter().GetResult().ToListAsync();
            }
            catch (Exception)
            {

                return new List<Occurrence>();
            };
        }

        public async Task<Occurrence> GetOccurrence(string id)
        {
            try
            {
                return await collection.FindAsync(x => x.Id == id).GetAwaiter().GetResult().FirstAsync();
            }
            catch (Exception)
            {

                return new Occurrence();
            };
        }
    }
}
