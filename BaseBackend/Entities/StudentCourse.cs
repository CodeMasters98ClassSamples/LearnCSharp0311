using BaseBackend.Interfaces;

namespace BaseBackend.Entities;

public class StudentCourse : IFullEntity<long>
{
    public long Id { get; set; }
    //public Course Course { get; set; }
    public int CourseId { get; set; }
    public int StudentId { get; set; }
    //public Student Student { get; set; }

    public decimal CurrentAmount { get; set; }

    public DateTime CreatedAt { get; set; }
    public int CreatedByUserId { get; set; }

    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
    public int DeletedByUserId { get; set; }
}
