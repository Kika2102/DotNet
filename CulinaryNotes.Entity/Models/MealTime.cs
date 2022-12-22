namespace CulinaryNotes.Entity.Models;
public class MealTime : BaseEntity
{
    public Guid RecipeId { get; set; }
    public virtual Recipe Recipe { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Recipe> Recipes { get; set; }
}