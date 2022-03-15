using Backend.DadosMocados;
using Backend.Data;
using Backend.Domain.Entities.Movie;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Backend.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly BackendContext _contenxt;
        public MovieRepository(BackendContext context)
        {
            _contenxt = context;
        }
        public List<Movie> SkipTakeMovies(int size, int actualPage)
        {
            return _contenxt.DbMovies.Skip((actualPage - 1) * size).Take(size).ToList();
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
