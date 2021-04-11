using System;
using System.Collections.Generic;
using Xunit;

namespace Shapes3d.Tests
{
    public class UnitTestShapes3d
    {
        
        // Tests for Shapes3d
        
        [Fact]
        public void BoxVolumeTest()
        {
            // Arrange
            Box box = new Box(10);

            // Act
            double result = box.Volume();

            //Assert
            Assert.Equal(1000.0, result, 3);
        }

        [Fact]

        public void BallVolumeTest()
        {
            Ball ball = new Ball(10);

            double result = ball.Volume();

            Assert.Equal(4188.79, result, 2);
        }

        [Fact]

        public void CylinderVolumeTest()
        {
            Cylinder cylinder = new Cylinder(10, 10);

            double result = cylinder.Volume();

            Assert.Equal(3141.59, result, 2);
        }

        [Fact]
        public void PyramidVolumeTest()
        {
            Pyramid pyramid = new Pyramid(100, 3);

            double result = pyramid.Volume();

            Assert.Equal(100, result, 2);
        }

        [Theory]
        [InlineData(20, 10)]

        public void TestShapeAddition(double containerHeigth, double ballRadius)
        {
            var box = new Box(containerHeigth);
            var ball = new Ball(ballRadius);

            Assert.True(box.Add(ball));
        }

    }
}

namespace PerimetrCalculation.Tests
{
    public class UnitTestPerimetrCalculation
    {
        // Tests for PerimetrCalculation
        [Fact]

        public void TestPerimetrTriangle()
        {
            Polygon polygon = new Polygon(new Point(10, 0, 1), new Point(10,3,2), new Point(14,0,3));

            double result = polygon.Perimeter();

            Assert.Equal(12.0, result, 2);
        }

        [Fact]
        public void TestPerimetrQuadrangle()
        {
            Polygon polygon = new Polygon(new Point[] { new Point(0, 0, 1), new Point(0, 3, 2), new Point(4, 3, 3), new Point(4, 0, 4) });

            double result = polygon.Perimeter();

            Assert.Equal(14.0, result, 2);
        }

        [Fact]

        public void TestPerimetrPentagon()
        {
            Polygon polygon = new Polygon(new Point[] { new Point(0, -3, 1), new Point(0, 3, 2), new Point(2, 3, 3), new Point(6, 0, 4), new Point(2, -3, 4) });

            double result = polygon.Perimeter();

            Assert.Equal(20.0, result, 2);
        }
    }
}

namespace Vector.Tests
{
    public class UnitTestVector
    {

    }
}
