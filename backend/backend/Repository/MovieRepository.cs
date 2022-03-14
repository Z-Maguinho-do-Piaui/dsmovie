using Backend.DadosMocados;
using Backend.Domain.Entities.Movie;
using System.Collections.Generic;
using System.Linq;

namespace Backend.Repository
{
    public class MovieRepository : IMovieRepository
    {
        public List<Movie> SkipTakeMovies(int size, int actualPage)
        {
            return Mocados.DbMovies.Skip((actualPage - 1) * size).Take(size).ToList();
        }
        public Movie GetById(long id)
        {
            return Mocados.DbMovies.Find(x => x.Id == id);
        }

        public int GetTotalRegister()
        {
            return Mocados.DbMovies.Count;
        }

        public void Save(Movie obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
