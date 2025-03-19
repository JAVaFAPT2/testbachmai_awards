using Aplication.service.DTO;
using Domain.Models;
using MediatR;

namespace Aplication.service.HumanData.Commands;

public class CreatePersonCommand : IRequest<Person>
{
    public required string Name { get; set; }
    public required string Avatar { get; set; }
    public required string Background { get; set; }
    public required string Title { get; set; }
    public required string Company { get; set; }
    public DateTime Birthday { get; set; }
    public required string Address { get; set; }
    public required string Notes { get; set; }
    public required List<EmailDto> Emails { get; set; }
    public required List<PhoneNumberDto> PhoneNumbers { get; set; }
    public required string CountryId { get; set; } // Foreign key reference
    public required List<string> TagIds { get; set; } // List of tag IDs
    public Guid Id { get; set; }
}