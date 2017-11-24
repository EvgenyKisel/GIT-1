using System;
using System.Collections.Generic;

namespace SeaBattle
{
  public class PlaygroundCreator
  {
    public static readonly char LETTERA = 'A';
    public static readonly char LETTERJ = 'J';
    public static readonly int MINFIELDNUMBER = 1;
    public static readonly int MAXFIELDNUMBER = 10;
    public static readonly int MINSHIPSCOUNT = 1;
    public static readonly int MAXSHIPSCOUNT = 25;

    Random random = new Random();
    List<Coordinate> ships;
    List<Coordinate> field;

    /// <summary>
    /// This method create battle field.
    /// </summary>
    public List<Coordinate> InitializeField()
    {
      field = new List<Coordinate>();
      for (int number = MINFIELDNUMBER; number <= MAXFIELDNUMBER; number++)
      {
        for (char letter = LETTERA; letter <= LETTERJ; letter++)
        {
          field.Add(new Coordinate(letter, number));
        }
      }
      return field;
    }

    /// <summary>
    /// This method adds ships to battle field.
    /// </summary>
    public List<Coordinate> FillTheFieldByShips()
    {
      int numberOfShips = random.Next(MINSHIPSCOUNT, MAXSHIPSCOUNT);
      int shipsCount = 0;
      while (shipsCount < numberOfShips)
      {
        Coordinate coordinate = new Coordinate((char)random.Next((int)LETTERA, (int)LETTERJ),
          random.Next(MINFIELDNUMBER, MAXFIELDNUMBER));
        try
        {
          AddShipToField(coordinate);
        }
        catch (InvalidCoordinateException)
        {
          continue;
        }
        shipsCount++;
      }
      return ships;
    }

    /// <summary>
    /// This method adds ship to battle field if it is possible.
    /// </summary>
    /// <param name="coordinate"> letter and number </param>
    public void AddShipToField(Coordinate coordinate)
    {
      ships = new List<Coordinate>();
      if (ships.Count == 0)
      {
        ships.Add(coordinate);
      }
      else
      {
        foreach (var ship in ships)
        {
          if ((coordinate.Letter >= ship.Letter - 1 && coordinate.Number >= ship.Number - 1)
            && (coordinate.Letter <= ship.Letter + 1 && coordinate.Number <= ship.Number + 1))
          {
            throw new InvalidCoordinateException();
          }
        }
        ships.Add(coordinate);
      }
    }
  }
}