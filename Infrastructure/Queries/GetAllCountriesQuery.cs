
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Queries
{
    public class GetAllCountriesQuery : IGetAllCountriesQuery
    {
        private readonly RelationalDbContext _context;

        public GetAllCountriesQuery(RelationalDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Country>> GetAllCountries()
        {
            return await _context.Countries.ToListAsync();
        }
    }
}
