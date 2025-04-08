using LearnCSharp0311.Enums;
using LearnCSharp0311.Interfaces;

namespace LearnCSharp0311.Entities;

internal class Course: IBaseEntity
{
    public int Id { get; set; }

    public CourseType CourseType { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Amount { get; set; }
    public decimal Discount { get; set; }
    public bool IsActive { get; set; }

    public DateTime CreateIn { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
}
