using backend.Entities;

namespace backend.EmJava
{
    public class Score
    {
        // é necessário em java dar um new aqui para garantir que o objeto sempre estará instanciado
        public ScorePk Id { get; private set; }
        public double Value { get; private set; }

        public Score()
        {

        }

        // Esse método serve para informar um filme e associa-lo ao score 
        public void SetMovie(Movie movie)
        {
            Id.Movie = movie;
        }

        public void SetUser(User user)
        {
            Id.User = user;
        }
    }
}
