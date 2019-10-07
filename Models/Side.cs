using Burgershack.Interfaces;

namespace Burgershack.Models
{
  public class Side : MenuItem, ISize
  {
    public double SizeMultiplier { get; set; }

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

    public double GetPrice(Size s)
    {
      return BasePrice + (SizeMultiplier * (int)s);
    }

    public Side(string name, string desc, double price, int cals, int fat, int protein, int carbs, double smulti) : base(name, desc, price, cals, fat, protein, carbs)
    {
      SizeMultiplier = smulti;
    }

  }
}