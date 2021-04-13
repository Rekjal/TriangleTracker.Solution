using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TriangleChecker_CheckValidTriangle_NotATriangle()
        {
            Triangle testTriangle = new Triangle();
            string testResult = "A Triangle";
            Assert.AreEqual(testResult, testTriangle.TriangleChecker(4,3,8));
        }

        // [TestMethod]
        // public void IsLeapYear_NumberNotDivisibleByFour_False()
        // {
        //     LeapYear testLeapYear = new LeapYear();
        //     Assert.AreEqual(false, testLeapYear.IsLeapYear(1999));
        // }

        // [TestMethod]
        // public void IsLeapYear_MultiplesOfOneHundred_False()
        // {
        //     LeapYear testLeapYear = new LeapYear();
        //     Assert.AreEqual(false, testLeapYear.IsLeapYear(1900));
        // }

        // [TestMethod]
        // public void IsLeapYear_MultiplesOfFourHundred_True()
        // {
        //     LeapYear testLeapYear = new LeapYear();
        //     Assert.AreEqual(true, testLeapYear.IsLeapYear(2000));
        // }

    }
}