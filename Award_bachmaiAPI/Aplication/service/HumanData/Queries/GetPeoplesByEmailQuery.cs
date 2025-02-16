using MediatR;
using MongoDB.Driver;
using System.Threading.Tasks;
using Domain.Models;

namespace Application.Features.Humans.Queries
{
    public class GetPeoplesByEmailQuery(string email) : IRequest<Person?>
    {
        public string Email { get; set; } = email;
    }

    
}