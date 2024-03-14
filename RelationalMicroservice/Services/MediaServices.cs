using Application.Interfaces;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;


namespace RelationalMicroservice.Services
{
    public class MediaServices : Media.MediaBase
    {
        private readonly IApiTitleServices _titleServices;
        private readonly IApiIdServices _idServices;
        private readonly IGetAllCountriesService _countriesServices;
        private readonly IGetAllGenresService _genresServices;

        public MediaServices(IApiTitleServices titleServices, IApiIdServices idServices, IGetAllCountriesService countriesServices, IGetAllGenresService genresServices)
        {
            _titleServices = titleServices;
            _idServices = idServices;
            _countriesServices = countriesServices;
            _genresServices = genresServices;
        }

        public override async Task<ApiTitleListProto> GetMediaByTitle(MediaTitleProto request, ServerCallContext context)
        {
            var response = await _titleServices.GetMediaByTitle(request.Title); 
            List<ApiTitleProto> result = new List<ApiTitleProto>();
            foreach (var media in response)
            {
                ApiTitleProto resultApiTitle = new ApiTitleProto
                {
                    Title = media.Title ?? "",
                    Id = media.Id,
                    Image = new ApiTitleImageProto
                    {
                        Url = media.Image != null ? media.Image.Url ?? "" : ""
                    },
                    TitleType = media.TitleType ?? "",
                    Year = media.Year,
                };

                result.Add(resultApiTitle);
            }
            ApiTitleListProto resultList = new ApiTitleListProto
            {
                Results = { result }
            };
            // Guardar en la base de datos  (Paralelo)
            return resultList;
        }

        public override async Task<ApiIdProto> GetMediaById(MediaIdProto request, ServerCallContext context)
        {
            var response = await _idServices.GetMediaById(request.Id);

            List<ApiIdGenreProto> genreProtos = new List<ApiIdGenreProto>();
            foreach (var genre in response.Genres)
            {
                ApiIdGenreProto genreProto = new ApiIdGenreProto
                {
                    Name = genre.Name
                };
                genreProtos.Add(genreProto);
            }

            Dictionary<string, ApiIdPlatformsProto> streamingInfoProtos = new Dictionary<string, ApiIdPlatformsProto>();
            foreach (var kvp in response.StreamingInfo)
            {
                ApiIdPlatformsProto apiPlatformsProto = new ApiIdPlatformsProto();
                foreach (var apiPlatform in kvp.Value)
                {
                    ApiIdPlatformProto apiPlatformProto = new ApiIdPlatformProto
                    {
                        Service = apiPlatform.Service
                    };

                    apiPlatformsProto.Platforms.Add(apiPlatformProto);
                }
                streamingInfoProtos.Add(kvp.Key, apiPlatformsProto);
            }

            ApiIdProto result = new ApiIdProto
            {
                Title = response.Title,
                ImdbId = response.ImdbId,
                Overview = response.Overview,
                Genres = { genreProtos },
                StreamingInfo = { streamingInfoProtos }
            };

            // Guardar en la base de datos  (Paralelo)

            return result;
        }

        public override async Task<CountriesResponseProto> GetAllCountries(Empty request, ServerCallContext context)
        {
            var response = await _countriesServices.GetAllCountries();
            IList<CountryResponseProto> countryResponseProtos = new List<CountryResponseProto>();
            foreach (var country in response)
            {
                CountryResponseProto countryResponseProto = new CountryResponseProto()
                {
                    Code = country.Code,
                    Name = country.Name,
                };
                countryResponseProtos.Add(countryResponseProto);
            }
            CountriesResponseProto countriesResponseProto = new CountriesResponseProto()
            {
                Countries = { countryResponseProtos }
            };
            return countriesResponseProto;
        }

        public async override Task<GenresResponseProto> GetAllGenres(Empty request, ServerCallContext context)
        {
            var response = await _genresServices.GetAllGenres();
            IList<GenreResponseProto> genreResponseProtos = new List<GenreResponseProto>();
            foreach (var genre in response)
            {
                GenreResponseProto genreResponseProto = new GenreResponseProto()
                { 
                    Name = genre.Name,
                };
                genreResponseProtos.Add(genreResponseProto);
            }
            GenresResponseProto genresResponseProto = new GenresResponseProto()
            {
                Genres = { genreResponseProtos }
            };
            return genresResponseProto;
        }
    }
}
