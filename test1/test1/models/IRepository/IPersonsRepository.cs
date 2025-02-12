using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using test1.Data;
using test1.models;

namespace test1.models.IRepository
{
    public interface IPersonsRepository
    {
        Task<List<Persons>> GetAllAsync();
        Task<Persons> GetByIdAsync(string id); // Change to string for ObjectId
        Task CreateAsync(Persons person);
        Task UpdateAsync(string id, Persons person); // Change to string for ObjectId
        Task DeleteAsync(string id); // Change to string for ObjectId
    }

    public class PersonsRepository : IPersonsRepository
    {
        private readonly IMongoCollection<Persons> _personsCollection;

        public PersonsRepository(MongoDbContext context) // Change here
        {
            _personsCollection = context.Persons;
        }

        public async Task<List<Persons>> GetAllAsync() =>
            await _personsCollection.Find(_ => true).ToListAsync();

        public async Task<Persons> GetByIdAsync(string id) =>
            await _personsCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Persons person) =>
            await _personsCollection.InsertOneAsync(person);

        public async Task UpdateAsync(string id, Persons person) =>
            await _personsCollection.ReplaceOneAsync(x => x.Id == id, person);

        public async Task DeleteAsync(string id) =>
            await _personsCollection.DeleteOneAsync(x => x.Id == id);
    }
}