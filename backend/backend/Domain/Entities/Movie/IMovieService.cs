using Backend.Domain.Interfaces;
using Backend.Dto;

namespace Backend.Domain.Entities.Movie
{
    public interface IMovieService : IService <MovieDto>
    {
        MoviePage GetInformationPage(int size, int actualPage);
    }
}
