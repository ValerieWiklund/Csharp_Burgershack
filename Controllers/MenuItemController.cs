using System;
using Burgershack.Services;

namespace Burgershack.Controllers
{
  public class MenuItemController
  {
    // public MenuItemController()
    // {
    // }

    private MenuItemService _menuItemService { get; set; } = new MenuItemService();

    public void GetInput()
    {
      _menuItemService.GetMenu();
      Print();
      string choice = Console.ReadLine().ToLower();
      Console.Clear();
      switch (choice)
      {
        case "q":
          Environment.Exit(1);
          break;
        default:
          if (int.TryParse(choice, out int index))
          {
            _menuItemService.GetMenu(index - 1);
            Print();
            Console.ReadKey();
            Console.Clear();
          }
          else
          {
            System.Console.WriteLine("Invalid Command");
          }
          break;
      }

    }

    private void Print()
    {
      foreach (string message in _menuItemService.Messages)
      {
        System.Console.WriteLine(message);
      }
      _menuItemService.Messages.Clear();

    }
  }
}