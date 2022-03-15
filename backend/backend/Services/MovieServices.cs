using Backend.Domain.Entities.Movie;
using Backend.Dto;

namespace Backend.Services
{
    public class MovieServices : IMovieService
    {
        public MovieServices(IMovieRepository repository)
        {
            _repository = repository;
        }

        private IMovieRepository _repository;

        public MoviePage GetInformationPage(int size, int actualPage)
        {
            return  new MoviePage(_repository.SkipTakeMovies(size, actualPage), _repository.GetTotalRegister(), size, actualPage);
        }

        public MovieDto FindById(long id)
        {
            return new MovieDto(_repository.GetById(id));
        }
    }
}
