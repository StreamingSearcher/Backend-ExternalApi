
using Application.Interfaces;
using Application.Models.ResponseApiTitle;
using Newtonsoft.Json;

namespace Application.UseCases
{
    public class ApiTitleServices : IApiTitleServices
    {
        private HttpClient _httpClient;
        private readonly string _apiKey;
        private readonly string _url;

        public ApiTitleServices(HttpClient httpclient)
        {
            _url = "https://online-movie-database.p.rapidapi.com/title/find?q=";
            _apiKey = "9000e51be2msh129e85ca6efb0d6p19acbajsn2cc83cf7161a";
            _httpClient = httpclient;
        }

        public async Task<IList<Result>?> GetMediaByTitle(string title)
        {
            _httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Key", _apiKey);
            var responseApi = await _httpClient.GetAsync(_url + title);
            ApiFindResponse? response = null;

            if (responseApi.IsSuccessStatusCode)
            {
                string jsonResponse = await responseApi.Content.ReadAsStringAsync();
                response = JsonConvert.DeserializeObject<ApiFindResponse>(jsonResponse);

            }

            _httpClient.DefaultRequestHeaders.Remove("X-RapidAPI-Key");

            return response?.Results;
        }
    }
}
