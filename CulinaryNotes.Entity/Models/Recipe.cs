namespace CulinaryNotes.Entity.Models;
public class Recipe : BaseEntity
{
    public Guid UserId { get; set; }
    public virtual User User { get; set; }
    public int CookingTime { get; set; }
    public Guid TypeOfKitchenId { get; set; }
    public virtual TypeOfKitchen TypeOfKitchen { get; set; }
    public string Name { get; set; }
    public Guid CookingMethodId { get; set; }
    public virtual CookingMethod CookingMethod { get; set; }
    public virtual ICollection<Ingredient> Ingredients { get; set; }
    public virtual ICollection<MealTime> MealTimes { get; set; }
    public virtual ICollection<User> Users { get; set; }
}
