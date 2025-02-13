using Domain.models;
using Domain.Models;
using MongoDB.Driver;
using System;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class BachAwardDbContext
    {
        private readonly IMongoDatabase _database;

        public BachAwardDbContext(string connectionString)
        {
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase("BachAwardApi");
        }

        public IMongoCollection<Person> People => _database.GetCollection<Person>("people");
        public IMongoCollection<Country> Countries => _database.GetCollection<Country>("countries");
        public IMongoCollection<Domain.models.Tag> Tags => _database.GetCollection<Domain.models.Tag>("tags");
    }
}