using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SquaresOfFiguresLib.Test
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void SquareCircle_7_returned_153_9()
        {
            //arrange
            SquareCircle circle1 = new SquareCircle(7);
            double expected = 153.9;
            //act
            double actual = circle1.CalcSquare();
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void SquareTriangle_4and5and3_returned_6()
        {
            //arrange
            SquareTriangle triangle = new SquareTriangle(4, 5, 3);
            double expected = 6;

            //act
            double actual = triangle.CalcSquare();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Rectangular_Rectangle_returned_True()
        {
            //Arrange
            var triangle = new SquareTriangle( 4, 3, 5);

            //Act
            var actual = triangle.Rectangular();

            //Assert
            Assert.IsTrue(actual);
        }
    }
}
