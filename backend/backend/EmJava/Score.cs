using backend.Entities;

namespace backend.EmJava
{
    //@Entity
    //@Table(name = "tb_score")
    public class Score
    {
        // é necessário em java dar um new aqui para garantir que o objeto sempre estará instanciado

        // @EmbeddedId -- por se tratar de uma chave composta
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
