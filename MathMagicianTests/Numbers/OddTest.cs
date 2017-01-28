using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class OddTest
    {
        [TestMethod]
        public void OddInstance()
        {
            Odd oddNumber = new Odd();

            Assert.IsNotNull(oddNumber);
        }

        [TestMethod]
        public void OddFirst()
        {
            //Arrange(where you set stuff up)
            Odd oddNumber = new Odd();

            //Act(call method being tested)
            int expectedResult = 1;
            int actualResult = oddNumber.GetFirst();

            //Assert(check the output from method)
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void OddNextTest()
        {
            //arrange
            Odd oddNumber = new Odd();

            //act
            int expectedResult = 3;
            int actualResult = oddNumber.GetNext(1)
;
            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void EvenSequenceTest()
        {
            //arrange
            Odd oddNumber = new Odd();

            //act
            int[] expectedResult = { 1, 3, 5, 7, 9 };
            int[] actualResult = oddNumber.GetSequence(5);

            //assert
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        public void OddPrintTest()
        {
            //arrange
            Odd oddNumber = new Odd();

            //act
            string expectedResult = "1 3 5 7 9";
            int[] inputArray = new[] { 1, 3, 5, 7, 9 };
            string actualResult = oddNumber.PrintNumbers(inputArray);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
