using Microsoft.Extensions.Options;
using MongoDB.Driver;
using test1.models;

namespace test1.Data
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(IOptions<MongoDBSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            _database = client.GetDatabase(settings.Value.DatabaseName);
        }

        public IMongoCollection<Persons> Persons => _database.GetCollection<Persons>("Persons");
    }
}