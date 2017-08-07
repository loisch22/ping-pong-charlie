using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PingPong;

namespace PingPong.Tests
{
  [TestClass]
  public class PingPongTest
  {
    [TestMethod]
    public void GetNumber_ReturnsNumbers_int()
    {
      PingPong testPingPong = new PingPong(1);
       int expected = 1;
      // public int test = testPingPong.GetNumber();
      Assert.AreEqual(expected, testPingPong.GetNumber());
    }
  }
}
