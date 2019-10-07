using System;
using Burgershack.Interfaces;

namespace Burgershack.Models
{
  public class Drink : MenuItem, ISize
  {
    public bool Fountain { get; set; }
    public double SizeMultiplier { get; set; }

    public override string GetTemplate()
    {
      return $@"
  Name: {Name}
    Description: {Description}
    Price: {BasePrice:c}
    Fountain: {Fountain}
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

    public Drink(string name, string desc, double price, int cals, int fat, int protein, int carbs, bool fount, double smulti) : base(name, desc, price, cals, fat, protein, carbs)
    {
      Fountain = fount;
      SizeMultiplier = smulti;
    }



  }
}