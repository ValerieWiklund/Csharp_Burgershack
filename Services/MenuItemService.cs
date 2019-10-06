using System.Collections.Generic;
using Burgershack.Models;

namespace Burgershack.Services
{
  public class MenuItemService
  {

    public List<MenuItem> Items { get; set; }
    public List<string> Messages { get; set; }

    public void Setup()
    {
      Sandwich burger = new Sandwich("Happy Burger", 3.95, "Grilled hamburger patty on a sesame seed bun with lettuce, tomato, onion, ketchup and mustard");
      Sandwich chburger = new Sandwich("Cheesy Burger", 4.95, "Grilled hamburger patty with 2 slices of American cheese on a sesame seed bun with lettuce, tomato, onion, ketchup and mustard");

      Drink soda = new Drink("Soda", 1.50, "Your preferred flavor from our fountain drinks");
      Drink shake = new Drink("Milkshake", 2.95, "Yummy, delicious ice cream drink");

      Side fries = new Side("French Fries", 1.50, "Shoestring fries cooked to a crispy golden brown");
      Side tots = new Side("Tater Tots", 1.95, "potato tots fried crispy");

      Items.AddRange(new MenuItem[] { burger, chburger, soda, shake, fries, tots });
    }

    internal void GetMenu(int index)
    {
      if (index < Items.Count && index > -1)
      {
        MenuItem item = Items[index];
        Messages.Add(item.GetTemplate());
      }
      else
      {
        Messages.Add("Invalid Choice");
      }

    }


    public void GetMenu()
    {
      Messages.Add("Menu");
      for (int i = 0; i < Items.Count; i++)
      {
        MenuItem item = Items[i];
        Messages.Add($"{i + 1}: {item.Name} - {item.Price}");
      }
      Messages.Add("Type a number to see details or Q to quit");
    }



    public MenuItemService()
    {
      Items = new List<MenuItem>();
      Messages = new List<string>();
      Setup();
    }

  }
}