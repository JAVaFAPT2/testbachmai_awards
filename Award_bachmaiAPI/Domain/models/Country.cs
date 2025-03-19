using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain.models;

public class Country
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public required string Name { get; set; }
    public required string Code { get; set; }
    public required string FlagImagePosition { get; set; }
}