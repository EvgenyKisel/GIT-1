using System.Collections.Generic;

namespace StringTransformation
{
  class WordList
  {
    public List<string> MakeWordList(string inputString)
    {
      List<string> wordList = new List<string>();
      wordList.AddRange(inputString.Split(' ', '.', ',', '!', '?', '-', ':', ';'));
      return wordList;
    }
  }
}