

using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Queries
{
    public class GetAllGenresQuery : IGetAllGenresQuery
    {
        private readonly RelationalDbContext _context;

        public GetAllGenresQuery(RelationalDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Genre>> GetAllGenres()
        {
            return await _context.Genres.ToListAsync();
        }
    }
}
