using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain.models;

public class Tag
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public required string Title { get; set; }
}