using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PingPongGame.Models;
using System;

namespace PingPongGame.Tests
{
  [TestClass]
  public class PingPongTest : IDisposable
  {
    [TestMethod]
    public void Dispose()
    {
      PingPong.ClearAll();
    }
    [TestMethod]
    public void GetNumber_ReturnsNumbers_int()
    {
      PingPong testPingPong = new PingPong(1);
      int expected = 1;
      int test = testPingPong.GetNumber();
      Assert.AreEqual(expected, test);
    }
    [TestMethod]
    public void PingPongGame_Returns12_12()
    {
      PingPong testPingPong = new PingPong(2);
      List<object> expected = new List<object>{1,2};

      List<object> actual =  testPingPong.PingPongGame();

      CollectionAssert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void PingPongGame_Return12Ping_12Ping()
    {
      PingPong testPingPong = new PingPong(3);
      List<object> expected = new List<object>{1,2,"ping"};

      List<object> actual = testPingPong.PingPongGame();
      // actual.ForEach(Console.WriteLine);
      CollectionAssert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void PingPongGame_Return12ping4pong_12ping4pong()
    {
      PingPong testPingPong = new PingPong(5);
      List<object> expected = new List<object>{1,2,"ping",4,"pong"};

      List<object> actual = testPingPong.PingPongGame();

      CollectionAssert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void PingPongGame_ReturnPingPongAt15_PingPong()
    {
      PingPong testPingPong = new PingPong(15);
      List<object> expected = new List<object>{1,2,"ping",4,"pong","ping",7,8,"ping","pong",11,"ping",13,14,"pingpong"};

      List<object> actual = testPingPong.PingPongGame();

      CollectionAssert.AreEqual(expected, actual);
    }
  }
}
