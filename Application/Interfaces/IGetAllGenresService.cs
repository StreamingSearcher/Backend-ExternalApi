

using Application.Models;


namespace Application.Interfaces
{
    public interface IGetAllGenresService
    {
        Task<IEnumerable<GenreResponse>> GetAllGenres();
    }
}
