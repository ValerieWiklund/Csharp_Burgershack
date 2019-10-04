namespace Burgershack.Models
{
  public class Sandwich : MenuItem
  {




    public override string GetTemplate()
    {
      return $@"
    Name: {Name}
    Description: {Description}
    Price: {Price:c}

 Press any key to return to the main menu";
    }




    public Sandwich(string name, double price, string desc) : base(name, price, desc)
    {
    }
  }
}
