namespace Burgershack.Models
{
  public class Sandwich : MenuItem
  {


    public override string GetTemplate()
    {
      return $@"
    Name: {Name}
    Description: {Description}
    Price: {BasePrice:c}
    Calories: {Calories}
    Fat: {Fat}
    Protein: {Protein}
    Carbohydrates: {Carbohydrates}

 Press any key to return to the main menu";
    }


    public Sandwich(string name, string desc, double price, int cals, int fat, int protein, int carbs) : base(name, desc, price, cals, fat, protein, carbs)
    {
    }

  }
}
