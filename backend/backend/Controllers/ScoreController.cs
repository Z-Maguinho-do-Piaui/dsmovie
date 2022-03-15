using Backend.Domain.Entities.Score;
using Backend.Dto;
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
        public ScoreController(ILogger<ScoreController> logger, IScoreService score)
        {
            _logger = logger;
            _service = score;
        }

        [EnableCors("MyPolicy")]
        [HttpPut, Route("save-score")]
        public MovieDto SaveScore([FromBody] ScoreDto obj)
        {
            return _service.SaveScore(obj);
        }
    }
}
