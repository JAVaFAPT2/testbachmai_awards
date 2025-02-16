using MediatR;
using System;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Interfaces;

namespace Aplication.service.HumanData.Commands
{
    public class DeletePersonCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }

}