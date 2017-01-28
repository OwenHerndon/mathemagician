using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class NaturalNumberTests
    {
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            NaturalNumber naturalNumber = new NaturalNumber();

            Assert.IsNotNull(naturalNumber);
        }
        [TestMethod]
        public void EnsureOneIsTheFirst()
        {
            //Arrange(where you set stuff up)
            NaturalNumber naturalNumber = new NaturalNumber();

            //Act(call method being tested)
            int expectedResult = 1;
            int actualResult = naturalNumber.GetFirst();

            //Assert(check the output from method)
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void GetNextTest()
        {
            //arrange
            NaturalNumber naturalNumber = new NaturalNumber();

            //act
            int expectedResult = 2;
            int actualResult = naturalNumber.GetNext(1)
;
            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void SequenceTest()
        {
            //arrange
            NaturalNumber naturalNumber = new NaturalNumber();

            //act
            int expectedResult = [1,2,3,4,5];
            int actualResult = naturalNumber.GetSequence();

            //assert
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
