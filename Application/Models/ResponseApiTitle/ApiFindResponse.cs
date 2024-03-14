
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Application.Models.ResponseApiTitle
{
    public class ApiFindResponse
    {
        public List<Result> Results { get; set; }
    }
}
