namespace Backend.Domain.Interfaces
{
    public interface IService <T>
    {
        T FindById(long id);
    }
}
