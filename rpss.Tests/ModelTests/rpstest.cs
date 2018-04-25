using Microsoft.VisualStudio.TestTools.UnitTesting;
using rpsgame.Models;
using System.Collections.Generic;
using System;

namespace rpss.Tests
{
  [TestClass]
  public class rpsTest
  {
  [TestMethod]
  public void test()
    {
      string player1 = "scissor";
      string player2 = "rock";
      rps game = new rps(player1, player2);
      string result = game.rpsgame();
      string description = "player2 wins";
      Assert.AreEqual(description, result);
    }
  }
}
