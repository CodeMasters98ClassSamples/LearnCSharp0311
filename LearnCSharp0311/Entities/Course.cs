namespace LearnCSharp0311.Entities;

internal class Course: BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Amount { get; set; }
    public decimal Discount { get; set; }
    public bool IsActive { get; set; }
  
}
