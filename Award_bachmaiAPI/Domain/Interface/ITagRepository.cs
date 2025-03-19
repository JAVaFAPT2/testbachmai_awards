using Domain.models;

namespace Infastructure.Persitance.repository;

public interface ITagRepository
{
    Task<Tag> AddAsync(Tag tag);
    Task<Tag> GetByIdAsync(Guid id);
    Task<IEnumerable<Tag>> GetAllAsync();
    Task UpdateAsync(Tag tag);
    Task DeleteAsync(Guid id);
}