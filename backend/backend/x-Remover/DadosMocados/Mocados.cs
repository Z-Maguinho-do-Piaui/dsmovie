using Backend.Domain.Entities.Movie;
using Backend.Domain.Entities.Score;
using Backend.Domain.Entities.User;
using System.Collections.Generic;

namespace Backend.DadosMocados
{
    public static class Mocados
    {

        public static List<User> DbUsers = new List<User>()
                                       {
                                           new User(1, "maria@gmail.com"),
                                           new User(2, "joao@gmail.com"),
                                           new User(3, "ana@gmail.com"),
                                           new User(4, "lucia@gmail.com"),
                                           new User(5, "joaquim@gmail.com")
                                       };


        public static List<Movie> DbMovies = new List<Movie>()
                {
                    new Movie(1, 4.5, 2, "The Witcher", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/jBJWaqoSCiARWtfV0GlqHrcdidd.jpg"),
                    new Movie(2, 3.3, 3, "Venom: Tempo de Carnificina", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/vIgyYkXkg6NC2whRbYjBD7eb3Er.jpg"),
                    new Movie(3, 0, 0, "O Espetacular Homem-Aranha 2: A Ameaça de Electro", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/u7SeO6Y42P7VCTWLhpnL96cyOqd.jpg"),
                    new Movie(4, 0, 0, "Matrix Resurrections", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/hv7o3VgfsairBoQFAawgaQ4cR1m.jpg"),
                    new Movie(5, 0, 0, "Shang-Chi e a Lenda dos Dez Anéis", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/cinER0ESG0eJ49kXlExM0MEWGxW.jpg"),
                    new Movie(6, 0, 0, "Django Livre", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/2oZklIzUbvZXXzIFzv7Hi68d6xf.jpg"),
                    new Movie(7, 0, 0, "Titanic", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/yDI6D5ZQh67YU4r2ms8qcSbAviZ.jpg"),
                    new Movie(8, 0, 0, "O Lobo de Wall Street", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/cWUOv3H7YFwvKeaQhoAQTLLpo9Z.jpg"),
                    new Movie(9, 0, 0, "Aves de Rapina: Arlequina e sua Emancipação Fantabulosa", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/jiqD14fg7UTZOT6qgvzTmfRYpWI.jpg"),
                    new Movie(10, 0, 0, "Rogue One: Uma História Star Wars", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/6t8ES1d12OzWyCGxBeDYLHoaDrT.jpg"),
                    new Movie(11, 0, 0, "Star Wars: A Guerra dos Clones", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/uK15I3sGd8AudO9z6J6vi0HH1UU.jpg"),
                    new Movie(12, 0, 0, "Star Wars: Episódio I - A Ameaça Fantasma", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/36LnijfQCOC89rCMOhn2OINXROI.jpg"),
                    new Movie(13, 0, 0, "Vingadores: Ultimato", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/7RyHsO4yDXtBv1zUU3mTpHeQ0d5.jpg"),
                    new Movie(14, 0, 0, "Thor", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/cDJ61O1STtbWNBwefuqVrRe3d7l.jpg"),
                    new Movie(15, 0, 0, "Cisne Negro", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/hqh5O4KssfJWI62HGAgrjHXbxhD.jpg"),
                    new Movie(16, 0, 0, "O Silêncio dos Inocentes", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/mfwq2nMBzArzQ7Y9RKE8SKeeTkg.jpg"),
                    new Movie(17, 0, 0, "Clube da Luta", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/hZkgoQYus5vegHoetLkCJzb17zJ.jpg"),
                    new Movie(18, 0, 0, "Guerra Mundial Z", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/31VpBgUX5O4Z3dn5ZbX8HLqoXH3.jpg"),
                    new Movie(19, 0, 0, "Harry Potter e as Relíquias da Morte - Parte 1", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/vcrgU0KaNj5mKUCIQSUdiQwTE9y.jpg"),
                    new Movie(20, 0, 0, "Harry Potter e a Pedra Filosofal", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/lvOLivVeX3DVVcwfVkxKf0R22D8.jpg"),
                    new Movie(21, 0, 0, "Alice no País das Maravilhas", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/qNdlZgz9yoSJ8f0YxQWfKGPoVV.jpg"),
                    new Movie(22, 0, 0, "Animais Fantásticos e Onde Habitam", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/8Qsr8pvDL3s1jNZQ4HK1d1Xlvnh.jpg"),
                    new Movie(23, 0, 0, "A Teoria de Tudo", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/kq2MHrRfH6RTfkvyDEmYLmGHE6U.jpg"),
                    new Movie(24, 0, 0, "O Livro de Boba Fett", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/sjx6zjQI2dLGtEL0HGWsnq6UyLU.jpg"),
                    new Movie(25, 0, 0, "O Último Duelo", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/4LrL40XecjGLRpX5I2gzMTUt04l.jpg"),
                    new Movie(26, 0, 0, "Interestelar", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/rAiYTfKGqDCRIIqo664sY9XZIvQ.jpg"),
                    new Movie(27, 0, 0, "Contato", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/yFkUPqBuUnbhYbQL8VFpTrAT9za.jpg"),
                    new Movie(28, 0, 0, "Duna", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/jYEW5xZkZk2WTrdbMGAPFuBqbDc.jpg"),
                    new Movie(29, 0, 0, "Aquaman", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/2cUsDz4TzFYHrKktT1bKHHQ7Cgm.jpg")
                };

        public static List<Score> DbScores = new List<Score>()
                                         {
                                             new Score(1, 1, 5.0),
                                             new Score(1, 2, 4.0),
                                             new Score(2, 1, 3.0),
                                             new Score(2, 2, 3.0),
                                             new Score(2, 3, 4.0)
                                         };
    }
}
