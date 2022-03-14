using Backend.Domain.Entities.Score;
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

    public class ScoreController : ControllerBase
    {
        private readonly ILogger<ScoreController> _logger;
        private IScoreService _service;
        public ScoreController(ILogger<ScoreController> logger)
        {
            _logger = logger;
            _service = new ScoreService();
        }

        [EnableCors("MyPolicy")]
        [HttpPut, Route("save-score")]
        public MovieDto SaveScore([FromBody] ScoreDto obj)
        {
            return _service.SaveScore(obj);
        }
    }
}
