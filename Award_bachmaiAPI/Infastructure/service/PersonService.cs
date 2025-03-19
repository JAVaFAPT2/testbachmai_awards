using Aplication.service.DTO;
using Aplication.service.HumanData.Commands;
using Aplication.service.HumanData.Queries;
using Domain.Interface;
using Domain.Models;
using MediatR;

namespace Infastructure.service;

public class PersonService(IMediator mediator) : IPersonService
{
    private readonly IMediator _mediator = mediator;

    public async Task<Person> CreatePersonAsync(Person person)
    {
        return await _mediator.Send(new CreatePersonCommand
        {
            Name = person.Name,
            Avatar = person.Avatar,
            Background = person.Background,
            Title = person.Title,
            Company = person.Company,
            Birthday = person.Birthday,
            Address = person.Address,
            Notes = person.Notes,
            Emails = person.Emails.Select(e => new EmailDto { Address = e.Address, Label = e.Label }).ToList(),
            PhoneNumbers = person.PhoneNumbers.Select(pn => new PhoneNumberDto
                { CountryCode = pn.CountryCode, Number = pn.Number, Label = pn.Label }).ToList(),
            CountryId = person.CountryId,
            TagIds = person.TagIds
        });
    }

    public async Task<Person> GetPersonByEmailAsync(string email)
    {
        return await _mediator.Send(new GetPeoplesByEmailQuery(email));
    }

    public async Task<IEnumerable<Person>> GetAllPeopleAsync()
    {
        return await _mediator.Send(new GetAllPeoplesQueries());
    }

    public async Task UpdatePersonAsync(Person person)
    {
        if (!person.Id.HasValue) // Check if Id is null
            throw new ArgumentException("Person Id cannot be null.", nameof(person));
        await _mediator.Send(new UpdatePersonCommand
        {
            Id = person.Id.Value,
            Name = person.Name,
            Avatar = person.Avatar,
            Background = person.Background,
            Title = person.Title,
            Company = person.Company,
            Address = person.Address,
            Notes = person.Notes,
            Emails = person.Emails.Select(e => new EmailDto { Address = e.Address, Label = e.Label }).ToList(),
            PhoneNumbers = person.PhoneNumbers.Select(pn => new PhoneNumberDto
                { CountryCode = pn.CountryCode, Number = pn.Number, Label = pn.Label }).ToList()
        });
    }

    public async Task DeletePersonAsync(Guid id)
    {
        await _mediator.Send(new DeletePersonCommand { Id = id });
    }
}