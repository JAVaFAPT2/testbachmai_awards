using Domain.models;
using Infastructure.Persitance.repository;

namespace Infastructure.service;

internal class TagService
{
    private readonly ITagRepository _tagRepository;

    public TagService(ITagRepository tagRepository)
    {
        _tagRepository = tagRepository;
    }

    public async Task<Tag> CreateTagAsync(Tag tag)
    {
        return await _tagRepository.AddAsync(tag);
    }

    public async Task<Tag> GetTagByIdAsync(Guid id)
    {
        return await _tagRepository.GetByIdAsync(id);
    }

    public async Task<IEnumerable<Tag>> GetAllTagsAsync()
    {
        return await _tagRepository.GetAllAsync();
    }

    public async Task UpdateTagAsync(Tag tag)
    {
        await _tagRepository.UpdateAsync(tag);
    }

    public async Task DeleteTagAsync(Guid id)
    {
        await _tagRepository.DeleteAsync(id);
    }
}