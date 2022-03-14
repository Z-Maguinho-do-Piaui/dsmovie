using Backend.Domain.Entities.Movie;
using Backend.Dto;
using Backend.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Backend.Controllers
{
    [EnableCors("MyPolicy")]
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {

        private readonly ILogger<MovieController> _logger;
        private IMovieService _service;
        public MovieController(ILogger<MovieController> logger)
        {
            _logger = logger;
            _service = new MovieServices();
        }

        [EnableCors("MyPolicy")]
        [HttpGet, Route("find-all")]
        public MoviePage FindAll(int size, int actualPage)
        {
            return _service.GetInformationPage(size, actualPage);
        }

        [EnableCors("MyPolicy")]
        [HttpGet, Route("find-by-id")]
        public MovieDto FindById(long id)
        {
            return _service.FindById(id);
        }
    }
}
