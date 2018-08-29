using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solver;

namespace SolverTests
{
    [TestClass]
    public class SolverTest
    {
        void Test(double a, double b, double c, double[] expectedResult)
        {

            var result = Quadratic.Solve(a, b, c);

            // Assert
            Assert.AreEqual(expectedResult.Length, result.Length);

            for (int i = 0; i < result.Length; i++)
                Assert.AreEqual(expectedResult[i], result[i]);
        }

        // 1
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var a = 1;
            var b = -3;
            var c = 2;

            // Act
            var result = Quadratic.Solve(a, b, c);

            // Assert
            Assert.AreEqual(2, result.Length);
            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(1, result[1]);
        }

        [TestMethod]
        public void Negative()
        {
            // Arrange
            var a = 1;
            var b = 1;
            var c = 1;

            // Act
            var result = Quadratic.Solve(a, b, c);

            // Assert
            Assert.AreEqual(0, result.Length);
        }
    }
}
