
using Application.Interfaces;
using Application.Models.ResponseApiId;
using Application.Models.ResponseApiTitle;
using Newtonsoft.Json;

namespace Application.UseCases
{
    public class ApiIdServices : IApiIdServices
    {
        private HttpClient _httpClient;
        private readonly string _apiKey;
        private readonly string _url;

        public ApiIdServices(HttpClient httpclient)
        {
            _url = "https://streaming-availability.p.rapidapi.com/get?output_language=en&imdb_id=";
            _apiKey = "9000e51be2msh129e85ca6efb0d6p19acbajsn2cc83cf7161a";
            _httpClient = httpclient;
        }

        public async Task<ResponseApi> GetMediaById(string id)
        {
            _httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Key", _apiKey);
            var responseApi = await _httpClient.GetAsync(_url + id);
            ResultApiId response = null;

            if (responseApi.IsSuccessStatusCode)
            {
                string jsonResponse = await responseApi.Content.ReadAsStringAsync();
                response = JsonConvert.DeserializeObject<ResultApiId>(jsonResponse);

            }

            _httpClient.DefaultRequestHeaders.Remove("X-RapidAPI-Key");

            return response.Result;
        }
    }
}
