using MediatR;

namespace Aplication.service.HumanData.Commands;

public class DeletePersonCommand : IRequest<Unit>
{
    public Guid Id { get; set; }
}