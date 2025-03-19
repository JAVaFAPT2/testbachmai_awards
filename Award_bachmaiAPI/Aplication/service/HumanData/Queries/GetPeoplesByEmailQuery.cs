using Domain.Models;
using MediatR;

namespace Aplication.service.HumanData.Queries;

public class GetPeoplesByEmailQuery(string email) : IRequest<Person?>
{
    public string Email { get; set; } = email;
}