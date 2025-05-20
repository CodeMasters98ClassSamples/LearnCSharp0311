using BaseBackend.Interfaces;

namespace BaseBackend.Entities;

public class StudentCourse: IBaseEntity
{
    public int Id { get; set; }
    //public Course Course { get; set; }
    public int CourseId { get; set; }
    public int StudentId { get; set; }
    //public Student Student { get; set; }
    public DateTime RejisterDate { get; set; }
    //public decimal CurrentAmount { get; set; }

    private decimal _currentAmount;

    public decimal CurrentAmount
    {
        get { return _currentAmount; }
    }

    public DateTime CreateIn { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
}
