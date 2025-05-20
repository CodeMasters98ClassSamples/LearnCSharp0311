using BaseBackend.Interfaces;

namespace BaseBackend.Entities;

public abstract class User : IFullEntity<int>
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string NationalCode { get; set; }
    public string MobileNumber { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
    public int UserId { get; set; }
}
