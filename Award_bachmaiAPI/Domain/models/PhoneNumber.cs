namespace Domain.models;

public class PhoneNumber
{
    public required string CountryCode { get; set; }
    public required string Number { get; set; }
    public required string Label { get; set; }
}