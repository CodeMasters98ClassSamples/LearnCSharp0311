namespace BaseBackend.Interfaces;

public interface IBaseEntity
{
    public int Id { get; set; }
    public DateTime CreateIn { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
}
