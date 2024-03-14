

using Application.Models.ResponseApiTitle;

namespace Application.Interfaces
{
    public interface IApiTitleServices
    {
        Task<IList<Result>?> GetMediaByTitle(string title);
    }
}
