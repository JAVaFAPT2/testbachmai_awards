using Domain.Models;

namespace Domain.Interface;

public interface IPersonService
{
    Task<Person> CreatePersonAsync(Person person);
    Task<Person> GetPersonByEmailAsync(string email);
    Task<IEnumerable<Person>> GetAllPeopleAsync();
    Task UpdatePersonAsync(Person person);
    Task DeletePersonAsync(Guid id);
}