using BaseBackend.Interfaces;

namespace BaseBackend.Entities;

public class StudentCourse : IFullEntity<long>
{
    public long Id { get; set; }
    public Course Course { get; set; }
    public Student Student { get; set; }
    public DateTime RejisterDate { get; set; }
    //public decimal CurrentAmount { get; set; }

    private decimal _currentAmount;

    public decimal CurrentAmount
    {
        get { return _currentAmount; }
    }

    public DateTime CreatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
    public int UserId { get; set; }
}
