namespace BaseBackend.Interfaces;

public interface IBaseBusiness<T> where T : class
{
    bool Add(T item);
    List<T> GetAll();
    bool Update(T item);
}
