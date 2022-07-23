
using BusOcurrenciesAPI.Entities;

namespace BusOcurrenciesAPI.Business
{
    public interface IOccurrenceManager
    {
        Task<bool> CreateOccurrence(Occurrence occurrence);
        Task<Occurrence> GetOccurrence(string id);
        Task<List<Occurrence>> GetAllOccurrenceOfCompany(string comapnyId);
        Task<List<Occurrence>> GetAllOccurrenceOfUser(string userId);
        Task<bool> DeleteOccurrence(string id);
        Task<bool> EditOccurrence(string occurrenceId, Occurrence occurrence);
    }
}
