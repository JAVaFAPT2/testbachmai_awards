using Domain.models;

namespace Infrastructure.Persistence.Repositories;

public interface ICountryRepository
{
    Task<Country> AddAsync(Country country);
    Task<Country> GetByIdAsync(string id);
    Task<IEnumerable<Country>> GetAllAsync();
    Task UpdateAsync(Country country);
    Task DeleteAsync(string id);
}