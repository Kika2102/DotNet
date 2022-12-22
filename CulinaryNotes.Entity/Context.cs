using Microsoft.EntityFrameworkCore;
using CulinaryNotes.Entity.Models;
namespace CulinaryNotes.Entity;
public class Context : DbContext{
    public DbSet<User> Users { get; set; }
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<CookingMethod> CookingMethods { get; set; }
    public DbSet<MealTime> MealTimes { get; set; }
    public DbSet<TypeOfKitchen> TypeOfKitchens { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }

    public Context(DbContextOptions<Context> options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        #region Users

        builder.Entity<User>().HasKey(x => x.Id);
        builder.Entity<User>().HasMany(x => x.Recipes)
                                .WithMany(x => x.Users)
                                .UsingEntity(x => x.ToTable("user_recipes"));
        builder.Entity<Recipe>().HasKey(x => x.Id);

        #endregion

        #region Recipes

        builder.Entity<Recipe>().HasKey(x => x.Id);
        builder.Entity<Recipe>().HasMany(x => x.Users)
                                .WithMany(x => x.Recipes)
                                .UsingEntity(x => x.ToTable("Recipe_Users"));
        builder.Entity<User>().HasKey(x => x.Id);

        builder.Entity<Recipe>().ToTable("CookingMethod");
        builder.Entity<Recipe>().HasKey(x => x.Id);
        builder.Entity<Recipe>().HasOne(x => x.CookingMethod)
                                .WithMany(x => x.Recipes)
                                .HasForeignKey(x => x.CookingMethodId)
                                .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<Recipe>().HasKey(x => x.Id);
        builder.Entity<Recipe>().HasMany(x => x.MealTimes)
                                .WithMany(x => x.Recipes)
                                .UsingEntity(x => x.ToTable("Recipe_MealTimes"));
        builder.Entity<MealTime>().HasKey(x => x.Id);

        builder.Entity<Recipe>().ToTable("TypeOfKitchen");
        builder.Entity<Recipe>().HasKey(x => x.Id);
        builder.Entity<Recipe>().HasOne(x => x.TypeOfKitchen)
                                .WithMany(x => x.Recipes)
                                .HasForeignKey(x => x.TypeOfKitchenId)
                                .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<Recipe>().HasKey(x => x.Id);
        builder.Entity<Recipe>().HasMany(x => x.Ingredients)
                                .WithMany(x => x.Recipes)
                                .UsingEntity(x => x.ToTable("Recipe_Ingredients"));
        builder.Entity<Ingredient>().HasKey(x => x.Id);

        #endregion

        #region CookingMethods

        builder.Entity<CookingMethod>().ToTable("CookingMethod");
        builder.Entity<CookingMethod>().HasKey(x => x.Id);

        #endregion

        #region MealTimes

        builder.Entity<MealTime>().HasKey(x => x.Id);
        builder.Entity<MealTime>().HasMany(x => x.Recipes)
                                .WithMany(x => x.MealTimes)
                                .UsingEntity(x => x.ToTable("MealTime_Recipes"));
        builder.Entity<Recipe>().HasKey(x => x.Id);

        #endregion

        #region TypeOfKitchens

        builder.Entity<TypeOfKitchen>().ToTable("TypeOfKitchen");
        builder.Entity<TypeOfKitchen>().HasKey(x => x.Id);

        #endregion

        #region Ingredients

        builder.Entity<Ingredient>().HasKey(x => x.Id);
        builder.Entity<Ingredient>().HasMany(x => x.Recipes)
                                .WithMany(x => x.Ingredients)
                                .UsingEntity(x => x.ToTable("Ingredient_Recipes"));
        builder.Entity<Recipe>().HasKey(x => x.Id);

        #endregion
    }
}