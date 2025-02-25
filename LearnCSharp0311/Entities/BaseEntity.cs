
namespace LearnCSharp0311.Entities;

internal abstract class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreateIn { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
}
