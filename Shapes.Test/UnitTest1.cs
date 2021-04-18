using System;
using Volume;  // Без этого почему-то не работает
using Xunit;

namespace Shapes.Test
{
    public class UnitTestShapes
    {
        [Fact]
        public void BoxVolumeTest()

        {
            Box box = new Box(10);
            double result = box.Volume();
            Assert.Equal(1000, result, 1);
        }

        [Fact]
        public void FreeBoxVolumeTest()
        {
            Box box = new Box(10);
            double result = box.FreeVolume();
            Assert.Equal(1000, result, 1);
        }
        [Theory]
        [InlineData(10, 8)]
        public void TestBoxAddition(double box1Height, double box2Height)
        {
            Box box1 = new Box(box1Height);
            Box box2 = new Box(box2Height);
            Assert.True(box1.Add(box2));
            Assert.False(box2.Add(box1));
        }

        [Theory]
        [InlineData(10, 5)]
        public void RemainingVolumeCalculate(double box1Height, double box2Height)
        {
            Box box1 = new Box(box1Height);
            Box box2 = new Box(box2Height);
            box1.Add(box2);
            double result = box1.FreeVolume();
            Assert.Equal(875, result, 1);
        }

        [Theory]
        [InlineData(5, 20)]
        public void CylinderVolumeTest(double radius, double height)
        {
            Cylinder testCylinder = new Cylinder(radius, height);
            double result = testCylinder.Volume();
            Assert.Equal(1570.79, result, 1);
        }


        [Fact]
        public void BallVolumeTest()

        {
            Ball testBall = new Ball(10);
            double result = testBall.Volume();
            Assert.Equal(4188.79, result, 1);
        }

        [Theory]
        [InlineData(25, 30)]
        public void PyramidVolumeTest(double baseS, double height)
        {
            Pyramid testPyramid = new Pyramid(baseS, height);
            double result = testPyramid.Volume();
            Assert.Equal(250, result, 1);
        }
    }
}
