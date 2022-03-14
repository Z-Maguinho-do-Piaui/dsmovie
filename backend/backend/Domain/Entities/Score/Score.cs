namespace Backend.Domain.Entities.Score
{
    public class Score
    {
        public Score(long idMovie, long idUser, double value)
        {
            IdMovie = idMovie;
            IdUser = idUser;
            Value = value;
        }

        public long IdMovie { get; private set; }
        public long IdUser { get; private set; }
        public double Value { get; private set; }
    }
}
