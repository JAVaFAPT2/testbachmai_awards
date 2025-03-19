using Domain.Interface;
using Domain.Models;
using Infastructure.Persitance.DbContext;
using MongoDB.Driver;

namespace Infastructure.Persitance.repository;

public class PersonRepository : IPersonRepository
{
    private readonly IMongoCollection<Person> _peopleCollection;

    public PersonRepository(BachAwardDbContext dbContext)
    {
        _peopleCollection = dbContext.People;

        // Create an index on Emails.Address if it doesn't exist
        var indexKeys = Builders<Person>.IndexKeys.Ascending(p => p.Emails.First().Address);
        var indexOptions = new CreateIndexOptions<Person>
        {
            Unique = true // Set to true if you want to ensure uniqueness of email addresses
        };

        // Ensure index creation is awaited
        _peopleCollection.Indexes.CreateOneAsync(new CreateIndexModel<Person>(indexKeys, indexOptions)).GetAwaiter()
            .GetResult();
    }

    public async Task<Person> GetByIdAsync(Guid id)
    {
        return await _peopleCollection.Find(p => p.Id == id).FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<Person>> GetAllAsync()
    {
        return await _peopleCollection.Find(p => true).ToListAsync();
    }

    public async Task AddAsync(Person person)
    {
        await _peopleCollection.InsertOneAsync(person);
    }

    public async Task UpdateAsync(Person person)
    {
        var filter = Builders<Person>.Filter.Eq(p => p.Id, person.Id);
        var update = Builders<Person>.Update
            .Combine(
                Builders<Person>.Update.Set(p => p.Name, person.Name),
                Builders<Person>.Update.Set(p => p.Avatar, person.Avatar),
                Builders<Person>.Update.Set(p => p.Background, person.Background),
                Builders<Person>.Update.Set(p => p.Title, person.Title),
                Builders<Person>.Update.Set(p => p.Company, person.Company),
                Builders<Person>.Update.Set(p => p.Address, person.Address),
                Builders<Person>.Update.Set(p => p.Notes, person.Notes),
                Builders<Person>.Update.Set(p => p.Emails, person.Emails),
                Builders<Person>.Update.Set(p => p.PhoneNumbers, person.PhoneNumbers) // Fixed line
            );

        await _peopleCollection.UpdateOneAsync(filter, update);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _peopleCollection.DeleteOneAsync(p => p.Id == id);
    }
}