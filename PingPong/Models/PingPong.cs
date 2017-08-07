using System.Collections.Generic;

namespace PingPong
{
  public class PingPong
  {
    private int _number;
    private static List<object> _numberList = new List<object> ();

    public PingPong(int number)
    {
      _number = number;
    }

    public int GetNumber()
    {
      return _number;
    }

    // public static List<object> GetNumberList()
    // {
    //   return _numberList;
    // }

    // public int PingPongGame()
    // {
    //   return 1;
    // }
    //
    // public List<int> PingPongto2()
    // {
    //   List<int> num1and2 = new List<int> {1,2};
    //   return num1and2;
    // }

  }
}
