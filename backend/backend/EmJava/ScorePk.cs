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
