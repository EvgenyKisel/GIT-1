using System;

namespace SeaBattle
{
  /// <summary>
  /// This is entry point to program.
  /// </summary>
  class EntryPoint
  {
    static void Main(string[] args)
    {
      SeaBattleGame game = new SeaBattleGame(new PlaygroundCreator());
      game.PlayTheGame();
      Console.WriteLine(game.PrintInfo().ToString());
    }
  }
}