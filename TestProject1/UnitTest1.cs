using System;
using Xunit;
using MathLibrary;

namespace MathLibraryTests
{
    public class MathFunctionsTests
    {
        [Fact]
        public void TestMultiply()
        {
            Assert.Equal(6, MathFunctions.Multiply(2, 3));
            Assert.Equal(0, MathFunctions.Multiply(0, 5));
            Assert.Equal(-15, MathFunctions.Multiply(-3, 5));
            Assert.Equal(25, MathFunctions.Multiply(5, 5));
            Assert.Equal(-16, MathFunctions.Multiply(-4, 4));
        }

        [Fact]
        public void TestDivide()
        {
            Assert.Equal(2, MathFunctions.Divide(6, 3));
            Assert.Equal(-2, MathFunctions.Divide(-6, 3));
            Assert.Equal(0, MathFunctions.Divide(0, 5));
            Assert.Equal(1, MathFunctions.Divide(5, 5));
            Assert.Throws<DivideByZeroException>(() => MathFunctions.Divide(5, 0));
        }

        [Fact]
        public void TestDistance()
        {
            Assert.Equal(5, MathFunctions.Distance(0, 0, 3, 4), 5);
            Assert.Equal(13, MathFunctions.Distance(0, 0, 5, 12), 5);
            Assert.Equal(0, MathFunctions.Distance(1, 1, 1, 1), 5);
            Assert.Equal(10, MathFunctions.Distance(0, 0, 10, 0), 5);
            Assert.Equal(10, MathFunctions.Distance(0, 0, 0, -10), 5);
        }

        [Fact]
        public void TestSolveQuadratic()
        {
            Assert.Equal((2, -1), MathFunctions.SolveQuadratic(1, -1, -2));
            Assert.Equal((1, -3), MathFunctions.SolveQuadratic(1, 2, -3));
            Assert.Equal((0, 0), MathFunctions.SolveQuadratic(1, 0, 0));
            Assert.Null(MathFunctions.SolveQuadratic(1, 0, 1).x1);
            Assert.Null(MathFunctions.SolveQuadratic(1, 0, 1).x2);
        }

        [Fact]
        public void TestGeometricSum()
        {
            Assert.Equal(7, MathFunctions.GeometricSum(1, 2, 3), 5);
            Assert.Equal(15, MathFunctions.GeometricSum(3, 1, 5), 5);
            Assert.Equal(12.1875, MathFunctions.GeometricSum(1.5, 1.5, 4), 5);
            Assert.Equal(6, MathFunctions.GeometricSum(2, 1, 3), 5);
            Assert.Equal(1, MathFunctions.GeometricSum(1, 0, 5), 5);
        }
    }
}
