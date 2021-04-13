using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker.Models;

namespace TriangleTracker.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TriangleChecker_CheckValidTriangle_True()
        {
            // Triangle testTriangle = new Triangle();
            string testResult = "Not A Triangle";
            // Assert.AreEqual(testResult, testTriangle.TriangleChecker(4,3,8));
            Assert.AreEqual(testResult, Triangle.TriangleChecker(4,3,8));
        }

        [TestMethod]

        public void TriangleChecker_CheckEquilateral_True()
        {
            // Triangle testTriangle = new Triangle();
            string testResult = "Your triangle is an equilateral triangle";
            // Assert.AreEqual(testResult, testTriangle.TriangleChecker(4,4,4));
            Assert.AreEqual(testResult, Triangle.TriangleChecker(4,4,4));
        }

        [TestMethod]

        public void TriangleChecker_CheckIsosceles_True()
        {
            // Triangle testTriangle = new Triangle();
            string testResult = "Your triangle is an isosceles triangle";
            // Assert.AreEqual(testResult, testTriangle.TriangleChecker(4,4,7));
            Assert.AreEqual(testResult, Triangle.TriangleChecker(4,4,7));
        }

        [TestMethod]


        public void TriangleChecker_CheckScalene_True()
        {
            // Triangle testTriangle = new Triangle();
            string testResult = "Your triangle is a scalene triangle";
            // Assert.AreEqual(testResult, testTriangle.TriangleChecker(4,5,7));
            Assert.AreEqual(testResult, Triangle.TriangleChecker(4,5,7));
        }
    }
}