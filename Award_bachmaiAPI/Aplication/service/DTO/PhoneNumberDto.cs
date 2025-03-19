namespace Aplication.service.DTO;

public record class PhoneNumberDto
{
    public string? CountryCode { get; set; }
    public string? Number { get; set; }
    public string? Label { get; set; }
}