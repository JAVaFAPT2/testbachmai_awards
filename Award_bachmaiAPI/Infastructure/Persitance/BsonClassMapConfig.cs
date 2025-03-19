using Domain.models;
using Domain.Models;
using MongoDB.Bson.Serialization;

namespace Infastructure.Persitance;

public static class BsonClassMapConfig
{
    public static void RegisterClassMaps()
    {
        // Register Person class map
        BsonClassMap.RegisterClassMap<Person>(classMap =>
        {
            classMap.AutoMap();
            classMap.MapIdField(p => p.Id); // Remove the custom serializer for Guid?

            // Map other properties
            classMap.MapMember(p => p.Emails); // Automatically handles List<Email>
            classMap.MapMember(p => p.PhoneNumbers); // Automatically handles List<PhoneNumber>
            classMap.MapMember(p => p.TagIds); // Automatically handles List<string>
            classMap.MapMember(p => p.Address);
            classMap.MapMember(p => p.Avatar);
            classMap.MapMember(p => p.Company);
            classMap.MapMember(p => p.CountryId);
            classMap.MapMember(p => p.Background);
            classMap.MapMember(p => p.Birthday);
            classMap.MapMember(p => p.Notes);
            classMap.MapMember(p => p.Name);
            classMap.MapMember(p => p.Title);
            classMap.AddKnownType(typeof(Person));
        });

        // Register Email class map
        BsonClassMap.RegisterClassMap<Email>(cm => { cm.AutoMap(); });

        // Register PhoneNumber class map
        BsonClassMap.RegisterClassMap<PhoneNumber>(cm => { cm.AutoMap(); });

        // Register Country class map
        BsonClassMap.RegisterClassMap<Country>(cm => { cm.AutoMap(); });

        // Register Tag class map
        BsonClassMap.RegisterClassMap<Tag>(cm => { cm.AutoMap(); });
    }
}