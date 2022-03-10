namespace backend.Entities
{
    public class User
    {
        public User(long id, string title)
        {
            Id = id;
            Title = title;
        }

        public long Id { get; private set; }
        public string Title { get; private set; }
    }
}
