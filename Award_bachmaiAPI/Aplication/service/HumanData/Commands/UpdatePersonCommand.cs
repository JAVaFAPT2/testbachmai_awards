using Aplication.service.DTO;
using Domain.Models;
using MediatR;

namespace Aplication.service.HumanData.Commands;

public class UpdatePersonCommand : IRequest<Person> // Change return type to Guid
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Avatar { get; set; }
    public string Background { get; set; }
    public string Title { get; set; }
    public string Company { get; set; }
    public string Address { get; set; }
    public string Notes { get; set; }
    public List<EmailDto> Emails { get; set; }
    public List<PhoneNumberDto> PhoneNumbers { get; set; }
}