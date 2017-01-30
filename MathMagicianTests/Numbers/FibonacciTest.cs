using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class FibonacciTest
    {   
        // F3 = F2 + F1
        // F7 = F6 + F5
        [TestMethod]
        public void FiboInstance()
        {
            Fibonacci fiboNumber = new Fibonacci();

            Assert.IsNotNull(fiboNumber);
        }
        [TestMethod]
        public void FiboFirst()
        {
            //Arrange(where you set stuff up)
            Fibonacci fiboNumber = new Fibonacci();

            //Act(call method being tested)
            int expectedResult = 1;
            int actualResult = fiboNumber.GetFirst();

            //Assert(check the output from method)
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void FiboNextTest()
        {
            //arrange
            Fibonacci fiboNumber = new Fibonacci();

            //act
            int expectedResult = 1;
            int actualResult = fiboNumber.GetNext(1)
;
            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void NatSequenceTest()
        {
            //arrange
            Fibonacci fiboNumber = new Fibonacci();

            //act
            int[] expectedResult = { 1, 1, 2, 3, 5 };
            int[] actualResult = fiboNumber.GetSequence(5);

            //assert
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        public void NatPrintTest()
        {
            //arrange
            Fibonacci fiboNumber = new Fibonacci();

            //act
            string expectedResult = "1 1 2 3 5";
            int[] inputArray = new[] { 1, 1, 2, 3, 5 };
            string actualResult = fiboNumber.PrintNumbers(inputArray);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
