using Domain.Interface;
using Domain.models;
using Domain.Models;
using MediatR;

namespace Aplication.service.HumanData.Commands.Handler;

public class UpdatePersonCommandHandler(IPersonRepository personRepository)
    : IRequestHandler<UpdatePersonCommand, Person>
{
    private readonly IPersonRepository _personRepository = personRepository;

    public async Task<Person> Handle(UpdatePersonCommand command, CancellationToken cancellationToken = default)
    {
        // Retrieve the existing person from the repository
        var existingPerson = await _personRepository.GetByIdAsync(command.Id) ??
                             throw new KeyNotFoundException($"Person with Id {command.Id} not found.");

        // Update only the fields that can be changed
        existingPerson.Name = command.Name;
        existingPerson.Avatar = command.Avatar;
        existingPerson.Background = command.Background;
        existingPerson.Title = command.Title;
        existingPerson.Company = command.Company;
        existingPerson.Address = command.Address;
        existingPerson.Notes = command.Notes;
        existingPerson.Emails = command.Emails.Select(e => new Email { Address = e.Address, Label = e.Label }).ToList();
        existingPerson.PhoneNumbers = command.PhoneNumbers.Select(pn => new PhoneNumber
            { CountryCode = pn.CountryCode, Number = pn.Number, Label = pn.Label }).ToList();

        // Update the person in the repository
        await _personRepository.UpdateAsync(existingPerson);

        // Return the updated Person object
        return existingPerson; // This returns the entire Person object
    }
}