using backend.Entities;

namespace backend.EmJava
{
    // @Embeddable 
    public class ScorePk // : Serializable
    {
        //@ManyToOne
        //@JoinColumn(name = "movie_id")
        public Movie Movie { get; set; }
        
        //@ManyToOne
        public User User { get; set; }
    }
}


// Criação do repositório em Java com JPA
//public interface MovieRepository implements JpaRepository <object, typeId> {

//}

