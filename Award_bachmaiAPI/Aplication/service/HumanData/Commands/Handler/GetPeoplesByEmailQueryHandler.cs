using Aplication.service.HumanData.Queries;
using Domain.Models;
using MediatR;
using MongoDB.Driver;

namespace Aplication.service.HumanData.Commands.Handler;

public class GetPeoplesByEmailQueryHandler(IMongoCollection<Person> peopleCollection)
    : IRequestHandler<GetPeoplesByEmailQuery, Person?>
{
    private readonly IMongoCollection<Person> _peopleCollection = peopleCollection;

    public async Task<Person?> Handle(GetPeoplesByEmailQuery query, CancellationToken cancellationToken)
    {
        // Correctly filter to check if any email matches the provided address
        var filter = Builders<Person>.Filter.ElemMatch(p => p.Emails, e => e.Address == query.Email);
        var person = await _peopleCollection.Find(filter).FirstOrDefaultAsync(cancellationToken);

        return person;
    }
}