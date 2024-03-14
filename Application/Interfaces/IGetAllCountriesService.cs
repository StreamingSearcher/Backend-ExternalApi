
using Application.Models;

namespace Application.Interfaces
{
    public interface IGetAllCountriesService
    {
        Task<IEnumerable<CountryResponse>> GetAllCountries();
    }
}
