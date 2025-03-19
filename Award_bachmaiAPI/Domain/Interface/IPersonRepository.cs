using Domain.Models;

namespace Domain.Interface;

public interface IPersonRepository
{
    Task<Person> GetByIdAsync(Guid id);
    Task<IEnumerable<Person>> GetAllAsync();
    Task AddAsync(Person person);
    Task UpdateAsync(Person person);
    Task DeleteAsync(Guid id);
}