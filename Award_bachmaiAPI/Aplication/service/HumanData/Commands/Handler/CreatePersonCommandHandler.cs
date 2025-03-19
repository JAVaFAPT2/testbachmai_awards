using Domain.Interface;
using Domain.models;
using Domain.Models;
using MediatR;

namespace Aplication.service.HumanData.Commands.Handler;

public class CreatePersonCommandHandler : IRequestHandler<CreatePersonCommand, Person>
{
    private readonly IPersonRepository _personRepository;

    public CreatePersonCommandHandler(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public async Task<Person> Handle(CreatePersonCommand command, CancellationToken cancellationToken)
    {
        var person = new Person
        {
            Id = command.Id,
            Name = command.Name,
            Avatar = command.Avatar,
            Background = command.Background,
            Title = command.Title,
            Company = command.Company,
            Birthday = command.Birthday,
            Address = command.Address,
            Notes = command.Notes,
            Emails = command.Emails.Select(e => new Email { Address = e.Address, Label = e.Label }).ToList(),
            PhoneNumbers = command.PhoneNumbers.Select(pn => new PhoneNumber
            { CountryCode = pn.CountryCode, Number = pn.Number, Label = pn.Label }).ToList(),
            CountryId = command.CountryId,
            TagIds = command.TagIds
        };

        await _personRepository.AddAsync(person);
        return person;
    }
}
