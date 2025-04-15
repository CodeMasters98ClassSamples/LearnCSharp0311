using LearnCSharp0311.Entities;

namespace BaseBackend.Interfaces;

public interface IBaseBusiness<T>
{
    void Add(T item);
    List<T> GetAll();
}
