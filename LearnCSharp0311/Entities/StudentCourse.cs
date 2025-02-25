namespace LearnCSharp0311.Entities;

internal class StudentCourse: BaseEntity
{
    public Course Course { get; set; }
    public Student Student { get; set; }
    public DateTime RejisterDate { get; set; }
    public decimal CurrentAmount { get; set; }

}
