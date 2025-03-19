using Domain.Interface;
using MediatR;

namespace Aplication.service.HumanData.Commands.Handler;

public class DeletePersonCommandHandler(IPersonRepository personRepository) : IRequestHandler<DeletePersonCommand, Unit>
{
    private readonly IPersonRepository _personRepository =
        personRepository ?? throw new ArgumentNullException(nameof(personRepository));

    public async Task<Unit> Handle(DeletePersonCommand command, CancellationToken cancellationToken)
    {
        // Validate that Id is not empty
        if (command.Id == Guid.Empty) throw new ArgumentException("Person Id cannot be empty.", nameof(command));

        // Call the repository to delete the person
        await _personRepository.DeleteAsync(command.Id);

        return Unit.Value; // Return Unit to indicate the operation was successful
    }
}