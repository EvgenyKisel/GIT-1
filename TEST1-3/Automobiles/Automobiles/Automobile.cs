using System.Text;

namespace Automobiles
{
  public class Automobile
  {
    public string Mark { get; set; }
    public string Model { get; set; }
    public string Type { get; set; }
    private decimal price;
    public decimal Price
    {
      get
      {
        return price;
      }
      set
      {
        if (value < 0)
        {
          throw new UncorrectPriceException();
        }
        price = value;
      }
    }

    /// <summary>
    /// This is constructor for class Automobile.
    /// </summary>
    /// <param name="mark"> inputted mark </param>
    /// <param name="model"> inputted model </param>
    /// <param name="type"> inputted type </param>
    /// <param name="price"> inputted price </param>
    public Automobile(string mark, string model, string type, decimal price)
    {
      Mark = mark;
      Model = model;
      Type = type;
      Price = price;
    }

    /// <summary>
    /// This is override of method ToString().
    /// </summary>
    /// <returns> string information about automobile </returns>
    public override string ToString()
    {
      StringBuilder automobileInfo = new StringBuilder();
      automobileInfo.Append($"Mark = {Mark}, Model = {Model}, Type = {Type}, Price = {Price:C}");
      return automobileInfo.ToString();
    }
  }
}