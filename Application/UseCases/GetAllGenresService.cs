
using Application.Interfaces;
using Application.Models;
using Domain.Entities;

namespace Application.UseCases
{
    public class GetAllGenresService : IGetAllGenresService
    {
        private readonly IGetAllGenresQuery _query;

        public GetAllGenresService(IGetAllGenresQuery query)
        {
            _query = query;
        }

        public async Task<IEnumerable<GenreResponse>> GetAllGenres()
        {
            var query = await _query.GetAllGenres();
            IList<GenreResponse> genresResponse = new List<GenreResponse>();

            foreach (var genre in query) 
            {
                GenreResponse genreResponse = new GenreResponse()
                { 
                    Name = genre.Name 
                };
                genresResponse.Add(genreResponse);
            }

            return genresResponse;
        }
    }
}
