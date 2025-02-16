using MediatR;
using MongoDB.Driver;
using System.Threading.Tasks;
using Domain.Models;
using Application.Features.Humans.Queries;


namespace Application.Features.People.Queries
{
    public class GetAllPeopleQueryHandler : IRequestHandler<GetAllPeoplesQueries, IEnumerable<Person>>
    {
        private readonly IMongoCollection<Person> _peopleCollection;

        public GetAllPeopleQueryHandler(IMongoCollection<Person> peopleCollection)
        {
            _peopleCollection = peopleCollection;
        }

        public async Task<IEnumerable<Person>> Handle(GetAllPeoplesQueries query, CancellationToken cancellationToken = default)
        {
            var people = await _peopleCollection.Find(_ => true).ToListAsync(cancellationToken);
            return people;
        }
    }
}