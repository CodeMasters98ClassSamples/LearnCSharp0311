using BaseBackend.Enums;
using BaseBackend.Interfaces;

namespace BaseBackend.Entities;

public class Course : IFullEntity<short>
{
    public short Id { get; set; }
    public CourseType CourseType { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Amount { get; set; }
    public decimal Discount { get; set; }
    public bool IsActive { get; set; }

    public DateTime CreatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
    public int UserId { get; set; }
}
