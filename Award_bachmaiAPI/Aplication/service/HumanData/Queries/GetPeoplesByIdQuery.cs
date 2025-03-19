using Domain.Models;
using MediatR;

namespace Aplication.service.HumanData.Queries;

public class GetPeoplesByIdQuery(Guid id) : IRequest<Person>
{
    public Guid Id { get; set; } = id;
}