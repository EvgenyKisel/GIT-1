using System;
using System.Collections.Generic;
using System.Text;

namespace SeaBattle
{
  /// <summary>
  /// This is main class for the game.
  /// </summary>
  public class SeaBattleGame
  {
    public static readonly string KILLEDMESSAGE = "Killed one.";
    public static readonly string MISSEDMESSAGE = "Missed.";

    public List<Coordinate> Ships { get; set; }
    public List<Coordinate> Field { get; set; }
    int shotsCount;
    int fallenShipsCount;

    public SeaBattleGame(PlaygroundCreator playground)
    {
      Field = playground.InitializeField();
      Ships = playground.FillTheFieldByShips();
    }
    /// <summary>
    /// This method remove ship from list, if you entered right coordinates and prints corresponding message.
    /// </summary>
    /// <param name="coordinate"></param>
    public void Shot(Coordinate coordinate)
    {
      shotsCount++;
      foreach (var ship in Ships)
      {
        if (coordinate.Letter == ship.Letter && coordinate.Number == ship.Number)
        {
          Console.WriteLine(KILLEDMESSAGE);
          Ships.Remove(ship);
          fallenShipsCount++;
          break;
        }
        else
        {
          Console.WriteLine(MISSEDMESSAGE);
        }
      }
    }

    /// <summary>
    /// This method takes coordinate from console.
    /// </summary>
    /// <returns> inputted coordinate </returns>
    public Coordinate InputCoordinate()
    {
      char letter = ' ';
      int number = 0;
      bool legalNumber = true;
      while (legalNumber)
      {
        try
        {
          Console.Write("Input the letter: ");
          letter = char.Parse(Console.ReadLine().ToUpper());
          Console.Write("\nInput the number: ");
          number = int.Parse(Console.ReadLine());
          break;
        }
        catch (FormatException)
        {
          continue;
        }
      }
      return new Coordinate(letter, number);
    }

    /// <summary>
    /// This method calls method that inputs coordinate and shots the ship.
    /// </summary>
    public void PlayTheGame()
    {
      while (Ships.Count != 0)
      {
        Coordinate coordinate = null;
        try
        {
          coordinate = InputCoordinate();
        }
        catch (Exception exception)
        {
          Console.WriteLine(exception.Message);
          continue;
        }
        Shot(coordinate);
      }
    }

    /// <summary>
    /// This method prints info.
    /// </summary>
    /// <returns> shots and fallen ships counts</returns>
    public StringBuilder PrintInfo()
    {
      StringBuilder info = new StringBuilder();
      info.Append("Shots count = ").Append(shotsCount).Append(", fallen ships count = ").Append(fallenShipsCount);
      return info;
    }
  }
}