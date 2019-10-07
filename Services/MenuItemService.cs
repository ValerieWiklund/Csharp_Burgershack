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
      Sandwich burger = new Sandwich("Happy Burger", "Grilled hamburger patty on a sesame seed bun with lettuce, tomato, onion, ketchup and mustard", 3.95, 1500, 30, 25, 15);
      Sandwich chburger = new Sandwich("Cheesy Burger", "Grilled hamburger patty with 2 slices of American cheese on a sesame seed bun with lettuce, tomato, onion, ketchup and mustard", 4.95, 1500, 30, 25, 15);

      Drink soda = new Drink("Soda", "Your preferred flavor from our fountain drinks", 1.50, 350, 0, 0, 15, true, .25);
      Drink shake = new Drink("Milkshake", "Yummy, delicious ice cream drink", 2.95, 350, 0, 0, 15, false, .25);

      Side fries = new Side("French Fries", "Shoestring fries cooked to a crispy golden brown", 1.50, 350, 30, 0, 25, .25);
      Side tots = new Side("Tater Tots", "potato tots fried crispy", 1.95, 350, 30, 0, 25, .25);

      Items.AddRange(new MenuItem[] { burger, chburger, soda, shake, fries, tots });
    }

    internal void GetMenu(int index, string )
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
        Messages.Add($"{i + 1}: {item.Name} - {item.BasePrice}");
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