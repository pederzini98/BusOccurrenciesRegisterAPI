using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace BusOcurrenciesAPI.Entities
{

    [BsonIgnoreExtraElements]
    public class Company
    {
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        [BsonId]
        [BsonElement(CBson.Id)][JsonIgnore] public string? Id { get; set; }
        [BsonElement(CBson.Name)] public string? Name { get; set; }
        [BsonElement(CBson.Email)] public string? Email { get; set; }
        [BsonElement(CBson.Password)] public  string? Password { get; set; }
        [BsonElement(CBson.Occurrencies)][BsonIgnoreIfNull] public List<string>? Occurrencies { get; set; }
        [BsonElement(CBson.Fleet)][BsonIgnoreIfNull] public List<string>? Fleet { get; set; }

      
    }
    public static class CBson
    {
        public const string Id = "_id";
        public const string Name = "name";
        public const string Email = "email";
        public const string Password = "password";
        public const string Occurrencies = "ocurrencis";
        public const string Fleet = "fleet";

    }
}
