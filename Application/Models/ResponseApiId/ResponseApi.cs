

namespace Application.Models.ResponseApiId
{
    public class ResponseApi
    {
        public string Title { get; set; }
        public string ImdbId { get; set; }
        public string Overview { get; set; }
        public List<ApiGenre> Genres { get; set; }
        public Dictionary<string, ISet<ApiPlatform>> StreamingInfo { get; set; }
    }
}
