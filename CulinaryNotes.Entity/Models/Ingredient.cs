namespace CulinaryNotes.Entity.Models;

public class Ingredient : BaseEntity
{
    public string Name { get; set; }
    public int Weight { get; set; }
    public Guid RecipeId { get; set; }
    public virtual Recipe Recipe { get; set; }
    public virtual ICollection<Recipe> Recipes { get; set; }
}