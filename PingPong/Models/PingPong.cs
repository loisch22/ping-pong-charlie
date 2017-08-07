using System;
using System.Collections.Generic;

namespace PingPongGame.Models
{
  public class PingPong
  {
    private int _number;
    private static List<object> _numberList = new List<object> {};

    public PingPong(int number)
    {
      _number = number;
    }

    public int GetNumber()
    {
      return _number;
    }

    public List<object> PingPongGame()
    {
      for (int i = 1; i <= _number; i++)
      {
        if (i % 3 == 0 && i% 5 == 0)
        {
          _numberList.Add("pingpong");
        }
        else if (i % 5 == 0)
        {
          _numberList.Add("pong");
        }
        else if (i % 3 == 0)
        {
          _numberList.Add("ping");
        }
        else
        {
          _numberList.Add(i);
        }
      }
        return _numberList;
    }

    public static void ClearAll()
    {
      _numberList.Clear();
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
