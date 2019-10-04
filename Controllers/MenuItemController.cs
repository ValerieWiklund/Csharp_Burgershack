using System;
using Burgershack.Services;

namespace Burgershack.Controllers
{
  public class MenuItemController
  {
    public MenuItemController()
    {
    }

    private MenuItemService _menuItemService { get; set; } = new MenuItemService();



    public void GetInput()
    {
      _menuItemService.GetMenu();
      Print();
      string choice = Console.ReadLine();
      Console.Clear();
      switch (choice)
      {
        case "q":
          Environment.Exit(1);
          break;

      }

    }

    private void Print()
    {
      foreach (string message in _menuItemService.Messages)
      {
        System.Console.WriteLine("Made it to Print in Controller");
        System.Console.WriteLine(message);
      }
      _menuItemService.Messages.Clear();

    }
  }
}