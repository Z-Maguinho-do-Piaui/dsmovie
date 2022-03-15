using Backend.Data;
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
        BackendContext _context;
        public MovieController(ILogger<MovieController> logger, IMovieService movieService)
        {
            _logger = logger;
            _service = movieService;
        }

        [EnableCors("MyPolicy")]
        [HttpGet, Route("find-all")]
        public MoviePage FindAll(int size, int actualPage)
        {
            return _service.GetInformationPage(size, actualPage);
            //return _contenxt.DbMovies.Skip((actualPage - 1) * size).Take(size).ToList();
        }

        [EnableCors("MyPolicy")]
        [HttpGet, Route("find-by-id")]
        public MovieDto FindById(long id)
        {
            return _service.FindById(id);
        }
    }
}
