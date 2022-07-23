using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace BusOcurrenciesAPI.Entities
{
    public enum OccurrenceType
    {
        Bus_Late = 1,
        Bus_Broke = 2,
        Bus_Full = 3
    }
    public class Occurrence
    {
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        [BsonId]
        [BsonElement(OBson.Id)][JsonIgnore] public string? Id { get; set; }
        [BsonElement(OBson.Name)] public string? Title { get; set; }
        [BsonElement(OBson.Description)] public string? Description { get; set; }
        [BsonElement(OBson.Type)] public OccurrenceType Type { get; set; }
        [BsonElement(OBson.IdUsusario)] public string? IdUsusario { get; set; }
        [BsonElement(OBson.IdCompany)] public string? IdCompany { get; set; }
        [BsonElement(OBson.IdBus)] public int BusNumber { get; set; }
        [BsonElement(OBson.CreationDate)] public DateTime CreationDate { get; set; }
        [BsonElement(OBson.Conclude)] public bool Conclude { get; set; }
        [BsonElement(OBson.Visualized)] public bool Visualized { get; set; }
        [BsonElement(OBson.Observation)] public string? Observation { get; set; }
    }
    public static class OBson
    {
        public const string Id = "_id";
        public const string Name = "name";
        public const string Description = "description";
        public const string Type = "type";
        public const string IdUsusario = "id_usuario";
        public const string IdCompany = "id_company";
        public const string IdBus = "id_bus";
        public const string CreationDate = "creation";
        public const string Conclude = "conclude";
        public const string Visualized = "visualized";
        public const string Observation = "observation";
    }
}
