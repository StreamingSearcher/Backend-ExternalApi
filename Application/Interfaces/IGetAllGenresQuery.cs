
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IGetAllGenresQuery
    {
        Task<IEnumerable<Genre>> GetAllGenres();
    }
}
