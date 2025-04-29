namespace BaseBackend.Interfaces;

public interface IBaseBusiness<T>
{
    bool Add(T item);
    List<T> GetAll();
    bool Update(T item);
}
