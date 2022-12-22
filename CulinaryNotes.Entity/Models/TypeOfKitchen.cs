namespace CulinaryNotes.Entity.Models;
public class TypeOfKitchen : BaseEntity
{
    public string Name { get; set; }
    public virtual ICollection<Recipe> Recipes { get; set; }
}