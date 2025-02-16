using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using Domain.Interfaces;

namespace Aplication.service.HumanData.Commands.Handler
{
    public class DeletePersonCommandHandler : IRequestHandler<DeletePersonCommand, Unit>
    {
        private readonly IPersonRepository _personRepository;

        public DeletePersonCommandHandler(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task<Unit> Handle(DeletePersonCommand command, CancellationToken cancellationToken)
        {
            // Validate that Id is not empty
            if (command.Id == Guid.Empty)
            {
                throw new ArgumentException("Person Id cannot be empty.", nameof(command.Id));
            }

            // Call the repository to delete the person
            await _personRepository.DeleteAsync(command.Id);

            return Unit.Value; // Return Unit to indicate the operation was successful
        }
    }
}