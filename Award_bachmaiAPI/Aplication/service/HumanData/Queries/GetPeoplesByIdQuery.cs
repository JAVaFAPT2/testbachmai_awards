using MediatR;
using MongoDB.Driver;
using System.Threading.Tasks;
using System;
using Domain.Models;

namespace Aplication.service.HumanData.Queries
{
    public class GetPeoplesByIdQuery(Guid id) : IRequest<Person>
    {
        public Guid Id { get; set; } = id;
    }


}