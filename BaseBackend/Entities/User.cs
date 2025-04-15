using BaseBackend.Interfaces;

namespace BaseBackend.Entities;

public abstract class User : IBaseEntity
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public int Age
    {
        get
        {
            return 1;
        }
    }
    public string NationalCode { get; set; }
    public string MobileNumber { get; set; }
    public DateTime CreateIn { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }

}
