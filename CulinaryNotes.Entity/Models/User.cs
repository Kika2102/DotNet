namespace CulinaryNotes.Entity.Models;

public class User : BaseEntity
{
    public string Login { get; set; }
    public string PasswordHash { get; set; }
    public string FIO { get; set; }
    public string Nickname { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Guid UserId { get; set; }
    public virtual ICollection<Recipe> Recipes { get; set; }
}