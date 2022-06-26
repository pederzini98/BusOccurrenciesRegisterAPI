﻿using MongoDB.Bson.Serialization.Attributes;

namespace BusOcurrenciesAPI.Entities
{
    public class StopPlace
    {
        [BsonElement(STBson.Id)] public string Id { get; set; }
        [BsonElement(STBson.Street)] public string Street { get; set; }
        [BsonElement(STBson.Neighborhood)] public string Neighborhood { get; set; }
        [BsonElement(STBson.BusId)] public List<string> BusIds { get; set; }
     
    }
    [BsonIgnoreExtraElements]
    public class Bus
    {
        [BsonElement(BBson.Id)] public string Id { get; set; }
        [BsonElement(BBson.BusNumber)] public int BusNumber { get; set; }
        [BsonElement(BBson.CompanyId)] public string CompanyId { get; set; }
        [BsonElement(BBson.Passanger)] public string Passanger { get; set; }
        [BsonElement(BBson.Stops)] public List<StopPlace> StopPlaces { get; set; }

        public Bus()
        {

        }
    }
    public static class BBson
    {
        public const string Id = "_id";
        public const string BusNumber = "bus_number";
        public const string CompanyId = "company";
        public const string Passanger = "passangers";
        public const string Stops = "stops";

    }
    public static class STBson
    {
        public const string Id = "_id";
        public const string Street = "street";
        public const string Neighborhood = "neighborhood";
        public const string BusId = "bus_id";

    }
}