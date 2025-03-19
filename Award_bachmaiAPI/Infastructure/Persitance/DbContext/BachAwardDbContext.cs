using Domain.models;
using Domain.Models;
using MongoDB.Driver;
using Tag = Domain.models.Tag;

namespace Infastructure.Persitance.DbContext;

public class BachAwardDbContext
{
    private readonly IMongoDatabase _database;

    public BachAwardDbContext(string connectionString)
    {
        var client = new MongoClient(connectionString);
        _database = client.GetDatabase("test");
    }

    public IMongoCollection<Person> People => _database.GetCollection<Person>("people");
    public IMongoCollection<Country> Countries => _database.GetCollection<Country>("countries");
    public IMongoCollection<Tag> Tags => _database.GetCollection<Tag>("tags");
}