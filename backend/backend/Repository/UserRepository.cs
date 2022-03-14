using Backend.DadosMocados;
using Backend.Domain.Entities.User;
using System;

namespace Backend.Repository
{
    public class UserRepository : IUserRepository
    {
        public User FindByEmail(string email)
        {
            return Mocados.DbUsers.Find(u => u.Title == email);
        }

        public User GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Save(User obj)
        {
            Mocados.DbUsers.Add(obj);
        }
    }
}
