using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class EvenTest
    {
        [TestMethod]
        public void EvenInstance()
        {
            Even  evenNumber = new Even();

            Assert.IsNotNull(evenNumber);
        }

        [TestMethod]
        public void EvenFirst()
        {
            //Arrange(where you set stuff up)
            Even evenNumber = new Even();

            //Act(call method being tested)
            int expectedResult = 2;
            int actualResult = evenNumber.GetFirst();

            //Assert(check the output from method)
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void EvenNextTest()
        {
            //arrange
            Even evenNumber = new Even();

            //act
            int expectedResult = 4;
            int actualResult = evenNumber.GetNext(2)
;
            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void EvenSequenceTest()
        {
            //arrange
            Even evenNumber = new Even();

            //act
            int[] expectedResult = { 2, 4, 6, 8, 10 };
            int[] actualResult = evenNumber.GetSequence(5);

            //assert
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        public void EvenPrintTest()
        {
            //arrange
            Even evenNumber = new Even();

            //act
            string expectedResult = "1 2 3 4 5";
            int[] inputArray = new[] { 1, 2, 3, 4, 5 };
            string actualResult = evenNumber.PrintNumbers(inputArray);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
