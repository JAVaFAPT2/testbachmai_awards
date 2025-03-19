using Aplication.service.HumanData.Queries;
using Domain.Models;
using MediatR;
using MongoDB.Driver;

namespace Aplication.service.HumanData.Commands.Handler;

public class GetPersonByIdQueryHandler(IMongoCollection<Person> peopleCollection)
    : IRequestHandler<GetPeoplesByIdQuery, Person>
{
    private readonly IMongoCollection<Person> _peopleCollection = peopleCollection;

    public async Task<Person> Handle(GetPeoplesByIdQuery query, CancellationToken cancellationToken = default)
    {
        // Using Find by Id, which should be indexed for better performance
        var filter = Builders<Person>.Filter.Eq(p => p.Id, query.Id); // Use Guid directly
        var person = await _peopleCollection.Find(filter)
            .SortByDescending(p => p.Birthday) // Sort by Birthday in descending order
            .FirstOrDefaultAsync(cancellationToken);

        return person;
    }
}