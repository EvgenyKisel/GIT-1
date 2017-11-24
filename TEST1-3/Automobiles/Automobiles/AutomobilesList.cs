using System;
using System.Collections.Generic;

namespace Automobiles
{
  public class AutomobilesList
  {
    public List<Automobile> Automobiles { get; set; }

    /// <summary>
    /// This method creates list of automobiles.
    /// </summary>
    /// <returns> list of automobiles </returns>
    public List<Automobile> AddAutomobiles()
    {
      Automobiles = new List<Automobile>();
      AutomobileCreator automobileBuilder = new AutomobileCreator();
      Automobiles.Add(automobileBuilder.BuildAutomobile());
      while (automobileBuilder.DoYouWantToAddOneMoreAutomobile())
      {
        Automobiles.Add(automobileBuilder.BuildAutomobile());
      }
      return Automobiles;
    }

    /// <summary>
    /// This method sorts automobiles by price.
    /// </summary>
    /// <returns> sorted automobiles by price </returns>
    public List<Automobile> SortAutomobilesByPrice(List<Automobile> Automobiles)
    {
      Automobile temp = null;
      for (int i = 0; i < Automobiles.Count; i++)
      {
        for (int j = i + 1; j < Automobiles.Count; j++)
          if (Automobiles[i].Price > Automobiles[j].Price)
          {
            temp = Automobiles[i];
            Automobiles[i] = Automobiles[j];
            Automobiles[j] = temp;
          }
      }
      return Automobiles;
    }

    /// <summary>
    /// This method sort automobiles with equal price by type.
    /// </summary>
    /// <returns> sorted automobiles with equal price by type </returns>
    public List<Automobile> SortAutomobilesWithEqualPriceByType(List<Automobile> Automobiles)
    {
      Automobile temp = null;
      for (int i = 0; i < Automobiles.Count; i++)
      {
        for (int j = i + 1; j < Automobiles.Count; j++)
        {
          if (Automobiles[i].Price == Automobiles[j].Price &&
            Automobiles[i].Type.CompareTo(Automobiles[j].Type) > 0)
          {
            temp = Automobiles[i];
            Automobiles[i] = Automobiles[j];
            Automobiles[j] = temp;
          }
        }
      }
      return Automobiles;
    }

    /// <summary>
    /// This method sorts automobiles with equal price and type by mark.
    /// </summary>
    /// <returns> sorted automobiles with Equal price and type by mark </returns>
    public List<Automobile> SortAutomobilesWithEqualPriceAndTypeByMark(List<Automobile> Automobiles)
    {
      Automobile temp = null;
      for (int i = 0; i < Automobiles.Count; i++)
      {
        for (int j = i + 1; j < Automobiles.Count; j++)
        {
          if (Automobiles[i].Type.Equals(Automobiles[j].Type) &&
            Automobiles[i].Mark.CompareTo(Automobiles[j].Mark) > 0)
          {
            temp = Automobiles[i];
            Automobiles[i] = Automobiles[j];
            Automobiles[j] = temp;
          }
        }
      }
      return Automobiles;
    }

    /// <summary>
    /// This method sorts automobiles by price, then by type and mark.
    /// </summary>
    /// <returns> sorted automobiles </returns>
    public List<Automobile> SortAutomobiles()
    {
      Automobiles = SortAutomobilesByPrice(Automobiles);
      Automobiles = SortAutomobilesWithEqualPriceByType(Automobiles);
      Automobiles = SortAutomobilesWithEqualPriceAndTypeByMark(Automobiles);
      return Automobiles;
    }

    /// <summary>
    /// This method prints automobiles on console.
    /// </summary>
    public void Print()
    {
      foreach (Automobile auto in Automobiles)
      {
        Console.WriteLine(auto.ToString());
      }
    }
  }
}
/*/// <summary>
/// This method sorts automobiles by price, then by type and mark.
/// </summary>
/// <param name="automobiles"></param>
public List<Automobile> SortAutomobiles()
{
  var result = from automobile in Automobiles
               orderby automobile.Price, automobile.Type, automobile.Mark
               select automobile;
  List<Automobile> sortedCars = new List<Automobile>();
  foreach (Automobile auto in result)
  {
    sortedCars.Add(auto);
  }
  return sortedCars;
}*/