
using Application.Interfaces;
using Application.Models;


namespace Application.UseCases
{
    public class GetAllCountriesService : IGetAllCountriesService
    {
        private readonly IGetAllCountriesQuery _query;

        public GetAllCountriesService(IGetAllCountriesQuery query)
        {
            _query = query;
        }

        public async Task<IEnumerable<CountryResponse>> GetAllCountries()
        {
            var query = await _query.GetAllCountries();

            IList<CountryResponse> countriesResponse = new List<CountryResponse>();

            foreach (var country in query)
            {
                CountryResponse countryResponse = new CountryResponse()
                {
                    Code = country.Code,
                    Name = country.Name,
                };

                countriesResponse.Add(countryResponse);
            }

            return countriesResponse;
        }
    }
}
