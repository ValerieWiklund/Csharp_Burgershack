using System;
using Burgershack.Controllers;

namespace Burgershack
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      MenuItemController mic = new MenuItemController();
      while (true)
      {
        mic.GetInput();
      }


    }
  }
}
