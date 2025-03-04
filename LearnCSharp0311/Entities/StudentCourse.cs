using LearnCSharp0311.Interfaces;

namespace LearnCSharp0311.Entities;

internal class StudentCourse: IBaseEntity
{
    public int Id { get; set; }
    public Course Course { get; set; }
    public Student Student { get; set; }
    public DateTime RejisterDate { get; set; }
    public decimal CurrentAmount { get; set; }
    public DateTime CreateIn { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
}
