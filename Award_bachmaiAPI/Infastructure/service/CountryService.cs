using Domain.models;
using Infrastructure.Persistence.Repositories;

namespace Infastructure.service;

public class CountryService
{
    private readonly ICountryRepository _countryRepository;

    public CountryService(ICountryRepository countryRepository)
    {
        _countryRepository = countryRepository;
    }

    public async Task<Country> CreateCountryAsync(Country country)
    {
        return await _countryRepository.AddAsync(country);
    }

    public async Task<Country> GetCountryByIdAsync(string id)
    {
        return await _countryRepository.GetByIdAsync(id);
    }

    public async Task<IEnumerable<Country>> GetAllCountriesAsync()
    {
        return await _countryRepository.GetAllAsync();
    }

    public async Task UpdateCountryAsync(Country country)
    {
        await _countryRepository.UpdateAsync(country);
    }

    public async Task DeleteCountryAsync(string id)
    {
        await _countryRepository.DeleteAsync(id);
    }
}