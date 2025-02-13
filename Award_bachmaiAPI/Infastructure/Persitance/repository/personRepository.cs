using Domain.Interfaces;
using Domain.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly IMongoCollection<Person> _peopleCollection;

        public PersonRepository(BachAwardDbContext dbContext)
        {
            _peopleCollection = dbContext.People;
        }

        public async Task<Person> GetByIdAsync(Guid id)
        {
            return await _peopleCollection.Find(p => p.Id == id.ToString())
                              .FirstOrDefaultAsync();
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
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            var filter = Builders<Person>.Filter.Eq("_id", person.Id.ToString());
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            var update = Builders<Person>.Update
            .Combine(
                     Builders<Person>.Update.Set("Name", person.Name),
                     Builders<Person>.Update.Set("Avatar", person.Avatar),
                     Builders<Person>.Update.Set("Emails",person.Emails),
                     Builders<Person>.Update.Set("PhoneNumbers", person.PhoneNumbers)
                 // Set other fields as needed
                 );

            await _peopleCollection.UpdateOneAsync(filter, update);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _peopleCollection.DeleteOneAsync(p => p.Id == id.ToString());
        }
    }
}