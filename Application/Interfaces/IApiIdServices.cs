

using Application.Models.ResponseApiId;

namespace Application.Interfaces
{
    public interface IApiIdServices
    {
        Task<ResponseApi> GetMediaById(string id);
    }
}
