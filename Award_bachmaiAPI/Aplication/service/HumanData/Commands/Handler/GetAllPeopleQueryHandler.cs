using Aplication.service.HumanData.Queries;
using Domain.Models;
using MediatR;
using MongoDB.Driver;

namespace Aplication.service.HumanData.Commands.Handler;

public class GetAllPeopleQueryHandler(IMongoCollection<Person> peopleCollection)
    : IRequestHandler<GetAllPeoplesQueries, IEnumerable<Person>>
{
    private readonly IMongoCollection<Person> _peopleCollection = peopleCollection;

    public async Task<IEnumerable<Person>> Handle(GetAllPeoplesQueries query,
        CancellationToken cancellationToken = default)
    {
        var people = await _peopleCollection.Find(_ => true).ToListAsync(cancellationToken);
        return people;
    }
}