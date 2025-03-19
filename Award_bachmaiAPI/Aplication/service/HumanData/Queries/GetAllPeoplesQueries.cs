using Domain.Models;
using MediatR;

namespace Aplication.service.HumanData.Queries;

public class GetAllPeoplesQueries : IRequest<IEnumerable<Person>>
{
}