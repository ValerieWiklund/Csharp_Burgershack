namespace Burgershack.Models
{
  public abstract class MenuItem
  {
    public string Name { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }



    public virtual string GetTemplate()
    {
      string template = $@"
    Name: {Name}
    Description: {Description}
    Price: {Price:c}

 Press any key to return to the main menu";
      return template;
    }

    public MenuItem(string name, double price, string desc)
    {
      Name = name;
      Price = price;
      Description = desc;
    }
  }

}