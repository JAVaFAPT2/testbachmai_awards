using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.People.Services;
using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Persistence.Repositories;
using MediatR;
using Aplication.service.DTO;
using Aplication.service.HumanData.Commands;
using Application.Features.Humans.Queries;

namespace Infrastructure.service
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMediator _mediator;

        public PersonService(IPersonRepository personRepository, IMediator mediator)
        {
            _personRepository = personRepository;
            _mediator = mediator;
        }

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
                PhoneNumbers = person.PhoneNumbers.Select(pn => new PhoneNumberDto { CountryCode = pn.CountryCode, Number = pn.Number, Label = pn.Label }).ToList(),
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
            {
                throw new ArgumentException("Person Id cannot be null.", nameof(person.Id));
            }
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
                PhoneNumbers = person.PhoneNumbers.Select(pn => new PhoneNumberDto { CountryCode = pn.CountryCode, Number = pn.Number, Label = pn.Label }).ToList()
            });
        }

        public async Task DeletePersonAsync(Guid id)
        {
            await _mediator.Send(new DeletePersonCommand { Id = id }); 
        }
    }
}