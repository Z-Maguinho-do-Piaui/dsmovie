namespace Backend.Domain.Interfaces
{
    public interface IRepository <T>
    {
        T GetById(long id);
        void Save(T obj);
    }
}
