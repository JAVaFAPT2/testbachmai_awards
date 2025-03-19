namespace Aplication.service.DTO;

public record class EmailDto
{
    public string? Address { get; set; }
    public string? Label { get; set; }
}