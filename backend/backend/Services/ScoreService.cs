using Backend.Domain.Entities.Movie;
using Backend.Domain.Entities.Score;
using Backend.Domain.Entities.User;
using Backend.Dto;
using Backend.Repository;

namespace Backend.Services
{
    public class ScoreService : IScoreService
    {
        private IScoreRepository _repository;
        private IMovieRepository _movieRepository;
        private IUserRepository _userRepository;
        public ScoreService()
        {
            _repository = new ScoreRepository();
            _movieRepository = new MovieRepository();
            _userRepository = new UserRepository();
        }
        public ScoreDto FindById(long id)
        {
            throw new System.NotImplementedException();
        }

        public MovieDto SaveScore(ScoreDto obj)
        {
            User user = _userRepository.FindByEmail(obj.Email);

            if (user == null)
            {
                user = new User(777, obj.Email);
                _userRepository.Save(user);
            }

            Movie movie = _movieRepository.GetById(obj.IdMovie);

            Score score = new Score(movie.Id, user.Id, obj.Score);

            _repository.Save(score);

            double sum = 0.0;

            for (int i = 0; i < movie.Count; i++)
            {
                sum += 5;
            }

            double avg = sum / movie.Score;


            _movieRepository.Save(movie);

            return new MovieDto(movie);
        }
    }
}
