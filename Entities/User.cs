using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace BusOcurrenciesAPI.Entities
{
    [BsonIgnoreExtraElements]
    public class User
    {
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        [BsonId]
        [BsonElement(UBson.Id)][JsonIgnore] public string? Id { get; set; }
        [BsonElement(UBson.Name)] public string? Name { get; set; }
        [BsonElement(UBson.Email)] public string? Email { get; set; }
        [BsonElement(UBson.Password)] public string? Password { get; set; }
        [BsonElement(UBson.Company)] public bool? IsCompany { get; set; }
        [BsonElement(UBson.Occurrencies)][BsonIgnoreIfNull] public List<Occurrence>? Occurrence { get; set; }


    }
    public static class UBson
    {
        public const string Id = "_id";
        public const string Name = "name";
        public const string Email = "email";
        public const string Password = "password";
        public const string Occurrencies = "ocurrencis";
        public const string Company = "iscompany";

    }
}
