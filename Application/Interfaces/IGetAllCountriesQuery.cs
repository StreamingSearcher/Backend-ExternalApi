

using Domain.Entities;

namespace Application.Interfaces
{
    public interface IGetAllCountriesQuery
    {
        Task<IEnumerable<Country>> GetAllCountries();
    }
}
