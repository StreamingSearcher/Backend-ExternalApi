using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace RelationalMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaController : ControllerBase
    {
        private readonly IApiTitleServices _titleServices;
        private readonly IApiIdServices _idServices;
        private readonly IGetAllGenresService _genresGetAllService;
        private readonly IGetAllCountriesService _countriesGetAllService;

        public MediaController(IApiTitleServices titleServices, IApiIdServices idServices, IGetAllGenresService genresGetAllService, IGetAllCountriesService countriesGetAllService)
        {
            _titleServices = titleServices;
            _idServices = idServices;
            _genresGetAllService = genresGetAllService;
            _countriesGetAllService = countriesGetAllService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string title)
        {
            var response = (await _titleServices.GetMediaByTitle(title));
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetId(string id)
        {
            var response = await _idServices.GetMediaById(id);
            return Ok(response);
        }

        [HttpGet("genres")]
        public async Task<IActionResult> GetAllGenres()
        {
            var response = await _genresGetAllService.GetAllGenres();
            return Ok(response);
        }

        [HttpGet("countries")]
        public async Task<IActionResult> GetAllCountries()
        {
            var response = await _countriesGetAllService.GetAllCountries();
            return Ok(response);
        }
    }
}
