using System;
using System.Collections;
using System.IO;
using System.Text;

namespace RepeatedValuesCount
{
  public class ListOfValues
  {
    public ArrayList ValuesList { get; set; }

    /// <summary>
    /// This method allocates memory for the collection, initializes this collection by values from file. 
    /// </summary>
    /// <param name="filePath"> takes the path of our file </param>
    public ArrayList InitializeList(string filePath)
    {
      ValuesList = new ArrayList();
      using (StreamReader streamReader = new StreamReader(filePath, Encoding.Default))
      {
        while (!streamReader.EndOfStream)
        {
          ValuesList.Add(streamReader.ReadLine());
        }
      }
      return ValuesList;
    }

    /// <summary>
    /// This method prints collection on console.
    /// </summary>
    public void OutputListOnConsole()
    {
      StringBuilder valuesListString = new StringBuilder();
      foreach (object element in ValuesList)
      {
        valuesListString.Append(element).Append(" ");
      }
      Console.WriteLine(valuesListString.ToString());
    }

    /// <summary>
    /// This method count repeated values in collection. 
    /// </summary>
    /// <returns> count of repeated values in collection </returns>
    public int CountRepeatedElements(ArrayList valuesList)
    {
      valuesList.Sort();
      int count = 0;
      if (valuesList.Count > 0 && valuesList[0].Equals(valuesList[1]))
      {
        count++;
      }
      for (int i = 1; i < valuesList.Count - 1; i++)
      {
        if (valuesList[i].Equals(valuesList[i - 1]) && !(valuesList[i].Equals(valuesList[i + 1])))
        {
          count++;
        }
      }
      return count;
    }
  }
}
/*using System.Collections.Generic;

namespace RepeatedValuesCount
{
  public class ListOfValues
  {
    public List<int> valuesList = new List<int>();

    /// <summary>
    /// This method count repeated values in collection. 
    /// </summary>
    /// <returns> count of repeated values in collection </returns>
    public int CountRepeatedElements(List<int> values)
    {
      valuesList.AddRange(values);
      valuesList.Sort();
      int count = 0;
      if (valuesList.Count > 0 && valuesList[0].Equals(valuesList[1]))
      {
        count++;
      }
      for (int i = 1; i < valuesList.Count - 1; i++)
      {
        if (valuesList[i].Equals(valuesList[i - 1]) && !(valuesList[i].Equals(valuesList[i + 1])))
        {
          count++;
        }
      }
      return count;
    }
  }
}*/