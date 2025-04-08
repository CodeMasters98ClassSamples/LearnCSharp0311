using LearnCSharp0311.Interfaces;

namespace LearnCSharp0311.Entities;

internal abstract class User: IBaseEntity
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string NationalCode { get; set; }
    public string MobileNumber { get; set; }
    public DateTime CreateIn { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }

}
