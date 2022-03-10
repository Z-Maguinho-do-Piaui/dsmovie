namespace backend.Entities
{
    public class Movie
    {
        public Movie(long id, string title, double score, int count, string image)
        {
            Id = id;
            Title = title;
            Score = score;
            Count = count;
            Image = image;
        }

        public long Id { get; private set; }
        public string Title { get; private set; }
        public double Score { get; private set; }
        public int Count { get; private set; }
        public string Image { get; private set; }
    }
}
