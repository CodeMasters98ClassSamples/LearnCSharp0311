using LearnCSharp0311.Entities;

namespace LearnCSharp0311.Interfaces;

internal interface IBaseBusiness<T>
{
    void Add(T item);
    List<T> GetAll();
}
