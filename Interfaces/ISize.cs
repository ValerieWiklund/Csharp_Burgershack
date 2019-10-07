namespace Burgershack.Interfaces
{
  public interface ISize
  {
    double SizeMultiplier { get; set; }
    double GetPrice(Size s);

  }


  public enum Size
  {
    small,
    medium,
    large,
    xlarge

  }
}