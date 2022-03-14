using Backend.Domain.Interfaces;
using System.Collections.Generic;

namespace Backend.Domain.Entities.Movie
{
    public interface IMovieRepository : IRepository<Movie>
    {
        List<Movie> SkipTakeMovies(int size, int actualPage);
        int GetTotalRegister();
    }
}
