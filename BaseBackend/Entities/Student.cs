
namespace BaseBackend.Entities;

public class Student : User
{
    public Student()
    {

    }

    public Student(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public Student(string firstName, string lastName,string mobileNumber) : this(firstName,lastName)
    {
        MobileNumber = mobileNumber;
    }

   

    public string FullData
    {
        get
        {
            return $"StudentName: {FirstName}";
        }
    }

    public string Referer { get; set; }

    //public string GetFullData()
    //{
    //    return $"StudentName: {FirstName}";
    //}
}
