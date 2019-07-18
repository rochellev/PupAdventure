using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using GameSpace;

namespace GameSpace.Test
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void InitCorrect_True()
        {
            Game testGame = new Game();
            Assert.AreEqual("Sir", testGame.Name);
            testGame.Name = "TestName";
            Assert.AreEqual("TestName", testGame.Name);
            string apple = "apple";
            Game secondGame = new Game(apple);
            Assert.AreEqual(apple, secondGame.Name);
            
        }
    }
}