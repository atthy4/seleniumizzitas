using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        public void NewMethodTest()
        {
            //Arrange
            int[] tomb = new int[] { 3, 2, 1 };
            //Act
            int[] rendezett = Program.NewMethod(tomb);
            //Assert
            Assert.AreEqual(rendezett[0], 1);
        }

        [TestMethod()]
        public void NewMethodTest2()
        {
            //arrange
            int[] tomb = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            //act
            int[] rendezett = Program.NewMethod(tomb);
            //assert
            for (int i = 0; i < rendezett.Length; i++)
            {
                if (i + 1 < rendezett.Length)
                {
                    Assert.IsTrue(rendezett[i] < rendezett[i + 1]);
                }
            }
        }
    }
}
