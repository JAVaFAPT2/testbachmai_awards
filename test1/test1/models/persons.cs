using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.EntityFrameworkCore;
using System.Reflection;
using System.Text.Json.Serialization;

namespace test1.models
{
    [BsonIgnoreExtraElements]
    [Collection("Persons")]
    public class Persons
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        [BsonElement("name")]
        public required string Name { get; set; }
        [BsonElement("description")]
        public required string Description { get; set; }
        [BsonElement("BDay")]
        public DateTime BDay { get; set; }

        [BsonElement("Gender")]
        [JsonConverter(typeof(JsonStringEnumConverter))]  // System.Text.Json.Serialization
        [BsonRepresentation(BsonType.String)]         // MongoDB.Bson.Serialization.Attributes
        public Gender Gender { get; set; }
        [BsonElement("img_link")]
        public required string img { get; set; }
    }

    public enum Gender
    {
        Male,Female
    }
}
