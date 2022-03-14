using Backend.Domain.Interfaces;
using Backend.Dto;

namespace Backend.Domain.Entities.Score
{
    public interface IScoreService : IService<ScoreDto>
    {
        MovieDto SaveScore(ScoreDto obj);
    }
}
