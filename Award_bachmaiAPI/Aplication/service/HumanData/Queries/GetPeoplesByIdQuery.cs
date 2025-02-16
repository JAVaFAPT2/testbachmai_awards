using MediatR;
using MongoDB.Driver;
using System.Threading.Tasks;
using System;
using Domain.Models;

namespace Application.Service.HumanData.Queries
{
    public class GetPeoplesByIdQuery : IRequest<Person>
    {
        public Guid Id { get; set; }

        public GetPeoplesByIdQuery(Guid id)
        {
            Id = id;
        }
    }

    
}