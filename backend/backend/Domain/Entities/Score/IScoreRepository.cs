using Backend.Domain.Interfaces;

namespace Backend.Domain.Entities.Score
{
    public interface IScoreRepository : IRepository<Score>
    {
        void Save(Score obj);
    }
}
