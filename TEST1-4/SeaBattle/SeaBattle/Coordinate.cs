namespace SeaBattle
{
  /// <summary>
  /// This is class that contains letter and number.
  /// </summary>
  public class Coordinate
  {
    private char letter;
    private int number;

    public char Letter
    {
      get
      {
        return letter;
      }
      set
      {
        if (value < 'A' || value > 'J')
        {
          throw new InvalidLetterException();
        }
        letter = value;
      }
    }

    public int Number
    {
      get
      {
        return number;
      }
      set
      {
        if (value < 1 || value > 10)
        {
          throw new InvalidNumberException();
        }
        number = value;
      }
    }

    /// <summary>
    /// This is constructor for Coordinate class.
    /// </summary>
    /// <param name="letter"> inputted letter </param>
    /// <param name="number"> inputted number </param>
    public Coordinate(char letter, int number)
    {
      Letter = letter;
      Number = number;
    }
  }
}