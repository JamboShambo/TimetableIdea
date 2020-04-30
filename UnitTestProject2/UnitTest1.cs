using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Tests if the ToString method for player works

            //ARRANGE
            Task player1 = new Player();
            player1.PlayerID = 36223;
            player1.PlayerName = "Pierce";
            player1.Losses = 5;
            player1.Wins = 9;
            player1.Draws = 2;


            string expectedToString = String.Format("{0,-35}{1,-14}{2,-14}{3,-14}{4,-14}", player1.PlayerID, player1.PlayerName, player1.Wins, player1.Losses, player1.Draws);




            //ACT
            string actualResult = player1.ToString();

            //ASSERT
            Assert.AreEqual(expectedToString, actualResult);

        }
    }
}
