using Burgershack.Interfaces;

namespace Burgershack.Models
{
  public abstract class MenuItem : IPurchasable, IConsumable

  {
    public string Name { get; set; }
    public string Description { get; set; }
    public double BasePrice { get; set; }
    public int Calories { get; set; }
    public int Fat { get; set; }
    public int Protein { get; set; }
    public int Carbohydrates { get; set; }

    public virtual string GetTemplate()
    {
      string template = $@"
    Name: {Name}
    Description: {Description}
    Price: {BasePrice:c}
    Calories: {Calories}
    Fat: {Fat}
    Protein: {Protein}
    Carbohydrates: {Carbohydrates}

 Press any key to return to the main menu";
      return template;
    }
    public MenuItem(string name, string desc, double price, int cals, int fat, int protein, int carbs)
    {
      Name = name;
      Description = desc;
      BasePrice = price;
      Calories = cals;
      Fat = fat;
      Protein = protein;
      Carbohydrates = carbs;

    }

  }

}