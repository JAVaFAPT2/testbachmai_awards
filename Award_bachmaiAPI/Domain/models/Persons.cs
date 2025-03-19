using Domain.models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Models;

public class Person
{
    [BsonId]
    [BsonRepresentation(BsonType.String)]
    public Guid? Id { get; set; }

    public required string Name { get; set; }
    public required string Avatar { get; set; }
    public required string Background { get; set; }
    public required string Title { get; set; }
    public required string Company { get; set; }
    public DateTime Birthday { get; set; }
    public required string Address { get; set; }
    public required string Notes { get; set; }

    [BsonRepresentation(BsonType.ObjectId)]
    public required string CountryId { get; set; }

    [BsonRepresentation(BsonType.ObjectId)]
    public required List<string> TagIds { get; set; }

    public required List<Email> Emails { get; set; }
    public required List<PhoneNumber> PhoneNumbers { get; set; }
}