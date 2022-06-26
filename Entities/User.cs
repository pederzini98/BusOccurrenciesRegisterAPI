using MongoDB.Bson.Serialization.Attributes;

namespace BusOcurrenciesAPI.Entities
{
    [BsonIgnoreExtraElements]
    public class User
    {
        [BsonElement(UBson.Id)] public string Id { get; set; }
        [BsonElement(UBson.Name)] public string Name { get; set; }
        [BsonElement(UBson.Email)] public  string Email { get; set; }
        [BsonElement(UBson.Password)] public string Password { get; set; }
        [BsonElement(UBson.Occurrencies)] public List<Occurrence> Occurrence { get; set; }

        public User()
        {

        }
    }
    public static class UBson
    {
        public const string Id = "_id";
        public const string Name = "name";
        public const string Email = "email";
        public const string Password = "password";
        public const string Occurrencies = "ocurrencis";

    }
}
