namespace backend.Entities
{
    public class Score
    {
        public Movie Movie { get; private set; }
        public User User { get; private set; }
        public double Value { get; private set; }
    }
}
