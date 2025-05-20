namespace BaseBackend.Interfaces;

public interface IStudentBusiness<T> where T : class
{
    bool Register(T item);
    List<T> GetRegisteredStudent();
}
