namespace LearnCSharp0311.Entities;

internal class User: BaseEntity
{

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string NationalCode { get; set; }
    public string MobileNumber { get; set; }

}
