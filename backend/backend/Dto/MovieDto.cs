using Backend.Domain.Entities.Movie;

namespace Backend.Dto
{
    public class MovieDto
    {
        public MovieDto(Movie movie)
        {
            Id = movie.Id;
            Title = movie.Title;
            Score = movie.Score;
            Count = movie.Count;
            Image = movie.Image;
        }

        public long Id { get; private set; }
        public string Title { get; private set; }
        public double Score { get; private set; }
        public int Count { get; private set; }
        public string Image { get; private set; }

    }
}
