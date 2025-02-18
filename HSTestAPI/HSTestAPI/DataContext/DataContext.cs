
using MongoDB.Driver;
using TestHsAPI.Models;


namespace Infastructure.Persitance.DbContext
{
    public class DbContext
    {
        private readonly IMongoDatabase _database;

        public DbContext(string connectionString)
        {
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase("Hs");
        }

      public IMongoCollection<Hs> Hs => _database.GetCollection<Hs>("Hs");
    }
}