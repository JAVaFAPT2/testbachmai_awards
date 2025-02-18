using Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.Persitance.repository
{
    public interface ITagRepository
    {
        Task<Tag> AddAsync(Tag tag);
        Task<Tag> GetByIdAsync(Guid id);
        Task<IEnumerable<Tag>> GetAllAsync();
        Task UpdateAsync(Tag tag);
        Task DeleteAsync(Guid id);
    }
}
